//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = BitfieldSpecs;

    public readonly struct BitfieldSegs
    {
        readonly Index<BitfieldSeg> Data;

        [MethodImpl(Inline)]
        public BitfieldSegs(BitfieldSeg[] src)
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

        public ref BitfieldSeg this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref BitfieldSeg this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
        public ref BitfieldSeg First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ReadOnlySpan<BitfieldSeg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<BitfieldSeg> Edit
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
        public uint Render(ref uint offset, Span<char> dst, SegRenderStyle style = default)
            => api.render(this, ref offset, dst, style);

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSegs(BitfieldSeg[] src)
            => new BitfieldSegs(src);

        [MethodImpl(Inline)]
        public static implicit operator BitfieldSeg[](BitfieldSegs src)
            => src.Data.Storage;
    }
}