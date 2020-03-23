//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class TypeWidthOps
    {
        public static string Format(this TypeWidth w)
            => w.ToUInt16().ToString();
    }
}