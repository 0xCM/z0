//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class TypeWidthOps
    {
        public static string Format(this TypeWidth w)
            => ((ushort)w).ToString();
    }
}