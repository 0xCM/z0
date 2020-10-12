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
    public interface ITestLogger
    {
        FS.FilePath Write<R>(IEnumerable<R> data, FS.FolderName subdir, string basename, LogWriteMode mode, char delimiter, bool header, FS.FileExt ext)
            where R : ITabular;

        FS.FilePath Write<R>(IEnumerable<R> data, FS.FolderName subdir, string basename, FileWriteMode mode, char delimiter, bool header, FS.FileExt ext)
            where R : ITabular
                => Write(data,subdir, basename, mode == FileWriteMode.Append ? LogWriteMode.Create : LogWriteMode.Append, delimiter, header, ext);
    }
}