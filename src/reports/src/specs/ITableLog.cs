//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableLog<R>
        where R : ITabular         
    {
        Option<FilePath> Save(R[] src, TabularFormat format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite);
    }
    
    public interface ITableLog<F,R> : ITableLog<R>
        where F : unmanaged, Enum
        where R : ITabular         
    {
        Option<FilePath> Save(R[] src, TabularFormat<F> format, FilePath dst, FileWriteMode mode = FileWriteMode.Overwrite);

        Option<FilePath> ITableLog<R>.Save(R[] src, TabularFormat format, FilePath dst, FileWriteMode mode)
            => Save(src, format, dst, mode);

        /// <summary>
        /// Saves tabular data using derived metadata for format configuration 
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target file</param>
        /// <typeparam name="R">The source type</typeparam>
        Option<FilePath> Save(R[] src, FilePath dst);
    }
}