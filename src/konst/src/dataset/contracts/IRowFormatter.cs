//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public interface IRowFormatter<F,T>
        where F : unmanaged, Enum        
    {
        T Format<S>(S src)
            where S : ITable;
    }

    public interface IRowFormatter<F> : IRowFormatter<F,string>
        where F : unmanaged, Enum
    {

    }    
}