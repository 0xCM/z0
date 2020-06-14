//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public enum LogWriteMode
    {
        Create,
        
        Overwrite,
        
        Append
    }

    /// <summary>
    /// Defines minimal contract for a log message sink
    /// </summary>
    public interface ITestLogger : IService
    {        
        FilePath Write<R>(IEnumerable<R> data, FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header, FileExtension ext)
            where R : ITabular;                
    }
}