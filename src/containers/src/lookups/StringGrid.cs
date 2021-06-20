//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public class StringGrid
    {
        public static StringGrid create(ushort rows, ushort cols)
            => new StringGrid(rows,cols);

        internal readonly string[,] Data;

        public StringGrid(ushort rows, ushort cols)
        {
            Data = new string[rows,cols];
        }

        public ref string this[ushort i, ushort j]
        {
            [MethodImpl(Inline)]
            get => ref Data[i,j];
        }
    }
}