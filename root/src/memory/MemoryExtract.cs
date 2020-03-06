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

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    public readonly struct MemoryExtract : IFormattable<MemoryExtract>, IAddressable
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static MemoryExtract Empty => new MemoryExtract(MemoryAddress.Zero, new byte[]{0});

        /// <summary>
        /// The nead of the memory location from which the data originated
        /// </summary>
        public MemoryAddress Address {get;}
         
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public readonly byte[] Bytes;

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static MemoryExtract Define(MemoryAddress src, byte[] data)
            => new MemoryExtract(src, data);
        
        /// <summary>
        /// Defines a 0-based block of encoded data
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static MemoryExtract Define(byte[] data)
            => new MemoryExtract(MemoryAddress.Zero, data);
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](MemoryExtract src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(MemoryExtract src)
            => src.Bytes;

        [MethodImpl(Inline)]
        MemoryExtract(MemoryAddress src, byte[] bytes)
        {
            this.Address = src;
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
            get => (Address, Address + (MemoryAddress)Bytes.Length);
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