//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeExpr : ITextual
    {
        public readonly asci32 Value;

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(asci32 src)
            => Value = src;

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Asci.bytes(Value);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => Asci.decode(Value);
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
        public bool Equals(AsmOpCodeExpr src)
            => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is AsmOpCodeExpr x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        public static AsmOpCodeExpr Empty
            => new AsmOpCodeExpr(asci32.Null);
    }
}