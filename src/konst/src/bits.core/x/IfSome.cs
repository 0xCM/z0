//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T IfSome<T>(this bool x, Func<T> f, T @default)
        {
            if(x) return f();
                else return @default;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T IfSome<T>(this bit x, Func<T> f, T @default)
        {
            if(x) return f();
                else return @default;
        }
    }
}