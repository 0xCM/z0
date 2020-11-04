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

    [ApiHost(ApiNames.ApiSpecs, true)]
    public readonly struct ApiSpecs
    {
        /// <summary>
        /// Defines a call to a classified operation that accepts no arguments
        /// </summary>
        /// <typeparam name="A0">The first argument type</typeparam>
        [MethodImpl(Inline), Op]
        public static ApiCall call(ApiClass @class)
        {
            var call = new ApiCall();
            call.Class = @class;
            return call;
        }

        /// <summary>
        /// Defines a call to a classified operation that accepts 1 argument
        /// </summary>
        /// <typeparam name="A0">The first argument type</typeparam>
        [MethodImpl(Inline)]
        public static ApiCall<A0> call<A0>(ApiClass @class, A0 a0)
        {
            var call = new ApiCall<A0>();
            call.Class = @class;
            call.Arg0 = a0;
            return call;
        }

        /// <summary>
        /// Defines a call to a classified operation that accepts 2 arguments
        /// </summary>
        /// <typeparam name="A0">The first argument type</typeparam>
        /// <typeparam name="A1">The second argument type</typeparam>
        [MethodImpl(Inline)]
        public static ApiCall<A0,A1> call<A0,A1>(ApiClass @class, A0 a0, A1 a1)
        {
            var call = new ApiCall<A0,A1>();
            call.Class = @class;
            call.Arg0 = a0;
            call.Arg1 = a1;
            return call;
        }

        /// <summary>
        /// Defines a call to a classified operation that accepts 3 arguments
        /// </summary>
        /// <typeparam name="A0">The first argument type</typeparam>
        /// <typeparam name="A1">The second argument type</typeparam>
        /// <typeparam name="A2">The third argument type</typeparam>
        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,A2> call<A0,A1,A2>(ApiClass @class, A0 a0, A1 a1, A2 a2)
        {
            var call = new ApiCall<A0,A1,A2>();
            call.Class = @class;
            call.Arg0 = a0;
            call.Arg1 = a1;
            call.Arg2 = a2;
            return call;
        }

        /// <summary>
        /// Defines a call to a classified operation that accepts 4 arguments
        /// </summary>
        /// <typeparam name="A0">The first argument type</typeparam>
        /// <typeparam name="A1">The second argument type</typeparam>
        /// <typeparam name="A2">The third argument type</typeparam>
        /// <typeparam name="A3">The fourth argument type</typeparam>
        [MethodImpl(Inline)]
        public static ApiCall<A0,A1,A2,A3> call<A0,A1,A2,A3>(ApiClass @class, A0 a0, A1 a1, A2 a2, A3 a3)
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


    public struct ApiCallResult
    {
        public BinaryCode Content;
    }

    public struct ApiCallResult<R>
    {
        public R Content;
    }
}