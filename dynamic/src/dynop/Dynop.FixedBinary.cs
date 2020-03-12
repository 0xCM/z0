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
        public static FixedBinaryOp<F> FixedBinaryOp<F>(this IBufferToken buffer, in AsmCode src)
            where F : unmanaged, IFixed
                => buffer.EmitFixedBinaryOp<F>(src);

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 FixedBinaryOp<T>(this T buffer, N8 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src).AsFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 FixedBinaryOp<T>(this T buffer, N16 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src).AsFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 FixedBinaryOp<T>(this T buffer, N32 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src).AsFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 FixedBinaryOp<T>(this T buffer, N64 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src).AsFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 FixedBinaryOp<T>(this T buffer, N128 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src).AsFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 FixedBinaryOp<T>(this T buffer, N256 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src).AsFixedBinaryOp(w, src.Id);  
    }
}