//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct BitField
    {
        readonly Span<byte> Data;

        readonly ReadOnlySpan<BitFieldSegment> Specs;

        public BitField(BitFieldModel spec)
        {
            Specs = spec.Segments;
            Data = default;
        }

        public Span<byte> Seg(uint index)
        {
            ref readonly var spec = ref skip(Specs,index);

            return default;
        }

        public readonly uint SegCount
        {
            [MethodImpl(Inline)]
            get => (uint)Specs.Length;
        }
    }
}