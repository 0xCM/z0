//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public enum LogArea
    {
        Test,

        Bench,

        App,
    }

    public enum LogWriteMode
    {
        Create,
        
        Overwrite,
        
        Append
    }

    public interface ILogTarget
    {
        LogArea Area {get;}

        string Name {get;}
    }
    
    /// <summary>
    /// Defines minimal contract for a log message sink
    /// </summary>
    public interface ILogger
    {
        void Log(IEnumerable<AppMsg> src);
        
        void Log(AppMsg src);

        FilePath Log<R>(IEnumerable<R> records, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header, FileExtension ext)
            where R : IRecord;            
                
    }


}