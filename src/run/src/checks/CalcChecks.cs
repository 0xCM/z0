//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct CalcChecks
    {
        public static string apply<K,T>(K k, T x, T y)
            where K : IApiKey
                => $"{k.Format()}({x},{y})";

        public static string success<K,T>(K k, T x, T y, T result)
            where K : IApiKey
                => $"{k.Format()}({x},{y}) := {result}";

        public static string failure<K,T>(K k, T x, T y, T expect, T actual)
            where K : IApiKey
                => $"{apply(k,x,y)} := {actual} != {expect}";

        public static string describe<K,T>(K k, T x, T y, T result)
            where K : IApiKey
            where T : IEquatable<T>
                => $"{apply(k,x,y)} = {result}";

        public static string describe<K,T>(K k, T x, T y, T expect, T actual)
            where K : IApiKey
            where T : IEquatable<T>
                => expect.Equals(actual) ? success(k,x,y,actual) : failure(k,x,y,expect,actual);
    }
}