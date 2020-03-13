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
                => dst.Load(src.BinaryCode).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 FixedUnaryOp<T>(this T dst, N16 w, in AsmCode src)               
            where T : IBufferToken
                => dst.Load(src.BinaryCode).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 FixedUnaryOp<T>(this T dst, N32 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src.BinaryCode).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 FixedUnaryOp<T>(this T dst, N64 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src.BinaryCode).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 FixedUnaryOp<T>(this T dst, N128 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src.BinaryCode).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 FixedUnaryOp<T>(this T dst, N256 w, in AsmCode src)
            where T : IBufferToken
                => dst.Load(src.BinaryCode).AsFixedUnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        static FixedDelegate AsFixedUnaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        static UnaryOp8 AsFixedUnaryOp(this IBufferToken buffer, N8 w, OpIdentity id)
            => (UnaryOp8)buffer.AsFixedUnaryOp(id, typeof(UnaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        static UnaryOp16 AsFixedUnaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (UnaryOp16)buffer.AsFixedUnaryOp(id, typeof(UnaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        static UnaryOp32 AsFixedUnaryOp(this IBufferToken buffer, N32 w, OpIdentity id)
            => (UnaryOp32)buffer.AsFixedUnaryOp(id, typeof(UnaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        static UnaryOp64 AsFixedUnaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (UnaryOp64)buffer.AsFixedUnaryOp(id, typeof(UnaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        static UnaryOp128 AsFixedUnaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (UnaryOp128)buffer.AsFixedUnaryOp(id, typeof(UnaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        static UnaryOp256 AsFixedUnaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (UnaryOp256)buffer.AsFixedUnaryOp(id, typeof(UnaryOp256), typeof(Fixed256));

    }
}