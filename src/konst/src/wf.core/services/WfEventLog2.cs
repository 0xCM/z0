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

    public struct WfEventLog2 : IWfEventLog
    {
        readonly FS.FilePath StatusPath;

        readonly FS.FilePath Error;

        readonly FileStream Status;

        public WfEventLog2(FS.FilePath status, FS.FilePath error, bool clear)
        {
            if(clear)
            {
                status.FolderPath.Clear();
                error.Delete();
            }

            StatusPath = status;
            Status = FS.stream(StatusPath);
            Error = error.CreateParentIfMissing();
        }

        public void Dispose()
        {
            Status?.Flush();
            Status?.Dispose();
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
                term.error(error);
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

                term.error(error);
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