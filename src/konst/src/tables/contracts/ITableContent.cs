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

        Count Count {get;}

        int Length {get;}
    }
}