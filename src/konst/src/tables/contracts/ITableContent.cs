//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public interface ITableContent<T>
        where T : struct, ITable
    {
        ReadOnlySpan<T> View {get;}

        Span<T> Edit {get;}

        CellCount Count {get;}

        int Length {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableContent<F,T> : ITableContent<T>, ITableIndex<F,T,ulong>, ITableIndex<F,T,long>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableContent<F,T,D> : ITableContent<F,T>
        where F : unmanaged, Enum
        where D : unmanaged, Enum
        where T : struct, ITable<F,T,D>
    {


    }    
}