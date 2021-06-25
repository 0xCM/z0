//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmCodes;

    public readonly struct BndPrefix : IAsmPrefix<BndPrefix>
    {
        public BndPrefixCode Code {get;}

        [MethodImpl(Inline)]
        public BndPrefix(BndPrefixCode src)
        {
            Code = src;
        }

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)Code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Code != 0;
        }

        public override string ToString()
            => Format();

        public string Format()
            => Encoded.FormatHex();

        [MethodImpl(Inline)]
        public static implicit operator BndPrefix(BndPrefixCode src)
            => new BndPrefix(src);
    }
}