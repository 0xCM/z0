//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public ref struct ApiCallData
    {
        public ApiKey Api {get;}

        public ReadOnlySpan<byte> Bytes {get;}

        [MethodImpl(Inline)]
        internal ApiCallData(ApiKey api, ReadOnlySpan<byte> src)
        {
            Bytes = src;
            Api = api;
        }
    }

    /// <summary>
    /// Rpresents an action invocation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall : IApiCall<ApiCall>
    {
        public ApiKey Api {get; internal set;}
    }

    /// <summary>
    /// Rpresents an emitter invocation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<R> : IApiCall<ApiCall<R>,R>
        where R : unmanaged
    {
        public ApiKey Api {get; internal set;}

        public R Result {get; internal set;}
    }

    /// <summary>
    /// Rpresents an unary function invocation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,R> : IApiCall<ApiCall<A0,R>,R>
        where A0 : unmanaged
        where R : unmanaged
    {
        public ApiKey Api {get; internal set;}

        public A0 Arg0;

        public R Result {get; internal set;}
    }

    /// <summary>
    /// Rpresents a binary function invocation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1,R> : IApiCall<ApiCall<A0,A1,R>,R>
        where A0 : unmanaged
        where A1 : unmanaged
        where R : unmanaged
    {
        public ApiKey Api {get; internal set;}

        public A0 Arg0;

        public A1 Arg1;

        public R Result {get; internal set;}
    }

    /// <summary>
    /// Rpresents a ternary function invocation
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1,A2,R> : IApiCall<ApiCall<A0,A1,A2,R>,R>
        where A0 : unmanaged
        where A1 : unmanaged
        where A2 : unmanaged
        where R : unmanaged
    {
        public ApiKey Api {get; internal set;}

        public A0 Arg0;

        public A1 Arg1;

        public A2 Arg2;

        public R Result {get; internal set;}
    }
}