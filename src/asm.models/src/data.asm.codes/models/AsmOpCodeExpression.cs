//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmOpCodeExpression
    {
        public readonly asci32 Value;

        [MethodImpl(Inline)]
        public AsmOpCodeExpression(asci32 src)
            => Value = src;

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => asci.bytes(Value);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Value);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExpression src)
            => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is AsmOpCodeExpression x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        public static AsmOpCodeExpression Empty
            => new AsmOpCodeExpression(asci32.Null);
    }
}