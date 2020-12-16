//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct TableRows
    {
        [MethodImpl(Inline)]
        public static Rowset<T> rowset<T>(T[] src)
            where T : struct
                => new Rowset<T>(src);

        [MethodImpl(Inline)]
        public static TableRow<C0,C1,C2> row<C0,C1,C2>(in C0 c0, in C1 c1, in C2 c2)
        {
            var dst = default(TableRow<C0,C1,C2>);
            dst.Col0 = c0;
            dst.Col1 = c1;
            dst.Col2 = c2;
            return dst;
        }

        [MethodImpl(Inline)]
        public static TableRow<C0,C1,C2,C3> row<C0,C1,C2,C3>(in C0 c0, in C1 c1, in C2 c2, in C3 c3)
        {
            var dst = default(TableRow<C0,C1,C2,C3>);
            dst.Col0 = c0;
            dst.Col1 = c1;
            dst.Col2 = c2;
            dst.Col3 = c3;
            return dst;
        }

        [MethodImpl(Inline)]
        public static TableRow<C0,C1,C2,C3,C4> row<C0,C1,C2,C3,C4>(in C0 c0, in C1 c1, in C2 c2, in C3 c3, in C4 c4)
        {
            var dst = default(TableRow<C0,C1,C2,C3,C4>);
            dst.Col0 = c0;
            dst.Col1 = c1;
            dst.Col2 = c2;
            dst.Col3 = c3;
            dst.Col4 = c4;
            return dst;
        }
    }
}