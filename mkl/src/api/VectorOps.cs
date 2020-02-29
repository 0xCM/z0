//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using Z0.Mkl;

    using static Root;
    using static As;

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
        public static ref RowVector256<N,T> Add<N,T>(in RowVector256<N,T> x, in RowVector256<N,T> y, ref RowVector256<N,T> z)
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
                throw unsupported<T>();

            return ref z;
        }


        [MethodImpl(Inline)]
        public static T Dot<N,T>(RowVector256<N,T> x, RowVector256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(mkl.dot(x.As<float>(), y.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(mkl.dot(x.As<double>(), y.As<double>()));
            else
                return mathspan.dot<T>(x.Unsized, y.Unsized);                
        }        
    }
}