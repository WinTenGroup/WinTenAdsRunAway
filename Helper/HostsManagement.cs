﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AdsRunAway.Model;

namespace AdsRunAway.Helper
{
    class HostsManagement
    {
        public static void Merge(string path1, string path2)
        {

        }

        public static bool IsFileInUse(FileInfo file)
        {
            bool Used = false;
            FileStream fs = null;
            try
            {
                fs = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch
            {
                Used = true;
            }
            fs.Dispose();
            return Used;
        }
        public static void Create()
        {
            try
            {
                if (File.Exists(PathInfo.Hosts) == false)
                {
                    File.Create(PathInfo.Hosts).Close();
                }
            }catch(Exception ex)
            {

            }
        }
        public static void Restore()
        {
            
           
            string DefaultHosts = @"# Copyright (c) 1993-2006 Microsoft Corp.
#
# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.
#
# This file contains the mappings of IP addresses to host names. Each
# entry should be kept on an individual line. The IP address should
# be placed in the first column followed by the corresponding host name.
# The IP address and the host name should be separated by at least one
# space.
#
# Additionally, comments (such as these) may be inserted on individual
# lines or following the machine name denoted by a '#' symbol.
#
# For example:
#
#      102.54.94.97     rhino.acme.com          # source server
#       38.25.63.10     x.acme.com              # x client host
# localhost name resolution is handle within DNS itself.
#       127.0.0.1       localhost
#       ::1             localhost ";

            if (File.Exists(PathInfo.Hosts) == true)
            {
                File.Delete(PathInfo.Hosts);
            }

            File.Create(PathInfo.Hosts).Close();
            File.WriteAllText(PathInfo.Hosts, DefaultHosts);
        }
        public static void Backup(string backupLocation)
        {

        }
        public static void SetPermission(Permission permission)
        {

        }
    }
}