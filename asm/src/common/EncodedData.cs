//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EncodedData : IFormattable<EncodedData>
    {
        [MethodImpl(Inline)]
        public static implicit operator EncodedData(byte[] src)
            => new EncodedData(src);

        [MethodImpl(Inline)]
        public static implicit operator byte[](EncodedData src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public EncodedData(byte[] bytes)
            => this.Bytes = bytes;

        public readonly byte[] Bytes;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        public string Format()
            => Bytes.FormatHex();

        
        public override string ToString() 
            => Format();         
    }
}