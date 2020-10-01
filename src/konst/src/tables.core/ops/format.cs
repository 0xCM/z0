//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string cell<T>(in CellFormatter<T,string> formatter, in T src)
            => formatter.Format(src);
    }
}