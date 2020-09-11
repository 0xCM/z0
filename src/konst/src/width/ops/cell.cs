//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = CellWidth;

    partial class Widths
    {
        [MethodImpl(Inline)]
        public static CellWidth cell<W>(W w = default)
            where W : struct, ICellWidth
        {
            if(typeof(W) == typeof(W16))
                return K.W16;
            else if(typeof(W) == typeof(W32))
                return K.W32;
            else if(typeof(W) == typeof(W64))
                return K.W64;
            else if(typeof(W) == typeof(W128))
                return K.W128;
            else if(typeof(W) == typeof(W256))
                return K.W256;
            else if(typeof(W) == typeof(W512))
                return K.W512;
            else
                return 0;
        }
    }
}