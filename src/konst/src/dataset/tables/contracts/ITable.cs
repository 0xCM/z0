//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public interface ITable : ITextual
    {
        string ITextual.Format()
            => "Unformatted";
    }
    
    public interface ITable<F> : ITable
        where F : unmanaged, Enum
    {

    }

    public interface ITable<F,T> : ITable<F>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

    }    
}