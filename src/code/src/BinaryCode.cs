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

    public interface IBinaryCode<T> : IFormattable<BinaryCode>, INullary<BinaryCode>, IEquatable<BinaryCode>, ILengthwise, IByteSpanProvider<BinaryCode>
        where T : IBinaryCode<T>
    {

    }

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct BinaryCode : IBinaryCode<BinaryCode>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static BinaryCode Empty => new BinaryCode(new byte[]{0});
         
        /// <summary>
        /// The encoded bytes
        /// </summary>
        readonly byte[] Data;

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static BinaryCode Define(byte[] data)
            => new BinaryCode(data);        
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](BinaryCode src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(byte[] src)
            => new BinaryCode(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BinaryCode src)
            => src.Data;

        [MethodImpl(Inline)]
        public static bool operator==(BinaryCode a, BinaryCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BinaryCode a, BinaryCode b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        BinaryCode(byte[] bytes)
        {
            this.Data = bytes;
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public byte LastByte
        {
            [MethodImpl(Inline)]
            get => Data.LastOrDefault();
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Data[0] == 0);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        BinaryCode INullary<BinaryCode>.Zero 
            => Empty;

        public byte this[int i] { [MethodImpl(Inline)] get=> Data[i]; }

        public string Format()
            => Data.FormatHexBytes(Chars.Space,true,true);

        
        public override string ToString() 
            => Format();

        public bool Equals(BinaryCode rhs)
        {
            if(this.IsNonEmpty && rhs.IsNonEmpty)
                return Data.SequenceEqual(rhs.Data);
            else
                return false;
        }

        public override int GetHashCode()
            => Data.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode c && Equals(c);
    }
}