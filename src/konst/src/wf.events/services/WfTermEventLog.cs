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

    public struct WfTermEventLog : IWfEventLog
    {
        FilePath Status;

        readonly FilePath Error;

        StreamWriter StatusWriter;

        static FilePath path(FilePath status)
        {
            var ext = FileExtension.Define(text.format("{0}{1}", timestamp(), status.Ext.Name));
            var name = FileName.define(Path.GetFileNameWithoutExtension(status.Name), ext);
            return status.FolderPath + name;
        }

        public WfTermEventLog(FilePath status, FilePath error, bool clear)
        {
            if(clear)
            {
                status.FolderPath.Clear();
                error.Delete();
            }

            Status =  path(status);
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

        [MethodImpl(Inline)]
        public void Deposit(in WfTermEvent e)
        {
            Display(e);

            StatusWriter.WriteLine(e.Format());
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