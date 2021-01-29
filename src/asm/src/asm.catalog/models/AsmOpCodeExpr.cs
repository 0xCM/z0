//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an opcode identifier
    /// </summary>
    public readonly struct AsmOpCodeExpr : ITextual
    {
        public asci32 Value {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(string src)
            => Value = src.Replace("o32 ", EmptyString);

        [MethodImpl(Inline)]
        public AsmOpCodeExpr(asci32 src)
            => Value = src.Replace("o32 ", EmptyString);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsEmpty;
        }

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

        public AsmOpCodeExpr Zero
            => Empty;

        [MethodImpl(Inline)]
        public string Format()
            => Asci.format(Value);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExpr src)
            => Value.Equals(src.Value);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is AsmOpCodeExpr id && Equals(id);

        public static AsmOpCodeExpr Empty
            => new AsmOpCodeExpr(EmptyString);

        [MethodImpl(Inline)]
        public static implicit operator string(AsmOpCodeExpr src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeExpr(asci32 src)
            => new AsmOpCodeExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(AsmOpCodeExpr src)
            => src.Value;

        [MethodImpl(Inline)]
        public static bool operator ==(AsmOpCodeExpr d1, AsmOpCodeExpr d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmOpCodeExpr d1, AsmOpCodeExpr d2)
            => !d1.Equals(d2);
    }
}