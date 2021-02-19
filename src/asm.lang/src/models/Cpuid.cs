//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Cpuid
    {
        public readonly asci64 Value;

        [MethodImpl(Inline)]
        public Cpuid(in asci64 src)
            => Value = src;

        [MethodImpl(Inline)]
        public Cpuid(string src)
            => Asci.encode(src, out Value);

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

        public Cpuid Zero
            => Empty;

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

        [MethodImpl(Inline)]
        public bool Equals(Cpuid src)
            => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is Cpuid x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();
        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Cpuid(string src)
            => new Cpuid(src);

        public static Cpuid Empty
            => new Cpuid(Asci.Null);
    }
}