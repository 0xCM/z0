//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static ReflectionFlags;

    partial struct ClrQuerySvc
    {
        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <typeparam name="T">The type to search</typeparam>
        /// <typeparam name="A1">The first argument type</typeparam>
        /// <typeparam name="A2">The second argument type</typeparam>
        [MethodImpl(Inline)]
        public static Option<MethodInfo> method<T,X,R>(string name)
            => typeof(T).MatchMethod(name, typeof(X), typeof(R));
    }
}