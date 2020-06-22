//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    
    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct BinaryCode : IEncoded<BinaryCode,byte[]>
    {
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public byte[] Encoded {get;}

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data 
        { 
            [MethodImpl(Inline)] 
            get => Encoded;
        }
                
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => (Length == 0 ) || (Length == 1 && Encoded[0] == 0); 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => !IsEmpty; 
        }        
        
        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index];
        }

        [MethodImpl(Inline)]
        public BinaryCode(byte[] bytes)
        {
            Encoded = Root.insist(bytes);
        }

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(Span<byte> src)
            => new BinaryCode(src.ToArray());

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
       
        public bool Equals(BinaryCode src)
        {
            if(IsNonEmpty && src.IsNonEmpty)
                return Encoded.SequenceEqual(src.Encoded);
            else
                return false;
        }
        
        public string Format()
            => Encoded.FormatHexBytes();

        public string Format(HexFormatConfig config)
            => Encoded.FormatHexBytes(config);

        public override int GetHashCode()
            => Encoded.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode encoded && Equals(encoded);
        
        public override string ToString() 
            => Format();

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static BinaryCode Empty 
            => new BinaryCode(Array.Empty<byte>());
    }
}