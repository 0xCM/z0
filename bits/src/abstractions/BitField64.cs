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

        readonly BitFieldSpec Spec;

        [MethodImpl(Inline)]
        public BitField64(ulong data, Span<SegmentSpec> fields)
        {
            this.data = data;
            this.Spec = new BitFieldSpec(fields);
        }

        [MethodImpl(Inline)]
        public BitField64(ulong data, BitFieldSpec fields)
        {
            this.data = data;
            this.Spec = fields;
        }

        public ulong this[int field]
        {
            [MethodImpl(Inline)]
            get => Extract(field);
        }

        [MethodImpl(Inline)]
        public ulong Extract(int field)
        {
            var spec = Field(field);
            return Bits.extract(data, spec.FirstPos, spec.Width);            
        }
        
        public string Format()
        {
            var fmt = text();
            for(var i = FieldCount - 1; i>= 0; i--)
            {
                var spec = Field(i);
                fmt.Append(this[i].FormatBits(spec.Width));
                if(i != 0)
                    fmt.Append(AsciSym.Underscore);
            }
            return fmt.ToString();
        }

        int FieldCount
        {
            [MethodImpl(Inline)]
            get => Spec.FieldCount;
        }


        [MethodImpl(Inline)]
        SegmentSpec Field(int index)
            => Spec[index];

    }
}
