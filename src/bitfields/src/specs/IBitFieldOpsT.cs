//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBitFieldOps<T> : IService
        where T : unmanaged
    {
        T Extract(in FieldSegment seg, T src);

        T Extract(in FieldSegment seg, T src, bool offset);

        ref T Deposit(in FieldSegment seg, in T src, ref T dst);  

        void Deposit(in BitFieldSpec spec, T src, Span<T> dst);

        ref T Deposit(in BitFieldSpec spec, ReadOnlySpan<T> src, ref T dst);

        void Deposit<E,W>(in BitFieldSpec<E,W> spec, T src, Span<T> dst)
            where E : unmanaged, Enum
            where W : unmanaged, Enum;
    }
}