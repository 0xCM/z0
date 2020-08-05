//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    
    using static Konst;

    public interface ITableStore<R>
        where R : ITabular         
    {
        Option<FilePath> Save(R[] src, TabularFormat format, FilePath dst, FileWriteMode mode = Overwrite);
    }
    
    public interface ITableStore<F,R> : ITableStore<R>
        where F : unmanaged, Enum
        where R : ITabular         
    {
        Option<FilePath> Save(R[] src, TabularFormat<F> format, FilePath dst, FileWriteMode mode = Overwrite);

        Option<FilePath> ITableStore<R>.Save(R[] src, TabularFormat format, FilePath dst, FileWriteMode mode)
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