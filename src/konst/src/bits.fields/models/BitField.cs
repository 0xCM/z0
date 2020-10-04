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

        readonly BitFieldModel Spec;

        public BitField(BitFieldModel spec)
        {
            Spec = spec;
            Data = default;
        }

        public Span<byte> Segment(uint index)
        {
            return default;
        }

        public readonly uint FieldCount
        {
            [MethodImpl(Inline)]
            get => Spec.FieldCount;
        }
    }
}