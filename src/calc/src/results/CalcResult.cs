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

    public ref struct CalcResult
    {
        public ApiKey Api {get;}

        public ReadOnlySpan<byte> Data {get;}

        [MethodImpl(Inline)]
        internal CalcResult(ApiKey api, ReadOnlySpan<byte> src)
        {
            Data = src;
            Api = api;
        }
    }

    partial struct CalcResults
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct CalcResult<A0,R> : ICalcResult<CalcResult<A0,R>,R>
            where A0 : unmanaged
            where R : unmanaged
        {
            public ApiKey Api {get; internal set;}

            public A0 Arg0;

            public R Value {get; internal set;}
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CalcResult<A0,A1,R> : ICalcResult<CalcResult<A0,A1,R>,R>
            where A0 : unmanaged
            where A1 : unmanaged
            where R : unmanaged
       {
            public ApiKey Api {get; internal set;}

            public A0 Arg0;

            public A1 Arg1;

            public R Value {get; internal set;}
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CalcResult<A0,A1,A2,R> : ICalcResult<CalcResult<A0,A1,A2,R>,R>
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
            where R : unmanaged
       {
            public ApiKey Api {get; internal set;}

            public A0 Arg0;

            public A1 Arg1;

            public A2 Arg2;

            public R Value {get; internal set;}
       }
    }
}