//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class mathspan
    {
        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        public static T dot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            var dst = default(T);
            for(var i = 0; i< len; i++)
                dst = gmath.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        public static float dot(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(float);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static double dot(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(double);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

    }

}