//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface ITableIndex<T> : IDataIndex<T>
        where T : struct, ITable
    {

    }

    public interface ITableIndex<F,T> : ITableIndex<T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

    }    
}