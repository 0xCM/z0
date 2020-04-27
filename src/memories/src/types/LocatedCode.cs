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
    public readonly struct LocatedCode : ILocatedCode<LocatedCode,BinaryCode>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static LocatedCode Empty => new LocatedCode(MemoryAddress.Zero, new byte[]{0});

        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        public MemoryAddress Address {get;}
         
        /// <summary>
        /// The encoded content
        /// </summary>
        public BinaryCode Content {get;}

        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static LocatedCode Define(MemoryAddress src, byte[] data)
            => new LocatedCode(src, data);
        
        /// <summary>
        /// Defines a 0-based block of encoded data
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static LocatedCode Define(byte[] data)
            => new LocatedCode(MemoryAddress.Zero, data);
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](LocatedCode src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(LocatedCode src)
            => src.Content;

        [MethodImpl(Inline)]
        LocatedCode(MemoryAddress src, byte[] bytes)
        {
            this.Address = src;
            this.Content = BinaryCode.Define(require(bytes));
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Content.Bytes;
        }

        public byte LastByte
        {
            [MethodImpl(Inline)]
            get => Content.LastByte;
        }

        public MemoryRange AddressRange
        {
            [MethodImpl(Inline)]
            get => (Address, Address + (MemoryAddress)Content.Length);
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }

        public string Format()
            => Content.Format();

        public bool Equals(LocatedCode src)
            => Content.Equals(src.Content);
    }
}