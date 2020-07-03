//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct Konst
    {
        [MethodImpl(Inline), Op]
        public static void ThrowInvariantFailure(string msg)
            => sys.@throw($"The invariant, it failed: {msg}");

        [MethodImpl(Inline), Op]
        public static void ThrowInvariantFailure()
            => sys.@throw($"The invarant, it failed");

        [MethodImpl(Inline)]
        public static void ThrowNullRefError<T>()
            => sys.@throw(new NullReferenceException($"A value of type {typeof(T)}, it is null"));

        [MethodImpl(Inline), Op]
        public static void ThrowEmptySpanError()
            => sys.@throw($"The span, it is empty");
    }
}