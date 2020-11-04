//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static OpacityApiClass;

    partial struct proxy
    {
        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(byte count)
            => new T[count];

        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(ushort count)
            => new T[count];

        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(uint count)
            => new T[count];

        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(ulong count)
            => new T[count];

        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(long count)
            => new T[count];
    }
}