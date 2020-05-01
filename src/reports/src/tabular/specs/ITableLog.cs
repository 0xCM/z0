//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableLog : IService
    {
        Option<FilePath> Save<R>(R[] src, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : ITabular;                

        /// <summary>
        /// Saves tabular data using derived metadata for format configuration 
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target file</param>
        /// <param name="mode">The file creation mode</param>
        /// <typeparam name="R">The source type</typeparam>
        Option<FilePath> Save<R>(R[] src, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite)
            where R : ITabular;
    }
}