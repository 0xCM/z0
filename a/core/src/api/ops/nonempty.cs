//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using static Components;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);


        [MethodImpl(Inline)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);
    }
}