//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Components;

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static void IfNone(this bool x, Action f)
        {
            if(!x)
                f();
        }

    }
}