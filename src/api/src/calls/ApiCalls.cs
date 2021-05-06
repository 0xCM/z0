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
    public readonly partial struct ApiCalls
    {
        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,R> call<A0,A1,R>(ApiKey api, uint offset, in A0 a0, in A1 a1, in R result)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
                => define(api, skip(a0, offset), skip(a1, offset), skip(result, offset));

        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,R> call<A0,A1,R>(ApiKey api, uint offset, ReadOnlySpan<A0> a0, ReadOnlySpan<A1> a1, ReadOnlySpan<R> result)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
                => define(api, skip(a0, offset), skip(a1, offset), skip(result, offset));

        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,R> call<A0,A1,R>(ApiKey api, uint offset, in SpanBlock256<A0> a0, in SpanBlock256<A1> a1, in SpanBlock256<R> result)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
                => define(api, a0[offset], a1[offset], result[offset]);

        [MethodImpl(Inline)]
        public static ApiCallData serialize<T>(in T result)
            where T : unmanaged, IApiCall<T>
                => new ApiCallData(result.Api, slice(bytes(result),16));

        [MethodImpl(Inline)]
        static ApiCall<A0,R> define<A0,R>(ApiKey api, in A0 a0, in R result)
            where A0 : unmanaged
            where R : unmanaged
        {
            var dst = new ApiCall<A0,R>();
            dst.Api = api;
            dst.Arg0 = a0;
            dst.Result = result;
            return dst;
        }

        [MethodImpl(Inline)]
        static ApiCall<A0,A1,R> define<A0,A1,R>(ApiKey api, in A0 a0, in A1 a1, in R result)
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
        {
            var dst = new ApiCall<A0,A1,R>();
            dst.Api = api;
            dst.Arg0 = a0;
            dst.Arg1 = a1;
            dst.Result = result;
            return dst;
        }

        [MethodImpl(Inline)]
        static ApiCall<A0,A1,A2,R> define<A0,A1,A2,R>(ApiKey api, in A0 a0, in A1 a1, in A2 a2, in R result)
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
            where R : unmanaged
        {
            var dst = new ApiCall<A0,A1,A2,R>();
            dst.Api = api;
            dst.Arg0 = a0;
            dst.Arg1 = a1;
            dst.Arg2 = a2;
            dst.Result = result;
            return dst;
        }


        [MethodImpl(Inline), Op]
        static ApiCall<uint,uint,uint> call(ApiKey api, uint a0, uint a1, uint value)
            => define(api,a0,a1,value);

        [MethodImpl(Inline), Op]
        static void call(ApiKey api, in Cell256 a0, in Cell256 a1, in Cell256 value, out Span<byte> dst)
            => dst = @bytes(define(api, a0, a1, value));

        [MethodImpl(Inline), Op]
        static ApiCall<Cell128,Cell128,Cell128> call(ApiKey api, in Cell128 a0, in Cell128 a1, in Cell128 value)
            => define(api, a0, a1, value);

        [MethodImpl(Inline), Op]
        static ApiCallData generalize(in ApiCall<Cell128,Cell128,Cell128> result)
            => serialize(result);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        static ApiCall<T,T,T> call<T>(ApiKey api, uint offset, in T a0, in T a1, in T value)
            where T : unmanaged
                => define(api, skip(a0,offset), skip(a1,offset), skip(value, offset));
   }
}