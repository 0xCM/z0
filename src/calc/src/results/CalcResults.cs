//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct CalcResults
    {
        [MethodImpl(Inline)]
        public static CalcResult<A0,A1,R> define<A0,A1,R>(ApiKey api, uint offset, in A0 a0, in A1 a1, in R value)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
                => result(api, skip(a0, offset), skip(a1, offset), skip(value, offset));

        [MethodImpl(Inline)]
        public static CalcResult<A0,A1,R> define<A0,A1,R>(ApiKey api, uint offset, ReadOnlySpan<A0> a0, ReadOnlySpan<A1> a1, ReadOnlySpan<R> value)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
                => result(api, skip(a0, offset), skip(a1, offset), skip(value, offset));

        [MethodImpl(Inline)]
        public static CalcResult<A0,A1,R> define<A0,A1,R>(ApiKey api, uint offset, in SpanBlock256<A0> a0, in SpanBlock256<A1> a1, in SpanBlock256<R> value)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
                => result(api, a0[offset], a1[offset], value[offset]);

        [MethodImpl(Inline)]
        public static CalcResult serialize<T>(in T result)
            where T : unmanaged, ICalcResult<T>
                => new CalcResult(result.Api, slice(bytes(result),16));

        [MethodImpl(Inline)]
        static CalcResult<A0,R> result<A0,R>(ApiKey api, in A0 a0, in R value)
            where A0 : unmanaged
            where R : unmanaged
        {
            var dst = new CalcResult<A0,R>();
            dst.Api = api;
            dst.Arg0 = a0;
            dst.Value = value;
            return dst;
        }

        [MethodImpl(Inline)]
        static CalcResult<A0,A1,R> result<A0,A1,R>(ApiKey api, in A0 a0, in A1 a1, in R value)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
        {
            var dst = new CalcResult<A0,A1,R>();
            dst.Api = api;
            dst.Arg0 = a0;
            dst.Arg1 = a1;
            dst.Value = value;
            return dst;
        }

        [MethodImpl(Inline)]
        static CalcResult<A0,A1,A2,R> result<A0,A1,A2,R>(ApiKey api, in A0 a0, in A1 a1, in A2 a2, in R value)
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
            where R : unmanaged
        {
            var dst = new CalcResult<A0,A1,A2,R>();
            dst.Api = api;
            dst.Arg0 = a0;
            dst.Arg1 = a1;
            dst.Arg2 = a2;
            dst.Value = value;
            return dst;
        }


        [MethodImpl(Inline), Op]
        static CalcResult<uint,uint,uint> define(ApiKey api, uint a0, uint a1, uint value)
            => result(api,a0,a1,value);

        [MethodImpl(Inline), Op]
        static void define(ApiKey api, in Cell256 a0, in Cell256 a1, in Cell256 value, out Span<byte> dst)
            => dst = @bytes(result(api, a0, a1, value));

        [MethodImpl(Inline), Op]
        static CalcResult<Cell128,Cell128,Cell128> define(ApiKey api, in Cell128 a0, in Cell128 a1, in Cell128 value)
            => result(api, a0, a1, value);

        [MethodImpl(Inline), Op]
        static CalcResult generalize(in CalcResult<Cell128,Cell128,Cell128> result)
            => serialize(result);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        static CalcResult<T,T,T> define<T>(ApiKey api, uint offset, in T a0, in T a1, in T value)
            where T : unmanaged
                => result(api, skip(a0,offset), skip(a1,offset), skip(value, offset));
   }
}