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
        FilePath Status;

        readonly FilePath Error;

        StreamWriter StatusWriter;

        public WfEventLog(FilePath status, FilePath error, bool clear)
        {
            if(clear)
            {
                status.FolderPath.Clear();
                error.Delete();
            }

            Status = status;
            StatusWriter = Status.Writer();
            Error = error.CreateParentIfMissing();
        }

        void Display(IAppMsg src)
            => term.print(src);

        void Display(IAppEvent src)
            => term.print(src);

        public void Deposit(IAppMsg e)
        {
            try
            {
                Display(e);

                if(e.IsError)
                {
                    Error.AppendLine(e.Format());
                }
                else
                {
                    StatusWriter.WriteLine(e.Format());
                }
            }
            catch(Exception error)
            {
                term.error(error);
            }
        }

        public void Deposit(IAppEvent e)
        {
            Display(e);

            try
            {
                if(e.IsError)
                {
                    Error.AppendLine(e.Format());
                }
                else
                {
                    StatusWriter.WriteLine(e.Format());
                }
            }
            catch(Exception error)
            {

                term.error(error);
            }
        }

        public void Dispose()
        {
            StatusWriter?.Flush();
            StatusWriter?.Dispose();
        }

        public void Deposit(IWfEvent e)
        {
            Display(e);

            try
            {
                if(e.IsError)
                {
                    Error.AppendLine(e.Format());
                }
                else
                {
                    StatusWriter.WriteLine(e.Format());
                }
            }
            catch(Exception error)
            {
                term.error(error);
            }
        }
    }
}