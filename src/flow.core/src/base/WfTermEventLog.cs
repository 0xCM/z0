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
    
    public struct WfTermEventLog : IWfEventLog
    {        
        public static IWfEventLog create(FS.FilePath status, FS.FilePath error, bool clear = true)
            => new WfTermEventLog(FilePath.Define(status.Name), FilePath.Define(error.Name), clear);

        public static IWfEventLog create(WfConfig config, bool clear = true)
            => new WfTermEventLog(FilePath.Define(config.StatusPath.Name), FilePath.Define(config.ErrorPath.Name), clear);
            
        FilePath Status;

        readonly FilePath Error;
        
        StreamWriter StatusWriter; 
        
        static FilePath path(FilePath status)
        {
            var ext = FileExtension.Define(text.format("{0}{1}", Timestamp.create(), status.Ext.Name));
            var name = FileName.Define(Path.GetFileNameWithoutExtension(status.Name), ext);
            return status.FolderPath + name;
        }
        
        WfTermEventLog(FilePath status, FilePath error, bool clear)
        {  
            if(clear)       
            {
                status.FolderPath.Files(text.format("{0}.*", status.FileName.Name.LeftOf('.'))).Iter(f => f.Delete());
                error.Delete();
            }
            
            Status =  path(status);
            StatusWriter = Status.Writer();
            Error = error.CreateParentIfMissing();
        }
        
        public void Deposit(IAppMsg e)
        {
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

        public void Deposit(IAppEvent e)
        {
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
            StatusWriter.WriteLine(e.Format());
        }
        
        public void Dispose()
        {
            StatusWriter?.Flush();
            StatusWriter?.Dispose();
        }
    }
}