//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T sub<T>(in T src, sbyte offset)
            => ref Subtract(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T sub<T>(in T src, byte offset)
            => ref Subtract(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T sub<T>(in T src, short offset)
            => ref Subtract(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T sub<T>(in T src, ushort offset)
            => ref Subtract(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T sub<T>(in T src, int offset)
            => ref Subtract(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T sub<T>(in T src, uint offset)
            => ref Subtract(ref edit(src), (int)offset);
    }
}