//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    [ApiHost("client")]
    public readonly struct BitFieldClient : IApiHost<BitFieldClient>, IBitFieldClient
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly FieldSegment Segment<T>(in BitField<T> field, int index)
            where T : unmanaged
                => ref field.Segment(index);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public T Extract<T>(in BitField<T> field, in FieldSegment seg, T src)
            where T : unmanaged
                => field.Extract(seg, src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public T Extract<T>(in BitField<T> field,in FieldSegment seg, T src, bool offset)
            where T : unmanaged
                => field.Extract(seg, src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public void Deposit<T>(in BitField<T> field, T src, Span<T> dst)
            where T : unmanaged
                => field.Deposit(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref T Deposit<T>(in BitField<T> field, in FieldSegment seg, in T src, ref T dst) 
            where T : unmanaged
                => ref field.Deposit(seg, src, ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref T Deposit<T>(in BitField<T> field, ReadOnlySpan<T> src, ref T dst)
            where T : unmanaged
                => ref field.Deposit(src, ref dst);        
    }
}