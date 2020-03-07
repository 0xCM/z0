//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;

    using static Root;
    using static FKT;

    partial class Dynop
    {

        [MethodImpl(Inline)]
        public static FixedFunc<T,T> FixedUnaryOp<T>(this BufferToken buffer, in AsmCode src)
            where T : unmanaged, IFixed 
                => buffer.LoadFixed<T,T>(src);
       
        [MethodImpl(Inline)]
        public static UnaryOp<T> FixedUnaryOp<T>(this BufferToken buffer, in AsmCode<T> src)
            where T : unmanaged
                => buffer.Load(src).FixedUnaryAdapter<T>(src.Id);

        /// <summary>
        /// Creates a fixed 8-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp8 FixedUnaryOp(this BufferToken buffer, N8 w, in AsmCode src)
            => buffer.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp16 FixedUnaryOp(this BufferToken buffer, N16 w, in AsmCode src)               
            => buffer.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp32 FixedUnaryOp(this BufferToken buffer, N32 w, in AsmCode src)
            => buffer.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp64 FixedUnaryOp(this BufferToken buffer, N64 w, in AsmCode src)
            => buffer.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 FixedUnaryOp(this BufferToken buffer, N128 w, in AsmCode src)
            => buffer.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp256 FixedUnaryOp(this BufferToken buffer, N256 w, in AsmCode src)
            => buffer.Load(src).AsFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 FixedUnaryOp<T>(this Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => (Fixed128 a) =>f(a.ToVector<T>()).ToFixed();

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp256 FixedUnaryOp<T>(this Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Fixed256 a) =>f(a.ToVector<T>()).ToFixed();
    }
}