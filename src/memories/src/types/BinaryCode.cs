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
    using static Memories;
    
    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct BinaryCode : IEncoded<BinaryCode,byte[]>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static BinaryCode Empty => new BinaryCode(Control.array<byte>());
         
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public byte[] Encoded {get;}

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static BinaryCode Define(byte[] data)
            => new BinaryCode(data);        
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](BinaryCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(byte[] src)
            => new BinaryCode(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BinaryCode src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static bool operator==(BinaryCode a, BinaryCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BinaryCode a, BinaryCode b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        BinaryCode(byte[] bytes)
        {
            Encoded = insist(bytes);
        }
        
  

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded; }
        
        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => (Length == 0 ) || (Length == 1 && Encoded[0] == 0); }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => !IsEmpty; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref refs.head(Bytes);}
        
        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref refs.skip(Head, index); }
        
        public bool Equals(BinaryCode rhs)
        {
            if(this.IsNonEmpty && rhs.IsNonEmpty)
                return Encoded.SequenceEqual(rhs.Encoded);
            else
                return false;
        }

        public override int GetHashCode()
            => Encoded.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode c && Equals(c);

        public string Format()
            => Encoded.FormatHexBytes();
    }
}