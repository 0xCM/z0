//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly ref struct BitField64
    {
        readonly ulong data;

        readonly BitFieldSpec spec;

        [MethodImpl(Inline)]
        public BitField64(ulong data, Span<BitSegment> segments)
        {
            this.data = data;
            this.spec = new BitFieldSpec(segments);
        }

        [MethodImpl(Inline)]
        public BitField64(ulong data, BitFieldSpec spec)
        {
            this.data = data;
            this.spec = spec;
        }

        public ulong this[int index]
        {
            [MethodImpl(Inline)]
            get => Extract(index);
        }

        [MethodImpl(Inline)]
        public ulong Extract(int index)
        {
            var field = spec[index];
            return Bits.extract(data, field.FirstPos, field.Width);            
        }
        
        public BitFieldSpec Spec
        {
            [MethodImpl(Inline)]
            get => spec;
        }
    }
}
