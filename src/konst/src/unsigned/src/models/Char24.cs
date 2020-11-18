//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType]
    public readonly struct Char24
    {
        readonly uint24 Data;

        [MethodImpl(Inline)]
        public Char24(uint24 src)
        {
            Data = src;
        }

        public uint6 this[N0 n]
        {
            [MethodImpl(Inline)]
            get => UI.uint6(Data);
        }

        public uint6 this[N1 n]
        {
            [MethodImpl(Inline)]
            get => UI.uint6(Data >> 6);
        }

        public uint6 this[N2 n]
        {
            [MethodImpl(Inline)]
            get => UI.uint6(Data >> 12);
        }

        public uint6 this[N3 n]
        {
            [MethodImpl(Inline)]
            get => UI.uint6(Data >> 18);
        }
    }
}