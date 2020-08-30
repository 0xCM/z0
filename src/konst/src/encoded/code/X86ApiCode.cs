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
    /// Defines a uri-identified encoded block with a known base address
    /// </summary>
    public readonly struct X86ApiCode : IMemberCode<X86ApiCode,X86Code>
    {
        /// <summary>
        /// The source member identity
        /// </summary>
        public OpUri OpUri {get;}

        /// <summary>
        /// The data, located
        /// </summary>
        public X86Code Encoded {get;}

        [MethodImpl(Inline)]
        public X86ApiCode(OpUri uri, MemoryAddress address, BinaryCode encoded)
        {
            OpUri = uri;
            Encoded = new X86Code(address,encoded);
        }

        [MethodImpl(Inline)]
        public X86ApiCode(OpUri uri, X86Code code)
        {
            OpUri = uri;
            Encoded = code;
        }

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        /// <summary>
        /// The encoded byte count
        /// </summary>
        public int Size
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
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

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(X86ApiCode code)
            => code.Data;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(X86ApiCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator X86Code(X86ApiCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedCode(X86ApiCode src)
            => new IdentifiedCode(src.Address, src.OpUri, src.Encoded);

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Encoded.Address;
        }

        public PartId Part
            => OpUri.Part;

        public OpIdentity OpId
            => OpUri.OpId;

        public ApiHostUri Host
            => OpUri.Host;

        public string Format(int idpad)
        {
            var a = Encoded.Format();
            var b = OpUri.Format().PadRight(idpad);
            return string.Concat(a,b);
        }

        public string Format()
            => Format(80);

        public bool Equals(X86ApiCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => OpUri.GetHashCode();

        public override bool Equals(object src)
            => src is X86ApiCode x && Equals(x);

        public static X86ApiCode Empty
            => new X86ApiCode(OpUri.Empty, X86Code.Empty);
    }
}