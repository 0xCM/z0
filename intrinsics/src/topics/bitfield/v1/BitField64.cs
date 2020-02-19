//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly ref struct BitFieldRef64
    {
        readonly ulong data;

        public readonly int FieldCount;

        readonly BitFieldSpecV1 spec;

        [MethodImpl(Inline)]
        public BitFieldRef64(ulong data, Span<BitFieldSegment> segments)
        {
            this.data = data;
            this.spec = new BitFieldSpecV1(segments);
            this.FieldCount = segments.Length;
        }

        [MethodImpl(Inline)]
        public BitFieldRef64(ulong data, BitFieldSpecV1 spec)
        {
            this.data = data;
            this.spec = spec;
            this.FieldCount = spec.FieldCount;
        }

        public ulong this[byte index]
        {
            [MethodImpl(Inline)]
            get => SegValue(index);
        }

        [MethodImpl(Inline)]
        public uint SegWidth(byte index)
            => spec[index].Width;

        [MethodImpl(Inline)]
        public ulong SegValue(byte index)
        {
            var field = spec[index];
            return Bits.bitslice(data, (byte)field.StartPos, (byte)field.Width);            
        }        
    }
}
