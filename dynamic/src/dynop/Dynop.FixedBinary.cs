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
        /// Loads source into the identifed buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The soruce to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedBinaryOp<F> LoadFixedBinaryOp<F>(this IBufferToken buffer, in ApiCode src)
            where F : unmanaged, IFixed
                => (FixedBinaryOp<F>)buffer.Load(src.Data).AsFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 LoadFixedBinaryOp<T>(this T buffer, N8 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src.BinaryCode).AsFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Presents an identified buffer as an 8-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        static BinaryOp8 AsFixedBinaryOp(this IBufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.AsFixedBinaryOp(id, typeof(BinaryOp8), typeof(Fixed8));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 LoadFixedBinaryOp<T>(this T buffer, N16 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src.BinaryCode).AsFixedBinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        static BinaryOp16 AsFixedBinaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (BinaryOp16)buffer.AsFixedBinaryOp(id, typeof(BinaryOp16), typeof(Fixed16));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 LoadFixedBinaryOp<T>(this T buffer, N32 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src.BinaryCode).AsFixedBinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        static BinaryOp32 AsFixedBinaryOp(this IBufferToken buffer,N32 w, OpIdentity id)
            => (BinaryOp32)buffer.AsFixedBinaryOp(id, typeof(BinaryOp32), typeof(Fixed32));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 LoadFixedBinaryOp<T>(this T buffer, N64 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src.BinaryCode).AsFixedBinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        static BinaryOp64 AsFixedBinaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.AsFixedBinaryOp(id, typeof(BinaryOp64), typeof(Fixed64));

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 LoadFixedBinaryOp<T>(this T buffer, N128 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src.BinaryCode).AsFixedBinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        static BinaryOp128 AsFixedBinaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.AsFixedBinaryOp(id, typeof(BinaryOp128), typeof(Fixed128));

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 LoadFixedBinaryOp<T>(this T buffer, N256 w, in AsmCode src)
            where T : IBufferToken
                => buffer.Load(src.BinaryCode).AsFixedBinaryOp(w, src.Id);  

        /// <summary>
        /// Presents an identified buffer as a 256-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        static BinaryOp256 AsFixedBinaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.AsFixedBinaryOp(id, typeof(BinaryOp256), typeof(Fixed256));

        [MethodImpl(Inline)]
        static FixedDelegate AsFixedBinaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id,functype:operatorType, result:operandType, args: array(operandType, operandType));
    }
}