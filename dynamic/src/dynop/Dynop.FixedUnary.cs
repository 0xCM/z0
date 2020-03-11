//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Dynop
    {       
        /// <summary>
        /// Creates a fixed 8-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 FixedUnaryOp<T>(this T dst, N8 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 FixedUnaryOp<T>(this T dst, N16 w, in AsmCode src)               
            where T : IBufferToken
                => dst.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 FixedUnaryOp<T>(this T dst, N32 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 FixedUnaryOp<T>(this T dst, N64 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 FixedUnaryOp<T>(this T dst, N128 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 FixedUnaryOp<T>(this T dst, N256 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src).AsFixedUnaryOp(w, src.Id);
    }
}