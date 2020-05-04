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
    public readonly struct HostedBits : 
        ILocatedCode<HostedBits,LocatedCode>, 
        IUriCode<HostedBits,LocatedCode>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static HostedBits Empty => Define(OpUri.Empty, LocatedCode.Empty);

        [MethodImpl(Inline)]
        public static HostedBits Define(OpUri uri, LocatedCode data)
            => new HostedBits(uri, data);

        /// <summary>
        /// The source member identity
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The data, located
        /// </summary>
        public LocatedCode Encoded {get;}

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Encoded; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}

        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

        public MemoryAddress Address  { [MethodImpl(Inline)] get => Encoded.Address; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment;}

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(HostedBits code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(HostedBits src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator UriBits(HostedBits src)
            => new UriBits(src.Uri, src.Encoded.Encoded);

        [MethodImpl(Inline)]
        internal HostedBits(OpUri uri, LocatedCode code)
        {
            Uri = uri;
            Encoded = code;
        }
        
        public string Format(int idpad)
        {
            var a = Encoded.Format();
            var b = Uri.Format().PadRight(idpad);
            return string.Concat(a,b);
        }

        public string Format()
            => Format(80);

        public bool Equals(HostedBits src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is HostedBits x && Equals(x);        
    }
}