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

    public struct Cell<A,B,C>
        where A : struct, IDataCell<A>
        where B : struct, IDataCell<B>
        where C : struct, IDataCell<C>
    {
        public A C0;

        public B C1;

        public C C2;

        [MethodImpl(Inline)]
        public Cell(in A c0, in B c1, in C c2)
        {
            C0 = c0;
            C1 = c1;
            C2 = c2;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.Tuple3, C0, C1, C2);
    }
}