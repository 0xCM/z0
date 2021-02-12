//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly ref struct Segments<C,T>
        where C : struct, IDataCell
        where T : unmanaged
     {
        public static uint SegWidth
            => width<C>();

        public static uint CellWidth
            => width<T>();

        readonly Span<C> Data;

        [MethodImpl(Inline)]
        public Segments(Span<C> src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref C Seek(long seg)
            => ref seek(Data, (uint)seg);

        [MethodImpl(Inline)]
        public ref C Seek(ulong seg)
            => ref seek(Data, seg);

        [MethodImpl(Inline)]
        public ref T Seek(long seg, long cell)
            => ref @as<C,T>(seek(seek(Data, (uint)seg), (ulong)cell));

        [MethodImpl(Inline)]
        public ref T Seek(ulong seg, ulong cell)
            => ref @as<C,T>(seek(seek(Data, seg), cell));

        public ref C this[long item]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, (uint)item);
        }

        public ref T this[long seg, long cell]
        {
            [MethodImpl(Inline)]
            get => ref Seek(seg,cell);
        }

        public Span<C> SegEdit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<C> SegView
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint SegCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public uint DataWidth
        {
            [MethodImpl(Inline)]
            get => SegCount * SegWidth;
        }

        public Span<T> CellEdit
        {
            [MethodImpl(Inline)]
            get => recover<C,T>(Data);
        }

        public ReadOnlySpan<T> CellView
        {
            [MethodImpl(Inline)]
            get => recover<C,T>(Data);
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => DataWidth / CellWidth;
        }
    }
}