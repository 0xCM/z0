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

    public ref struct ApiCall
    {
        public ApiKey Api {get;}

        public ReadOnlySpan<byte> Data {get;}

        [MethodImpl(Inline)]
        internal ApiCall(ApiKey api, ReadOnlySpan<byte> src)
        {
            Data = src;
            Api = api;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,R> : IApiCall<ApiCall<A0,R>,R>
        where A0 : unmanaged
        where R : unmanaged
    {
        public ApiKey Api {get; internal set;}

        public A0 Arg0;

        public R Result {get; internal set;}
    }

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