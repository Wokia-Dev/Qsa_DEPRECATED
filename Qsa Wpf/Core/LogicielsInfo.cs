﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows;
using System.Diagnostics;
using System.Threading;

namespace Qsa_Wpf.Core
{
    public class LogicielsInfo
    {
        public string _nom;
        public int _count;
        public string _url;
        public string _cmdUrl;
        public string _nomFichier;
        public string _nomFichierCmd;

        public LogicielsInfo(string nom, int count, string url, string cmdUrl, string nomFichier, string nomFichierCmd)
        {
            _nom = nom;
            _count = count;
            _url = url;
            _cmdUrl = cmdUrl;
            _nomFichier = nomFichier;
            _nomFichierCmd = nomFichierCmd;
        }

        public void DowloadFiles(string nomFichierCmd, string nomFichier, string url, string cmdUrl)
        {
            if (File.Exists(Path.GetTempPath() + nomFichier))
            {
                return;
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, Path.GetTempPath() + nomFichier);
            }
            if(File.Exists(Path.GetTempPath() + nomFichierCmd))
            {
                return;
            }
            else
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(cmdUrl, Path.GetTempPath() + nomFichierCmd);
                
            }
        }

        public void RunScript(string nomFichierCmd, bool RunAdmin)
        {

            Process process = new Process();
            if(RunAdmin)
                process.StartInfo.Verb = "runas";
            else
                process.StartInfo.Verb = "runasuser";

            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = Path.GetTempPath() + nomFichierCmd;
            process.Start();
        }

        public void DeleteFiles(string nomFichier, string nomFichierCmd)
        {
            if(File.Exists(Path.GetTempPath() + nomFichier))
            {
                File.Delete(Path.GetTempPath() + nomFichier);
            }
            if(File.Exists(Path.GetTempPath() + nomFichierCmd))
            {
                File.Delete(Path.GetTempPath() + nomFichierCmd);
            }
        }
    }
}
