//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    using static GXTypes;

    partial class GX
    {
        [MethodImpl(Inline)]
        public static Add<T> add<T>(T t = default)
            where T : unmanaged        
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>(T t = default)
            where T : unmanaged        
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static Mul<T> mul<T>(T t = default)
            where T : unmanaged        
                => Mul<T>.Op;

        [MethodImpl(Inline)]
        public static Div<T> div<T>(T t = default)
            where T : unmanaged        
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static ModOp<T> mod<T>(T t = default)
            where T : unmanaged        
                => ModOp<T>.Op;

        [MethodImpl(Inline)]
        public static ModMul<T> modmul<T>(T t = default)
            where T : unmanaged        
                => ModMul<T>.Op;

        [MethodImpl(Inline)]
        public static Even<T> even<T>(T t = default)
            where T : unmanaged        
                => Even<T>.Op;

        [MethodImpl(Inline)]
        public static Odd<T> odd<T>(T t = default)
            where T : unmanaged        
                => Odd<T>.Op;

        [MethodImpl(Inline)]
        public static Clamp<T> clamp<T>(T t = default)
            where T : unmanaged        
                => Clamp<T>.Op;

        [MethodImpl(Inline)]
        public static Square<T> square<T>(T t = default)
            where T : unmanaged        
                => Square<T>.Op;

        [MethodImpl(Inline)]
        public static Negate<T> negate<T>(T t = default)
            where T : unmanaged        
                => Negate<T>.Op;

        [MethodImpl(Inline)]
        public static Dec<T> dec<T>(T t = default)
            where T : unmanaged        
                => Dec<T>.Op;

        [MethodImpl(Inline)]
        public static Inc<T> inc<T>(T t = default)
            where T : unmanaged        
                => Inc<T>.Op;

        [MethodImpl(Inline)]
        public static Abs<T> abs<T>(T t = default)
            where T : unmanaged        
                => Abs<T>.Op;

        [MethodImpl(Inline)]
        public static Dist<T> dist<T>(T t = default)
            where T : unmanaged        
                => Dist<T>.Op;                 
    }

}