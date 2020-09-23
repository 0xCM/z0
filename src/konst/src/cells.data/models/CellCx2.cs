//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct Cell<A,B> : IDataCell<Cell<A,B>>
        where A : struct, IDataCell<A>
        where B : struct, IDataCell<B>
    {
        public A C0;

        public B C1;

        public Cell(in A c0, in B c1)
        {
            C0 = c0;
            C1 = c1;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.Tuple2, C0, C1);
    }
}
