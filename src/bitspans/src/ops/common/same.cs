//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static bit same(in BitSpan a, in BitSpan b)
        {
            if(a.Length != b.Length)
                return false;

            for(var i=0; i<a.Length; i++)
                if(a[i] != b[i])
                    return false;

            return true;
        }
    }
}