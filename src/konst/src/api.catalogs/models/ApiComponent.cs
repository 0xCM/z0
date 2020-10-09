//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ApiComponent
    {
        public Assembly Assembly {get;}

        [MethodImpl(Inline)]
        public ApiComponent(Assembly src)
        {
            Assembly = src;
        }
    }
}