//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using W = W8;

    /// <summary>
    /// Describes an 8-bit immediate that is potentially refined
    /// </summary>
    public readonly struct Imm8R : IImm<Imm8R,byte>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public Imm8R(byte value)
            => Content = value;

        public ImmWidthCode Width => ImmWidthCode.W8;

        public ImmKind Kind => ImmKind.Imm8;

        public string Format()
            => HexFormat.format(Content, W, true);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8R imm8)
            => imm8.Content;

       public static W W => default;
    }
}