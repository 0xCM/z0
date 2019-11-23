//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class RngX
    {
        /// <summary>
        /// Produces a stochastic vector of *unspecified* length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        [MethodImpl(Inline)]
        public static void MarkovSpan<T>(this IPolyrand random, Span<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))                
                random.MarkovSpan(As.float32(dst));
            else if(typeof(T) == typeof(double))
                random.MarkovSpan(As.float64(dst));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Produces a stochastic vector of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        [MethodImpl(Inline)]
        public static VBlock256<T> MarkovBlock<T>(this IPolyrand random, int length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))                
                return random.MarkovBlock(length, 1f, length << 4).As<T>();
            else if(typeof(T) == typeof(double))
                return random.MarkovBlock(length, 1.0, length << 4).As<T>();
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Produces a stochastic vector of a natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<N,T> MarkovBlock<N,T>(this IPolyrand random)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = Z0.Vector.blockalloc<N, T>();
            random.MarkovSpan(dst.Unsized);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> MarkovBlock<N,T>(this IPolyrand random, ref VBlock256<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            random.MarkovSpan(dst.Unsized);
            return ref dst;
        }

        /// <summary>
        /// Allocates and populates a right-stochastic matrix, otherwise known as a Markov matrix;
        /// each row records a stocastic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rep"></param>
        /// <param name="dim"></param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T"></typeparam>
        public static MBlock256<N,T> MarkovSquare<N,T>(this IPolyrand random, T rep = default, N dim = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var data = DataBlocks.alloc<N,N,T>(n256);
            var n = nati<N>();
            for(int row=0; row < n; row++)
                random.MarkovSpan<T>(data.Slice(row*n, n));                            
            return Z0.Matrix.blockload<N,T>(data);
        }

        public static ref MBlock256<N,T> MarkovSquare<N,T>(this IPolyrand random, ref MBlock256<N,T> dst)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var data = dst.Unsized;
            var n = nati<N>();
            for(int row=0; row < n; row++)
                random.MarkovSpan<T>(data.Slice(row*n, n));                            
            return ref dst;
        }        

        /// Evaluates whether a square matrix is right-stochasitc, i.e. the sum of the entries
        /// in each row is equal to 1
        /// </summary>
        /// <param name="src">The matrix to evaluate</param>
        /// <param name="n">The natural dimension value</param>
        /// <typeparam name="N">The natural dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static bool IsRightStochastic<N,T>(this MBlock256<N,T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var tol = .001;
            var radius = closed(1 - tol,1 + tol);   
            for(var r = 0; r < (int)n.NatValue; r ++)
            {
                var row = src.Row(r);
                var sum =  convert<T,double>(mathspan.sum(row.Unsized));
                if(!radius.Contains(sum))
                    return false;
            }
            return true;
        }


        [MethodImpl(Inline)]
        static void MarkovSpan(this IPolyrand random, Span<float> dst)
        {            
            var length = dst.Length;
            random.Fill(closed(1.0f,length << 4), length, ref dst[0]);
            mathspan.fdiv(dst, dst.Avg()*length);
        }

        [MethodImpl(Inline)]
        static void MarkovSpan(this IPolyrand random, Span<double> dst)
        {            
            var length = dst.Length;
            random.Fill(closed(1.0, length << 4), length, ref dst[0]);
            mathspan.fdiv(dst, dst.Avg()*length);
        }

        [MethodImpl(Inline)]
        static VBlock256<float> MarkovBlock(this IPolyrand random, int length, float min, float max)
        {            
            var dst = DataBlocks.alloc<float>(n256, DataBlocks.blockcount<float>(n256,length));
            random.Fill(closed(min,max), length, ref dst[0]);
            mathspan.fdiv(dst.Data, dst.Avg() * length);
            return dst; 
        }

        [MethodImpl(Inline)]
        static VBlock256<double> MarkovBlock(this IPolyrand random, int length, double min, double max)
        {                        
            var dst = DataBlocks.alloc<double>(n256, DataBlocks.blockcount<double>(n256,length));
            random.Fill(closed(min,max), length, ref dst[0]);
            mathspan.fdiv(dst.Data, dst.Avg() * length);
            return dst; 
        }
    }
}