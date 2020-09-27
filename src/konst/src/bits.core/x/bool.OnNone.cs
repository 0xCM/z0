//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static void OnNone(this bool x, Action f)
        {
            if(!x)
                f();
        }

        [MethodImpl(Inline)]
        public static T IfSome<T>(this bool x, Func<T> f, T @default)
        {
            if(x)
                return f();
            else
                return @default;
        }

        public static void OnNone<T>(this T? x, Action f)
            where T : struct
        {
            if(!x.HasValue)
                f();
        }
    }
}