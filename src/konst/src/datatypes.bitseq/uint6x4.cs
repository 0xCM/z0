//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Presents 24 bits as 4 b-bit segments
    /// </summary>
    [ApiType, DataType]
    public readonly struct uint6x4 : IDataType<uint24>
    {
        public uint24 Content {get;}

        [MethodImpl(Inline)]
        public uint6x4(uint24 src)
        {
            Content = src;
        }

        public uint6 this[N0 n]
        {
            [MethodImpl(Inline)]
            get => BitSeq.uint6(Content);
        }

        public uint6 this[N1 n]
        {
            [MethodImpl(Inline)]
            get => BitSeq.uint6(Content >> 6);
        }

        public uint6 this[N2 n]
        {
            [MethodImpl(Inline)]
            get => BitSeq.uint6(Content >> 12);
        }

        public uint6 this[N3 n]
        {
            [MethodImpl(Inline)]
            get => BitSeq.uint6(Content >> 18);
        }
    }
}