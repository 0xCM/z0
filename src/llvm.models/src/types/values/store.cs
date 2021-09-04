//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Types;

    partial struct Values
    {
        [MethodImpl(Inline)]
        public static uint store<O,A0>(in dag<O,A0> src, Span<byte> dst)
            where O : unmanaged
            where A0 : unmanaged
        {
            ref var o = ref first(recover<O>(dst));
            o = src.Operator;
            ref var a0 = ref seek(dst, size<O>());
            @as<A0>(a0) = src.Arg0;
            return src.StorageSize;
        }

        [MethodImpl(Inline)]
        public static uint store<O,A0,A1>(in dag<O,A0,A1> src, Span<byte> dst)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
        {
            ref var o = ref first(recover<O>(dst));
            o = src.Operator;
            ref var a0 = ref seek(dst, size<O>());
            @as<A0>(a0) = src.Arg0;
            ref var a1 = ref seek(dst, size<O>() + size<A0>());
            @as<A1>(a1) = src.Arg1;
            return src.StorageSize;
        }

        [MethodImpl(Inline)]
        public static uint store<O,A0,A1,A2>(in dag<O,A0,A1,A2> src, Span<byte> dst)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
        {
            ref var o = ref first(recover<O>(dst));
            o = src.Operator;
            ref var a0 = ref seek(dst, size<O>());
            @as<A0>(a0) = src.Arg0;
            ref var a1 = ref seek(dst, size<O>() + size<A0>());
            @as<A1>(a1) = src.Arg1;
            ref var a2 = ref seek(dst, size<O>() + size<A0>() + size<A1>());
            @as<A2>(a2) = src.Arg2;
            return src.StorageSize;
        }
    }
}