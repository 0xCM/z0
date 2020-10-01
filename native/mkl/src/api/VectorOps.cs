//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Mkl;

    using static Konst;
    using static z;

    public static class VectorOps
    {
        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Block256<N,T> Add<N,T>(in Block256<N,T> x, in Block256<N,T> y, ref Block256<N,T> z)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
            {
                var dst = z.As<float>();
                mkl.add(x.As<float>(), y.As<float>(), ref dst);
            }
            else if(typeof(T) == typeof(double))
            {
                var dst = z.As<double>();
                mkl.add(x.As<double>(), y.As<double>(), ref dst);
            }
            else
                throw no<T>();

            return ref z;
        }


        [MethodImpl(Inline)]
        public static T Dot<N,T>(Block256<N,T> x, Block256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(mkl.dot(x.As<float>(), y.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(mkl.dot(x.As<double>(), y.As<double>()));
            else
                return gspan.dot<T>(x.Unsized, y.Unsized);
        }
    }
}