//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly ref struct BitFieldSpec
    {
        readonly Span<BitSegment> Fields;


        [MethodImpl(Inline)]
        public BitFieldSpec(BitSegment[] fields)
        {
            this.Fields = fields;
        }

        [MethodImpl(Inline)]
        public BitFieldSpec(Span<BitSegment> fields)
        {
            this.Fields = fields;
        }

        public BitSegment this[int i]
        {
            [MethodImpl(Inline)]
            get => skip<BitSegment>(Fields,i);
        }

        public int FieldCount
        {
            [MethodImpl(Inline)]
            get => Fields.Length;
        }

        public string Format()
        {
            var fmt = text();
            for(var i=0; i< FieldCount; i++)
            {
                var f = this[i];
                var index = i.ToString();
                var width = f.Width.ToString().PadLeft(2,AsciDigits.A0);

                fmt.Append($"{index}:{f.FirstPos}..{f.LastPos}");
                if(i != FieldCount - 1)
                {
                    fmt.Append(AsciSym.Comma);
                    fmt.Append(AsciSym.Space);
                }
            }
            return bracket(fmt.ToString());
        }

    }

}
