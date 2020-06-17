//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class FixedOps
    {
        [MethodImpl(Inline)]
        static Fixed8 F8<T>(T src)
            where T : unmanaged
                => Fixed8.From(Cast.to<T,byte>(src));

        [MethodImpl(Inline)]
        static Fixed16 F16<T>(T src)
            where T : unmanaged
                => Fixed16.From(Cast.to<T,ushort>(src));

        [MethodImpl(Inline)]
        public static Fixed32 F32<T>(T src)
            where T : unmanaged
                => Fixed32.From(Cast.to<T,uint>(src));

        [MethodImpl(Inline)]
        public static Fixed64 F64<T>(T src)
            where T : unmanaged
                => Fixed64.From(Cast.to<T,ulong>(src));

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp8 fix<T>(Func<T,T> f, U8 dst)
            where T : unmanaged
                => (Fixed8 a) => F8(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp16 fix<T>(Func<T,T> f, U16 dst)
            where T : unmanaged
                => (Fixed16 a) => F16(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp32 fix<T>(Func<T,T> f, U32 dst)
            where T : unmanaged
                => (Fixed32 a) => F32(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryOp64 fix<T>(Func<T,T> f, U64 dst)
            where T : unmanaged
                => (Fixed64 a) => F64(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp8 fix<T>(Func<T,T,T> f, U8 dst)
            where T : unmanaged
                => (Fixed8 a, Fixed8 b) => F8(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp16 fix<T>(Func<T,T,T> f, U16 dst)
            where T : unmanaged
                => (Fixed16 a, Fixed16 b) => F16(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp32 fix<T>(Func<T,T,T> f, U32 dst)
            where T : unmanaged
                => (Fixed32 a, Fixed32 b) => F32(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryOp64 fix<T>(Func<T,T,T> f, U64 dst)
            where T : unmanaged
                => (Fixed64 a, Fixed64 b) => F64(f(a.As<T>(),b.As<T>()));                 
    }
}