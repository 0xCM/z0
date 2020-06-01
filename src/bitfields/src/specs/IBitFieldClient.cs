//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFieldClient : IService
    {
        ref readonly FieldSegment Segment<T>(in BitField<T> field, int index)
            where T : unmanaged;        

        T Extract<T>(in BitField<T> field, in FieldSegment seg, T src)
            where T : unmanaged;

        T Extract<T>(in BitField<T> field, in FieldSegment seg, T src, bool offset)
            where T : unmanaged;

        ref T Deposit<T>(in BitField<T> field, in FieldSegment seg, in T src, ref T dst)
            where T : unmanaged;

        ref T Deposit<T>(in BitField<T> field, ReadOnlySpan<T> src, ref T dst)
            where T : unmanaged;
    }
}