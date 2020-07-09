//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    [ApiHost]
    public readonly struct Calls
    {
        [MethodImpl(Inline), Op]
        public static CallClient client(MemoryAddress @base)
            => new CallClient(@base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(MemoryAddress @base)
            => new CallTarget(@base);            

        [MethodImpl(Inline), Op]
        public static CallClient client(string id, MemoryAddress @base)
            => new CallClient(id, @base);

        [MethodImpl(Inline), Op]
        public static CallTarget target(string id, MemoryAddress @base)
            => new CallTarget(id, @base);            

        [MethodImpl(Inline), Op]
        public static Invocation call(MemoryAddress src, ushort callsite, MemoryAddress dst, MemoryAddress actual = default)
            => new Invocation(client(src), callsite, target(dst), target(actual));
    }
}