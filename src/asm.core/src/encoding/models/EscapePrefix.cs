//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    public readonly struct EscapePrefix : IAsmPrefix<EscapePrefix>
    {
        public EscapeCode Code {get;}

        [MethodImpl(Inline)]
        public EscapePrefix(EscapeCode code)
            => Code = code;

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)Code;
        }

        [MethodImpl(Inline)]
        public static implicit operator EscapePrefix(EscapeCode src)
            => new EscapePrefix(src);

        [MethodImpl(Inline)]
        public static implicit operator EscapeCode(EscapePrefix src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator byte(EscapePrefix src)
            => (byte)src.Code;
    }
}