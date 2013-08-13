﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecLog.Commands;
using TechTalk.SpecLog.Common;
using TechTalk.SpecLog.Entities;
using TechTalk.SpecLog.Server.Services.PluginInfrastructure;

namespace SpecLog.HtmlExportPlugin.Server
{
    [Plugin(HtmlExportPlugin.PluginName)]
    public class HtmlExportPlugin : ServerPlugin
    {
        public const string PluginName = "SpecLog.HtmlExportPlugin";

        public override void OnStart()
        {
            Log(System.Diagnostics.TraceEventType.Information, "{0} started", PluginName);
        }

        public override void OnStop()
        {
            Log(System.Diagnostics.TraceEventType.Information, "{0} stopped", PluginName);
        }

        public override void PerformCommand(string commandVerb, string issuingUser)
        {
            // nop
        }

        public override IEnumerable<IPeriodicActivity> ActiveSynchronizers
        {
            get { return Enumerable.Empty<IPeriodicActivity>(); }
        }

        public override void AfterApplyCommand(RepositoryInfo repository, Command command)
        {
            // nop
        }

        public override void AfterUndoCommand(RepositoryInfo repository, Command command)
        {
            // nop
        }

        public override void BeforeApplyCommand(RepositoryInfo repository, Command command)
        {
            // nop
        }

        public override void BeforeUndoCommand(RepositoryInfo repository, Command command)
        {
            // nop
        }
    }
}
