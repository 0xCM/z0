//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [ApiHost(ApiNames.ApiCalls, true)]
    public readonly struct ApiCalls
    {
        [MethodImpl(Inline), Op]
        public static ApiCall define(ApiClass @class)
        {
            var call = new ApiCall();
            call.Class = @class;
            return call;
        }

        [MethodImpl(Inline)]
        public static ApiCall<A0> define<A0>(ApiClass @class, A0 a0)
        {
            var call = new ApiCall<A0>();
            call.Class = @class;
            call.Arg0 = a0;
            return call;
        }

        [MethodImpl(Inline)]
        public static ApiCall<A0,A1> define<A0,A1>(ApiClass @class, A0 a0, A1 a1)
        {
            var call = new ApiCall<A0,A1>();
            call.Class = @class;
            call.Arg0 = a0;
            call.Arg1 = a1;
            return call;
        }

        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,A2> define<A0,A1,A2>(ApiClass @class, A0 a0, A1 a1, A2 a2)
        {
            var call = new ApiCall<A0,A1,A2>();
            call.Class = @class;
            call.Arg0 = a0;
            call.Arg1 = a1;
            call.Arg2 = a2;
            return call;
        }

        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,A2,A3> define<A0,A1,A2,A3>(ApiClass @class, A0 a0, A1 a1, A2 a2, A3 a3)
        {
            var call = new ApiCall<A0,A1,A2,A3>();
            call.Class = @class;
            call.Arg0 = a0;
            call.Arg1 = a1;
            call.Arg2 = a2;
            call.Arg3 = a3;
            return call;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0>
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;

        /// <summary>
        /// The first operand
        /// </summary>
        public A0 Arg0;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1>
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;

        /// <summary>
        /// The first operand
        /// </summary>
        public A0 Arg0;

        /// <summary>
        /// The second operand
        /// </summary>
        public A1 Arg1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1,A2>
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;

        /// <summary>
        /// The first operand
        /// </summary>
        public A0 Arg0;

        /// <summary>
        /// The second operand
        /// </summary>
        public A1 Arg1;

        /// <summary>
        /// The third operand
        /// </summary>
        public A2 Arg2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiCall<A0,A1,A2,A3>
    {
        /// <summary>
        /// The operator class
        /// </summary>
        public ApiClass Class;

        /// <summary>
        /// The first operand
        /// </summary>
        public A0 Arg0;

        /// <summary>
        /// The second operand
        /// </summary>
        public A1 Arg1;

        /// <summary>
        /// The third operand
        /// </summary>
        public A2 Arg2;

        /// <summary>
        /// The fourth operand
        /// </summary>
        public A3 Arg3;
    }
}