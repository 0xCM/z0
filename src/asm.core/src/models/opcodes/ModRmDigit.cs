//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpCodes;

    /// <summary>
    /// Represents a register digit 0..7 that occurs within an op code expression
    /// </summary>
    public struct ModRmDigit
    {
        public ModRmDigitToken _Code;

        [MethodImpl(Inline)]
        public ModRmDigit(ModRmDigitToken code)
            => _Code = code;

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => (byte)_Code;
        }

        public ModRmDigitToken Code()
            => _Code;

        public void Code(ModRmDigitToken code)
            => _Code = code;

        [MethodImpl(Inline)]
        public static implicit operator ModRmDigit(byte src)
            => new ModRmDigit((ModRmDigitToken)src);

        [MethodImpl(Inline)]
        public static implicit operator ModRmDigit(ModRmDigitToken src)
            => new ModRmDigit(src);

        [MethodImpl(Inline)]
        public static explicit operator byte(ModRmDigit src)
            => src.Encoded;
    }
}