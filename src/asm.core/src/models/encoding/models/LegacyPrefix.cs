//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmPrefixCodes;

    public struct LegacyPrefix : IAsmPrefix<LegacyPrefixCode>
    {
        LegacyPrefixCode _Code;

        [MethodImpl(Inline)]
        public LegacyPrefix(LegacyPrefixCode code)
            => _Code = code;

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)_Code;
        }

        [MethodImpl(Inline)]
        public LegacyPrefixCode Code()
            => _Code;

        [MethodImpl(Inline)]
        public void Code(LegacyPrefixCode src)
            => _Code = src;

        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefix(LegacyPrefixCode src)
            => new LegacyPrefix(src);

        [MethodImpl(Inline)]
        public static implicit operator LegacyPrefixCode(LegacyPrefix src)
            => src._Code;

        [MethodImpl(Inline)]
        public static implicit operator byte(LegacyPrefix src)
            => (byte)src._Code;
    }
}