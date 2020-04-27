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
        public static BinaryCode Empty => new BinaryCode(new byte[]{0});
         
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public byte[] Content {get;}

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static BinaryCode Define(byte[] data)
            => new BinaryCode(data);        
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](BinaryCode src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(byte[] src)
            => new BinaryCode(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BinaryCode src)
            => src.Content;

        [MethodImpl(Inline)]
        public static bool operator==(BinaryCode a, BinaryCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BinaryCode a, BinaryCode b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        BinaryCode(byte[] bytes)
        {
            this.Content = require(bytes);
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length;
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Content[0] == 0);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public byte LastByte
        {
            [MethodImpl(Inline)]
            get => Content.LastOrDefault();
        }

        public byte this[int i] 
        { 
            [MethodImpl(Inline)] 
            get=> Content[i]; 
        }

        public bool Equals(BinaryCode rhs)
        {
            if(this.IsNonEmpty && rhs.IsNonEmpty)
                return Content.SequenceEqual(rhs.Content);
            else
                return false;
        }

        public override int GetHashCode()
            => Content.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode c && Equals(c);

        public string Format()
            => Content.FormatHexBytes();
    }
}