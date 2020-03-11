//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Root;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct BinaryCode : IFormattable<BinaryCode>, INullary<BinaryCode>, IEquatable<BinaryCode>, IIndexed<byte>, ILengthwise
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static BinaryCode Empty => new BinaryCode(new byte[]{0});
         
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public readonly byte[] Bytes;

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static BinaryCode Define(byte[] data)
            => new BinaryCode(data);        
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](BinaryCode src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(byte[] src)
            => new BinaryCode(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(BinaryCode src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public static bool operator==(BinaryCode a, BinaryCode b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(BinaryCode a, BinaryCode b)
            => !a.Equals(b);


        [MethodImpl(Inline)]
        BinaryCode(byte[] bytes)
        {
            this.Bytes = bytes;
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        public byte LastByte
        {
            [MethodImpl(Inline)]
            get => Bytes.LastOrDefault();
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Bytes[0] == 0);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        BinaryCode INullary<BinaryCode>.Empty 
            => Empty;

        public byte this[int i] { [MethodImpl(Inline)] get=> Bytes[i]; }

        public string Format()
            => Bytes.FormatHex();

        
        public override string ToString() 
            => Format();

        public bool Equals(BinaryCode rhs)
        {
            if(this.IsNonEmpty && rhs.IsNonEmpty)
                return Bytes.SequenceEqual(rhs.Bytes);
            else
                return false;
        }

        public override int GetHashCode()
            => Bytes.GetHashCode();
        
        public override bool Equals(object src)
            => src is BinaryCode c && Equals(c);
    }
}