//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BinaryDigit
    {
        const string D0 = "0";

        const string D1 = "1";

        public BinaryDigitCode Code {get;}

        [MethodImpl(Inline)]
        public BinaryDigit(BinaryDigitCode code)
        {
            Code = code;
        }

        [MethodImpl(Inline)]
        public BinaryDigit(BinaryDigitSym src)
        {
            Code = (BinaryDigitCode)src;
        }

        [MethodImpl(Inline)]
        public BinaryDigit(bit src)
        {
            Code = (BinaryDigitCode)src.ToChar();
        }

        public BinaryDigitSym Symbol
        {
            [MethodImpl(Inline)]
            get => (BinaryDigitSym)Code;
        }

        public char Char
        {
            [MethodImpl(Inline)]
            get => (char)Code;
        }

        public bit Bit
        {
            [MethodImpl(Inline)]
            get => Code == BinaryDigitCode.b1;
        }

        [MethodImpl(Inline)]
        public BinaryDigit Inc()
            => Bit ? new BinaryDigit(bit.Off) : new BinaryDigit(bit.On);

        [MethodImpl(Inline)]
        public BinaryDigit Dec()
            => Bit ? new BinaryDigit(bit.Off) : new BinaryDigit(bit.On);

        [MethodImpl(Inline)]
        public BinaryDigit Not()
            => !Bit;

        [MethodImpl(Inline)]
        public string Format()
            => Code == BinaryDigitCode.b1 ? D1 : D0;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(BinaryDigitCode src)
            => new BinaryDigit(src);

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(BinaryDigitSym src)
            => new BinaryDigit(src);

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigitCode(BinaryDigit src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator BinaryDigit(bit src)
            => new BinaryDigit(src);

        [MethodImpl(Inline)]
        public static implicit operator bit(BinaryDigit src)
            => src.Bit;

        [MethodImpl(Inline)]
        public static implicit operator char(BinaryDigit src)
            => src.Char;
    }
}