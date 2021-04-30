//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    readonly struct CalcDemoUtil
    {
        public static string apply<K,T>(K k, T x, T y)
            where K : IApiKind
                => $"{k.Format()}({x},{y})";

        public static string success<K,T>(K k, T x, T y, T result)
            where K : IApiKind
                => $"{k.Format()}({x},{y}) := {result}";

        public static string failure<K,T>(K k, T x, T y, T expect, T actual)
            where K : IApiKind
                => $"{apply(k,x,y)} := {actual} != {expect}";

        public static string describe<K,T>(K k, T x, T y, T result)
            where K : IApiKind
            where T : IEquatable<T>
                => $"{apply(k,x,y)} = {result}";

        public static string describe<K,T>(K k, T x, T y, T expect, T actual)
            where K : IApiKind
            where T : IEquatable<T>
                => expect.Equals(actual) ? success(k, x, y, actual) : failure(k, x, y, expect, actual);
    }
}