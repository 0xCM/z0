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
        public static void OnSome(this bool x, Action f)
        {
            if(x)
                f();
        }


        public static void OnSome<T>(this T? x, Action<T> f)
            where T : struct
        {
            if(x.HasValue)
                f(x.Value); 
        }

    }
}