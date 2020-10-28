//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Text;

    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;


    public readonly struct CacheSpec<N,W>
        where N : unmanaged, ITypeNat
        where W : unmanaged, ICellWidth
    {
        public Count CellCount => nat32u<N>();

        public CellWidth CellWidth => Widths.cell<W>();
    }
    public readonly struct CacheContext
    {
        readonly byte[] Cache;

        readonly SegRef[] Segments;

        //public CachContext(byte[] cache, SegRef[])

    }
}