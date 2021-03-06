﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecLog.HtmlExportPlugin.Client
{
    [Serializable]
    public class HtmlExportPluginConfiguration
    {
        public HtmlExportPluginConfiguration()
        {
            GenerationIntervalMinutes = 5;
        }

        public string OutputPath { get; set; }

        public int GenerationIntervalMinutes { get; set; }
    }
}
