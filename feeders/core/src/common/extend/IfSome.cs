//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static void IfSome(this bool x, Action f)
        {
            if(x)
                f();
        }
    }
}