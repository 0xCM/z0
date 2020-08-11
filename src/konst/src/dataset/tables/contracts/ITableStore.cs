//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    
    using static Konst;

    public interface ITableStore<F,R>
        where F : unmanaged, Enum
        where R : ITable         
    {
        Option<FilePath> Save(R[] src, FilePath dst, FileWriteMode mode = Overwrite);
    }
}