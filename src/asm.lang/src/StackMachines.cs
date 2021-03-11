//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct StackMachines
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Closures(Closure)]
        public static StackMachine<T> create<T>(uint capacity)
            => new StackMachine<T>(capacity);

        [MethodImpl(Inline), Closures(Closure)]
        public static bool push<T>(T src, ref StackMachine<T> dst)
            => dst.Push(src);

        [MethodImpl(Inline), Closures(Closure)]
        public static bool pop<T>(ref StackMachine<T> src, out T dst)
            => src.Pop(out dst);
    }
}