//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vreverse<T>(Vector128<T> x)
            where T : unmanaged
                => vreverse_1(x);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vreverse<T>(Vector256<T> x)
            where T : unmanaged
                => vreverse_1(x);

        [MethodImpl(Inline)]
        static Vector256<T> vreverse_1<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vreverse(vcast8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vreverse(vcast16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vreverse(vcast32u(x)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vreverse(vcast64u(x)));
            else
                return vreverse_2(x);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vreverse_2<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vreverse(vcast8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vreverse(vcast16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vreverse(vcast32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vreverse(vcast64i(x)));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector128<T> vreverse_1<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vreverse(vcast8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vreverse(vcast16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vreverse(vcast32u(x)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vreverse(vcast64u(x)));
            else
                return vreverse_2(x);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vreverse_2<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vreverse(vcast8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vreverse(vcast16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vreverse(vcast32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vreverse(vcast64i(x)));
            else
                throw unsupported<T>();
        }
    }

}