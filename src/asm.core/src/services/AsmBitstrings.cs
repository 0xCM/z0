//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmBitstrings
    {
        public static AsmBitstrings service()
            => new AsmBitstrings(_Formatter);

        readonly BitFormatter<byte> Formatter;

        [MethodImpl(Inline)]
        AsmBitstrings(BitFormatter<byte> formatter)
        {
            Formatter = formatter;
        }

        public string Format(AsmHexCode src)
        {
            var bytes = src.Bytes.Replicate();
            bytes.Reverse();
            return Formatter.Format(bytes);
        }

        static AsmBitstrings()
        {
            _Formatter = BitFormatter.create<byte>(BitFormatter.blocked(4));
        }

        [FixedAddressValueType]
        static BitFormatter<byte> _Formatter;
    }
}