//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    public readonly ref struct BitFieldSpecV1
    {
        readonly Span<FieldSegment> Fields;

        [MethodImpl(Inline)]
        public BitFieldSpecV1(FieldSegment[] fields)
        {
            this.Fields = fields;
        }

        [MethodImpl(Inline)]
        public BitFieldSpecV1(Span<FieldSegment> fields)
        {
            this.Fields = fields;
        }

        public FieldSegment this[int i]
        {
            [MethodImpl(Inline)]
            get => refs.skip<FieldSegment>(Fields,i);
        }

        public int FieldCount
        {
            [MethodImpl(Inline)]
            get => Fields.Length;
        }

        public string Format()
        {
            var fmt = text.build();
            for(var i=0; i< FieldCount; i++)
            {
                var f = this[i];
                var index = i.ToString();
                var width = f.Width.ToString().PadLeft(2,Chars.D0);

                fmt.Append($"{index}:{f.StartPos}..{f.EndPos}");
                if(i != FieldCount - 1)
                {
                    fmt.Append(Chars.Comma);
                    fmt.Append(Chars.Space);
                }
            }
            return text.bracket(fmt.ToString());
        }
    }
}
