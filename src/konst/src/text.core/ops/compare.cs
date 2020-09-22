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

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static int compare(string a, string b)
            => a?.CompareTo(b) ?? 0;
    }
}