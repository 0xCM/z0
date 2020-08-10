//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public interface ITableRows : ITextual
    {
        string ITextual.Format()
            => "Unformatted";
    }

    public interface ITableRows<F> : ITableRows
        where F : unmanaged, Enum
    {

    }

    public interface ITableRows<F,T> : ITableRows<F>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        T[] Data {get;}
    }    
}