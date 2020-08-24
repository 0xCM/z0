//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial struct Flow
    {
        public static IWfEventLog log(FS.FilePath status, FS.FilePath error, bool clear = true)
            => new WfTermEventLog(FilePath.Define(status.Name), FilePath.Define(error.Name), clear);

        public static void format(in WfError<Exception> error, StringBuilder dst)
        {
            const string ErrorTrace = "{0} | {1} | {2} | Outer | {3} | {4} | {5}";
            const string InnerTrace = "{0} | {1} | {2} | Inner | {3} | {4} | {5} | {6}";

            var exception = error.Data;
            var eType = exception.GetType();
            var outer = string.Format(ErrorTrace, error.EventId, error.Actor, error.Source, eType.Name, exception.Message, exception.StackTrace);
            dst.AppendLine(outer);

            int level = 0;

            var e = exception.InnerException;
            while (e != null)
            {
                dst.AppendLine(string.Format(InnerTrace, error.EventId, error.Actor, error.Source, level, eType.Name, e.Message, e.StackTrace));
                e = e.InnerException;
                level += 1;
            }
        }

        public static IWfEventLog log(WfConfig config, bool clear = true)
            => new WfTermEventLog(FilePath.Define(config.StatusLog.Name), FilePath.Define(config.ErrorLog.Name), clear);
    }
}