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
    public readonly struct BasedCodeBlock
    {
        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        public MemoryAddress Base {get;}

        /// <summary>
        /// The encoded content
        /// </summary>
        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public BasedCodeBlock(MemoryAddress src, byte[] data)
        {
            Base = z.insist(src, x => x.IsNonEmpty);
            Encoded = new BinaryCode(z.insist(data));
        }

        public MemoryRange MemorySegment
        {
            [MethodImpl(Inline)]
            get => (Base, Base + (MemoryAddress)Encoded.Length);
        }

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
        public bool Equals(BasedCodeBlock src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => Encoded.Format();


        public override int GetHashCode()
            => Encoded.GetHashCode();

        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);

        [MethodImpl(Inline)]
        BasedCodeBlock(ulong zero)
        {
            Base = zero;
            Encoded = Array.Empty<byte>();
        }

        [MethodImpl(Inline)]
        public static implicit operator byte[](BasedCodeBlock src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(BasedCodeBlock src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BasedCodeBlock src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static bool operator==(BasedCodeBlock a, BasedCodeBlock b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BasedCodeBlock a, BasedCodeBlock b)
            => !a.Equals(b);

        public static BasedCodeBlock Empty
            => new BasedCodeBlock(0);
    }
}