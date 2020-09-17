//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents an opcode identifier
    /// </summary>
    public readonly struct AsmOpCodePattern : ITextual
    {
        public readonly asci32 Value;

        [MethodImpl(Inline)]
        public static implicit operator string(AsmOpCodePattern src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodePattern(string src)
            => new AsmOpCodePattern(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(AsmOpCodePattern src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodePattern(asci32 src)
            => new AsmOpCodePattern(src);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmOpCodePattern d1, AsmOpCodePattern d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmOpCodePattern d1, AsmOpCodePattern d2)
            => !d1.Equals(d2);

        [MethodImpl(Inline)]
        public AsmOpCodePattern(string src)
        {
            Value = src.Replace("o32 ", EmptyString);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsEmpty;
        }

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

        public AsmOpCodePattern Zero
            => Empty;

        [MethodImpl(Inline)]
        public string Format()
            => asci.format(Value);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCodePattern src)
            => Value.Equals(src.Value);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is AsmOpCodePattern id && Equals(id);

        public static AsmOpCodePattern Empty
            => new AsmOpCodePattern(EmptyString);
    }
}