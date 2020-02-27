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
        public static EncodedData Define(MemoryAddress src, byte[] data)
            => new EncodedData(src,data);
        
        [MethodImpl(Inline)]
        public static implicit operator byte[](EncodedData src)
            => src.Bytes;

        [MethodImpl(Inline)]
        EncodedData(MemoryAddress src, byte[] bytes)
        {
            this.BaseAddress = src;
            this.Bytes = bytes;
        }

        public readonly MemoryAddress BaseAddress;
         
        public readonly byte[] Bytes;

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

        public string Format()
            => Bytes.FormatHex();

        
        public override string ToString() 
            => Format();         
    }
}