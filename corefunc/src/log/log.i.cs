//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public enum LogArea
    {
        Test,

        Bench,

        App,

        Data,
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
    public interface ILogger : IAppMsgLog
    {
        /// <summary>
        /// Appends unstructured text content to the log
        /// </summary>
        /// <param name="text">The text to append</param>
        void Write(string text);

        FilePath Write<R>(IEnumerable<R> records, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header, FileExtension ext)
            where R : IRecord;                
    }
}