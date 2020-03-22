//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static NumericKinds;

    partial class Fixed
    {
        [MethodImpl(Inline)]
        public static F fix<T,F>(T src)
            where F : unmanaged, IFixed
            where T : unmanaged        
                => Unsafe.As<T,F>(ref src);

        [MethodImpl(Inline)]
        public static T unfix<F,T>(F src)
            where F : unmanaged, IFixed
            where T : unmanaged        
                => Unsafe.As<F,T>(ref src);

        [MethodImpl(Inline)]
        public static BinaryOp<F> fix<F,T>(BinaryOp<T> f,  F t = default)            
            where F : unmanaged, IFixed
            where T : unmanaged
                => (F a, F b) => fix<T,F>(f(unfix<F,T>(a),unfix<F,T>(b)));
        
        [MethodImpl(Inline)]
        public static BinaryOp<T> unfix<F,T>(BinaryOp<F> f,  T t = default)            
            where F : unmanaged, IFixed
            where T : unmanaged
                => (T a, T b) => unfix<F,T>(f(fix<T,F>(a), fix<T,F>(b)));

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static UnaryOp8 fix<T>(Func<T,T> f, U8 dst)
            where T : unmanaged
                => (Fixed8 a) => Fixed8.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static UnaryOp16 fix<T>(Func<T,T> f, U16 dst)
            where T : unmanaged
                => (Fixed16 a) => Fixed16.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static UnaryOp32 fix<T>(Func<T,T> f, U32 dst)
            where T : unmanaged
                => (Fixed32 a) => Fixed32.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static UnaryOp64 fix<T>(Func<T,T> f, U64 dst)
            where T : unmanaged
                => (Fixed64 a) => Fixed64.From(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BinaryOp8 fix<T>(Func<T,T,T> f, U8 dst)
            where T : unmanaged
                => (Fixed8 a, Fixed8 b) => Fixed8.From(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BinaryOp16 fix<T>(Func<T,T,T> f, U16 dst)
            where T : unmanaged
                => (Fixed16 a, Fixed16 b) => Fixed16.From(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BinaryOp32 fix<T>(Func<T,T,T> f, U32 dst)
            where T : unmanaged
                => (Fixed32 a, Fixed32 b) => Fixed32.From(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BinaryOp64 fix<T>(Func<T,T,T> f, U64 dst)
            where T : unmanaged
                => (Fixed64 a, Fixed64 b) => Fixed64.From(f(a.As<T>(),b.As<T>()));                 
   }
}