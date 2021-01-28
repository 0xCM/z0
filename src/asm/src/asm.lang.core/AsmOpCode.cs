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
    public readonly struct AsmOpCode : ITextual
    {
        public asci32 Value {get;}

        [MethodImpl(Inline)]
        public AsmOpCode(string src)
            => Value = src.Replace("o32 ", EmptyString);

        [MethodImpl(Inline)]
        public AsmOpCode(asci32 src)
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

        public AsmOpCode Zero
            => Empty;

        [MethodImpl(Inline)]
        public string Format()
            => Asci.format(Value);

        [MethodImpl(Inline)]
        public bool Equals(AsmOpCode src)
            => Value.Equals(src.Value);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object src)
            => src is AsmOpCode id && Equals(id);

        public static AsmOpCode Empty
            => new AsmOpCode(EmptyString);

        [MethodImpl(Inline)]
        public static implicit operator string(AsmOpCode src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCode(asci32 src)
            => new AsmOpCode(src);

        [MethodImpl(Inline)]
        public static implicit operator asci32(AsmOpCode src)
            => src.Value;

        [MethodImpl(Inline)]
        public static bool operator ==(AsmOpCode d1, AsmOpCode d2)
            => d1.Equals(d2);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmOpCode d1, AsmOpCode d2)
            => !d1.Equals(d2);
    }
}