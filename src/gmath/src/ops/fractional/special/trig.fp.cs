//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; using static Memories;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T sin<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sin(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sin(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T cos<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.cos(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.cos(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T tan<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.tan(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.tan(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T sinh<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.sinh(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.sinh(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T cosh<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.cosh(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.cosh(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T tanh<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.tanh(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.tanh(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T asin<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.asin(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.asin(float64(src)));
            else
                throw Unsupported.define<T>();
        }


        [MethodImpl(Inline)]
        public static T acos<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.acos(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.acos(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T atan<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.atan(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.atan(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T asinh<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.asinh(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.asinh(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T acosh<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.acosh(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.acosh(float64(src)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        public static T atanh<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.atanh(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.atanh(float64(src)));
            else
                throw Unsupported.define<T>();
        }
    }
}