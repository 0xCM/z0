//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static OpacityKind;

    partial struct proxy
    {        
        [MethodImpl(Options), Opaque(Throw)]
        public static void @throw(string msg)
            => throw new Exception(msg);

        [MethodImpl(Options), Opaque(Throw)]
        public static void @throw(Exception e)
            => throw e;

        [MethodImpl(Options), Opaque(Throw)]
        public static void @throw(object e)
            => throw new Exception($"e");

        [MethodImpl(Options), Opaque(Throw)]
        public static void @throw(Func<string> f)
            => throw new Exception(f());

        [MethodImpl(Options), Opaque(Throw), Closures(Closure)]
        public static T @throw<T>(Exception e)
            => throw e;
    }
}