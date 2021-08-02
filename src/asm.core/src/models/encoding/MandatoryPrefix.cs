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

    public struct MandatoryPrefix : IAsmPrefix<MandatoryPrefixCode>
    {
        MandatoryPrefixCode _Code;

        [MethodImpl(Inline)]
        public MandatoryPrefix(MandatoryPrefixCode src)
        {
            _Code = src;
        }

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)_Code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => _Code == 0;
        }

        [MethodImpl(Inline)]
        public MandatoryPrefix Code()
            => _Code;

        [MethodImpl(Inline)]
        public void Code(MandatoryPrefixCode src)
            => _Code = src;

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => _Code != 0;
        }

        public override string ToString()
            => Format();

        public string Format()
            => Encoded.FormatHex();

        [MethodImpl(Inline)]
        public static implicit operator MandatoryPrefix(MandatoryPrefixCode src)
            => new MandatoryPrefix(src);

        [MethodImpl(Inline)]
        public static implicit operator MandatoryPrefixCode(MandatoryPrefix src)
            => src._Code;

        [MethodImpl(Inline)]
        public static implicit operator byte(MandatoryPrefix src)
            => (byte)src._Code;
    }
}