//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ClrQuery
    {
        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <typeparam name="T">The type to search</typeparam>
        /// <typeparam name="A1">The first argument type</typeparam>
        /// <typeparam name="A2">The second argument type</typeparam>
        public static Option<MethodInfo> method<T,X,R>(string name)
            => typeof(T).MatchMethod(name, typeof(X), typeof(R));

        [MethodImpl(Inline), Op]
        public static MethodInfo method(Delegate src)
            => src.Method;
    }
}