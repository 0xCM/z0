//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    public static partial class RootX
    {
        public static bool IsSome(this IndicatorKind kind)
            => kind != IndicatorKind.None;

        public static string Format(this IndicatorKind kind)
            => kind.IsSome() ? $"{(char)kind}" : string.Empty;
    }
}