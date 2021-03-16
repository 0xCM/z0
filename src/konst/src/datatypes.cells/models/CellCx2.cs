//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Cell<A,B> : IDataCell<Cell<A,B>>
        where A : struct, IDataCell
        where B : struct, IDataCell
    {
        public A C0;

        public B C1;

        [MethodImpl(Inline)]
        public Cell(in A c0, in B c1)
        {
            C0 = c0;
            C1 = c1;
        }
        public string Format()
            => text.format(RP.Adjacent2, C0.Format(), C1.Format());
    }
}
