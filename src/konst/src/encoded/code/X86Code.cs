//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source with a known (nonzero) location
    /// </summary>
    public readonly struct X86Code : ILocatedCode<X86Code,BinaryCode>
    {
        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        public MemoryAddress Base {get;}

        /// <summary>
        /// The encoded content
        /// </summary>
        public BinaryCode Encoded {get;}

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        public ref readonly byte this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public ref readonly byte this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator byte[](X86Code src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(X86Code src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(X86Code src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static bool operator==(X86Code a, X86Code b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(X86Code a, X86Code b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public X86Code(MemoryAddress src, byte[] data)
        {
            Base = z.insist(src, x => x.IsNonEmpty);
            Encoded = new BinaryCode(z.insist(data));
        }

        [MethodImpl(Inline)]
        public bool Equals(X86Code src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => Encoded.Format();


        public override int GetHashCode()
            => Encoded.GetHashCode();

        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        [MethodImpl(Inline)]
        X86Code(ulong zero)
        {
            Base = zero;
            Encoded = Array.Empty<byte>();
        }

        public MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (Base, Base + (MemoryAddress)Encoded.Length);
        }

        public static X86Code Empty
            => new X86Code(0);
    }
}