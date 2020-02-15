//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static zfunc;
        
    public readonly struct MethodEncoding : IFormattable<MethodEncoding>
    {                
        [MethodImpl(Inline)]
        public static MethodEncoding Define(EncodedMethod src, byte[] data)
            => new MethodEncoding(src,data);

        [MethodImpl(Inline)]
        public static implicit operator byte[](MethodEncoding src)
            => src.Data;

        [MethodImpl(Inline)]
        MethodEncoding(EncodedMethod src, byte[] data)
        {
            this.Source = src;
            this.Data = data;
        }

        public readonly EncodedMethod Source;

        public readonly byte[] Data;

        public string Format()
            => Data.FormatHex();
    }

}
