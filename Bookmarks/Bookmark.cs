﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Bookmarks
{

    class BookMark
    {

        public string Naam { get; set; }
        public string URL { get; set; }
        public void OpenSite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);  //Voeg bovenaan using System.Diagnostics; toe

        }
    }
}
