//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        [Op,Closures(UInt8k | UInt16k)]
        public static Pair<uint> cross<K>(in SymGrid<K> src, Receiver<SymPair<K>> f)
            where K : unmanaged
        {
            var rows = src.Rows;
            var r = (uint)rows.Length;
            var cols = src.Cols;
            var c = (uint)cols.Length;
            var counter = 0u;
            for(var i=0; i<r; i++)
            {
                ref readonly var row = ref skip(rows,i);
                for(var j=0; j<c; j++)
                {
                    ref readonly var col = ref skip(cols,i);
                    f((row,col));
                }
            }
            return root.pair(r,c);
        }
    }
}