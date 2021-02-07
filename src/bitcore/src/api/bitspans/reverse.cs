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
        public static ref readonly BitSpan reverse(in BitSpan src)
        {
            src.Storage.Reverse();
            return ref src;
        }
    }
}