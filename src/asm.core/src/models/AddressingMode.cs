//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AddressingMode
    {
        [SymSource]
        public enum Kind : byte
        {
            [Symbol("m16b", "Specifies 16-bit addressing")]
            Mode16,

            [Symbol("m32b", "Specifies 32-bit addressing")]
            Mode32,

            [Symbol("m64b", "Specifies 64-bit addressing")]
            Mode64,
        }

        public Kind Value {get;}

        [MethodImpl(Inline)]
        public AddressingMode(Kind kind)
        {
            Value = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AddressingMode(Kind src)
            => new AddressingMode(src);

        [MethodImpl(Inline)]
        public static implicit operator Kind(AddressingMode src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(AddressingMode src)
            => (byte)src.Value;
    }
}