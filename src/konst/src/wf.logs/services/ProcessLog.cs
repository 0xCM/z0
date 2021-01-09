//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    struct ProcessLog : IProcessLog
    {
        readonly FS.FilePath StatusPath;

        readonly FS.FilePath Error;

        readonly FileStream Status;

        internal ProcessLog(WfLogConfig config)
        {
            config.StatusLog.Delete();
            config.ErrorLog.Delete();
            StatusPath = FS.path(config.StatusLog.Name);
            Error = FS.path(config.ErrorLog.Name).EnsureParentExists();
            Status = StatusPath.Stream();
        }

        public void Dispose()
        {
            Status?.Flush();
            Status?.Dispose();
        }

        public void LogStatus(string content)
        {
            try
            {
                FS.write(content + Eol, Status);
            }
            catch(Exception error)
            {
                term.errlabel(error, "EventLogError");
            }
        }

        public void LogError(string content)
        {
            try
            {
                Error.AppendLine(content);
                FS.write("[error] ", Status);
                FS.write(RP.PageBreak40 + Eol, Status);
                FS.write(content + Eol, Status);
            }
            catch(Exception error)
            {
                term.errlabel(error, "EventLogError");
            }
        }
    }
}