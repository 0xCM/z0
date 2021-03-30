//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct RegCode
    {
        public uint5 Value {get;}

        public byte Width {get;}

        [MethodImpl(Inline)]
        internal RegCode(uint5 value, byte width)
        {
            Value = value;
            Width = width;
        }

        public ReadOnlySpan<bit> Bits
        {
            [MethodImpl(Inline)]
            get => slice(Value.Bits, 0, Width);
        }

        public string Format()
        {
            Span<char> dst = stackalloc char[Width];
            var src = Bits;
            for(var i=0; i<Width; i++)
                seek(dst,i) = skip(src,i).ToChar();
            return text.format(dst);
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RegCode(uint2 src)
            => new RegCode(src,2);

        [MethodImpl(Inline)]
        public static implicit operator RegCode(uint3 src)
            => new RegCode(src,3);

        [MethodImpl(Inline)]
        public static implicit operator RegCode(uint4 src)
            => new RegCode(src,4);

        [MethodImpl(Inline)]
        public static implicit operator RegCode(uint5 src)
            => new RegCode(src,5);
    }
}