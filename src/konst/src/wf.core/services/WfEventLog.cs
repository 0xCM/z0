//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    public struct WfEventLog : IWfEventLog
    {
        readonly FS.FilePath StatusPath;

        readonly FS.FilePath Error;

        readonly FS.FolderPath Target;

        readonly FileStream Status;

        public WfEventLog(WfLogConfig config)
        {
            Target = config.Publication;
            config.StatusLog.Delete();
            config.ErrorLog.Delete();
            StatusPath = FS.path(config.StatusLog.Name);
            Error = FS.path(config.ErrorLog.Name).CreateParentIfMissing();
            Status = StatusPath.Stream();
        }

        // public WfEventLog(FS.FilePath status, FS.FilePath error, FS.FolderPath target)
        // {
        //     Target = target;
        //     status.Delete();
        //     error.Delete();
        //     StatusPath = status;
        //     Status = StatusPath.Stream();
        //     Error = error.CreateParentIfMissing();
        // }

        public void Dispose()
        {
            Status?.Flush();
            Status?.Dispose();
            StatusPath.CopyTo(Target);
        }

        [MethodImpl(Inline)]
        void Display(IAppMsg src)
            => term.print(src);

        [MethodImpl(Inline)]
        void Display(IAppEvent src)
            => term.print(src);

        [MethodImpl(Inline)]
        static string format(ITextual src)
            => string.Concat(src.Format(), Eol);

        public void Deposit(IAppMsg e)
        {
            try
            {
                Display(e);

                if(e.IsError)
                    Error.AppendLine(e.Format());
                else
                    FS.write(format(e), Status);
            }
            catch(Exception error)
            {
                term.errlabel(error, "EventLogError");
            }
        }

        void Emit(IAppEvent e)
        {
            Display(e);

            try
            {
                if(e.IsError)
                    Error.AppendLine(e.Format());
                else
                    FS.write(format(e), Status);
            }
            catch(Exception error)
            {
                term.errlabel(error, "EventLogError");
            }
        }

        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => Emit(e);

        [MethodImpl(Inline)]
        public void Deposit(IWfEvent e)
            => Emit(e);
    }
}