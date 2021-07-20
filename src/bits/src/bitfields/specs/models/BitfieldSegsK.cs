//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = BitfieldSpecs;

    public readonly struct BitfieldSegs<K>
        where K : unmanaged
    {
        readonly Index<BitfieldSeg<K>> Data;

        [MethodImpl(Inline)]
        public BitfieldSegs(BitfieldSeg<K>[] src)
        {
            Data = src;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref BitfieldSeg<K> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref BitfieldSeg<K> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
        public ref BitfieldSeg<K> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ReadOnlySpan<BitfieldSeg<K>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<BitfieldSeg<K>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => api.width(View);
        }

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSegs<K>(BitfieldSeg<K>[] src)
            => new BitfieldSegs<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSeg<K>[](BitfieldSegs<K> src)
            => src.Data.Storage;
    }
}