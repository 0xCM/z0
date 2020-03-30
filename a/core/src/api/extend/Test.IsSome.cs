//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Components;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bool IsSome<T>(this T? src)
            where T : struct
                => src.HasValue;
    }
}