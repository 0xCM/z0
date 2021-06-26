//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    [SymbolSource]
    public enum AddressingModeKind : byte
    {
        [Symbol("m16b", "Specifies 16-bit addressing")]
        Mode16,

        [Symbol("m32b", "Specifies 32-bit addressing")]
        Mode32,

        [Symbol("m64b", "Specifies 64-bit addressing")]
        Mode64,
    }

    public readonly struct AddressingMode
    {
        public AddressingModeKind Kind {get;}

        [MethodImpl(Inline)]
        public AddressingMode(AddressingModeKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AddressingMode(AddressingModeKind src)
            => new AddressingMode(src);

        [MethodImpl(Inline)]
        public static implicit operator AddressingModeKind(AddressingMode src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator byte(AddressingMode src)
            => (byte)src.Kind;
    }
}