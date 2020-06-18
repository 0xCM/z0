//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct Displays
    {
        public static string apply<K,T>(K k, T x, T y)
            where K : IOpKind
                => $"{k.Format()}({x},{y})";

        public static AppMsg success<K,T>(K k, T x, T y, T result)
            where K : IOpKind
                => AppMsg.NoCaller($"{k.Format()}({x},{y}) := {result}", AppMsgKind.Info);

        public static AppMsg failure<K,T>(K k, T x, T y, T expect, T actual)
            where K : IOpKind
                => AppMsg.NoCaller($"{apply(k,x,y)} := {actual} != {expect}", AppMsgKind.Error);

        public static AppMsg describe<K,T>(K k, T x, T y, T result)
            where K : IOpKind
            where T : IEquatable<T>
                => AppMsg.Colorize($"{apply(k,x,y)} = {result}", AppMsgColor.Magenta);

        public static AppMsg describe<K,T>(K k, T x, T y, T expect, T actual)
            where K : IOpKind
            where T : IEquatable<T>
                => expect.Equals(actual) 
                ? success(k,x,y,actual) 
                : failure(k,x,y,expect,actual);
    }

}