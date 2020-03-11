//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class Dynop
    {
        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 ToFixed8<T>(this Func<T,T> f)
            where T : unmanaged
                => (Fixed8 a) => Fixed8.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 ToFixed16<T>(this Func<T,T> f)
            where T : unmanaged
                => (Fixed16 a) => Fixed16.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 ToFixed32<T>(this Func<T,T> f)
            where T : unmanaged
                => (Fixed32 a) => Fixed32.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 ToFixed64<T>(this Func<T,T> f)
            where T : unmanaged
                => (Fixed64 a) => Fixed64.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 ToFixed128<T>(this Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => (Fixed128 a) =>f(a.ToVector<T>()).ToFixed();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 ToFixed256<T>(this Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Fixed256 a) => f(a.ToVector<T>()).ToFixed(); 
    }
}