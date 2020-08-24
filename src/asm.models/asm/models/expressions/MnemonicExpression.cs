//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MnemonicExpression
    {
        public readonly asci16 Value;

        [MethodImpl(Inline)]
        public static implicit operator MnemonicExpression(string src)
            => new MnemonicExpression(src);

        [MethodImpl(Inline)]
        public MnemonicExpression(asci16 src)
            => Value = src;

        [MethodImpl(Inline)]
        public MnemonicExpression(string src)
            => asci.encode(src, out Value);

        [MethodImpl(Inline)]
        public MnemonicExpression(char[] src)
            => asci.encode(src, out Value);

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Value.Length;
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

        [MethodImpl(Inline)]
        public bool Equals(MnemonicExpression src)
            => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is MnemonicExpression x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();
        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        public static MnemonicExpression Empty
            => new MnemonicExpression(asci16.Null);
    }
}