//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public readonly struct EncodedData : IFormattable<EncodedData>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static EncodedData Empty => new EncodedData(MemoryAddress.Zero, new byte[]{0});

        /// <summary>
        /// The nead of the memory location from which the data originated
        /// </summary>
        public readonly MemoryAddress BaseAddress;
         
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public readonly byte[] Bytes;

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static EncodedData Define(MemoryAddress src, byte[] data)
            => new EncodedData(src, data);
        
        /// <summary>
        /// Defines a 0-based block of encoded data
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static EncodedData Define(byte[] data)
            => new EncodedData(MemoryAddress.Zero, data);
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](EncodedData src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(EncodedData src)
            => src.Bytes;

        [MethodImpl(Inline)]
        EncodedData(MemoryAddress src, byte[] bytes)
        {
            this.BaseAddress = src;
            this.Bytes = bytes;
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        public byte LastByte
        {
            [MethodImpl(Inline)]
            get => Bytes.LastOrDefault();
        }

        public MemoryRange AddressRange
        {
            [MethodImpl(Inline)]
            get => (BaseAddress, BaseAddress + (MemoryAddress)Bytes.Length);
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Bytes[0] == 0);
        }

        public string Format()
            => Bytes.FormatHex();

        
        public override string ToString() 
            => Format();         
    }
}