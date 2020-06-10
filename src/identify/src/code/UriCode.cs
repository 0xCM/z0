//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Specifes a uri-identified located code block, similar to the content of a line in a parsed code report for an api host
    /// </summary>
    public readonly struct UriCode : 
        IMemberCode<UriCode,LocatedCode>, 
        IUriCode<UriCode,LocatedCode>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static UriCode Empty => Define(OpUri.Empty, LocatedCode.Empty);

        [MethodImpl(Inline)]
        public static UriCode Define(OpUri uri, LocatedCode data)
            => new UriCode(uri, data);

        [MethodImpl(Inline)]
        public static UriCode Define(OpUri uri, MemoryAddress address, BinaryCode encoded)
            => new UriCode(uri, LocatedCode.Define(address,encoded));

        /// <summary>
        /// The source member identity
        /// </summary>
        public OpUri OpUri {get;}

        /// <summary>
        /// The data, located
        /// </summary>
        public LocatedCode Encoded {get;}

        public PartId Part => OpUri.Part;
        
        public OpIdentity OpId => OpUri.OpId;

        public ApiHostUri Host => OpUri.Host;

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data { [MethodImpl(Inline)] get => Encoded.Data;}
        
        /// <summary>
        /// The encoded byte count
        /// </summary>
        public int ByteCount { [MethodImpl(Inline)] get => Encoded.Length; }

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Encoded; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}

        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

        public MemoryAddress Address  { [MethodImpl(Inline)] get => Encoded.Address; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment;}

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(UriCode code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(UriCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator LocatedCode(UriCode src)
            => src.Encoded;


        [MethodImpl(Inline)]
        public static implicit operator UriHex(UriCode src)
            => new UriHex(src.OpUri, src.Encoded);

        [MethodImpl(Inline)]
        public UriCode(OpUri uri, LocatedCode code)
        {
            OpUri = uri;
            Encoded = code;
        }
        
        public string Format(int idpad)
        {
            var a = Encoded.Format();
            var b = OpUri.Format().PadRight(idpad);
            return string.Concat(a,b);
        }

        public string Format()
            => Format(80);

        public bool Equals(UriCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => OpUri.GetHashCode();

        public override bool Equals(object src)
            => src is UriCode x && Equals(x);        
    }
}