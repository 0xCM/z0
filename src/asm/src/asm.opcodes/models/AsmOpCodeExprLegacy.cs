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
    public readonly struct AsmOpCodeExprLegacy : ITextual
    {
        public asci32 Value {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeExprLegacy(string src)
            => Value = src.Replace("o32 ", EmptyString);

        [MethodImpl(Inline)]
        public AsmOpCodeExprLegacy(asci32 src)
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

        public AsmOpCodeExprLegacy Zero
            => Empty;

        [MethodImpl(Inline)]
        public string Format()
            => Asci.format(Value);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodeExprLegacy src)
            => Value.Equals(src.Value);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is AsmOpCodeExprLegacy id && Equals(id);

        public static AsmOpCodeExprLegacy Empty
            => new AsmOpCodeExprLegacy(EmptyString);

        [MethodImpl(Inline)]
        public static implicit operator string(AsmOpCodeExprLegacy src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeExprLegacy(asci32 src)
            => new AsmOpCodeExprLegacy(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(AsmOpCodeExprLegacy src)
            => src.Value;

        [MethodImpl(Inline)]
        public static bool operator ==(AsmOpCodeExprLegacy d1, AsmOpCodeExprLegacy d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmOpCodeExprLegacy d1, AsmOpCodeExprLegacy d2)
            => !d1.Equals(d2);
    }
}