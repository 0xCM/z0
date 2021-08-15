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
        public AddressingKind Value {get;}

        [MethodImpl(Inline)]
        public AddressingMode(AddressingKind kind)
        {
            Value = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AddressingMode(AddressingKind src)
            => new AddressingMode(src);

        [MethodImpl(Inline)]
        public static implicit operator AddressingKind(AddressingMode src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator byte(AddressingMode src)
            => (byte)src.Value;
    }
}