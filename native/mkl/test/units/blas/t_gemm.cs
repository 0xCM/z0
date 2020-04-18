//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Seed;
    using static Memories;
    
    public class t_gemm : UnitTest<t_gemm>
    {        
        /// <summary>
        /// Asserts that corresponding elements of two source spans of the same length are "close" as determined by a specified tolerance
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="tolerance">The acceptable difference between corresponding left/right elements</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>        
        public static void close<T>(Span<T> lhs, Span<T> rhs, T tolerance, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged 
        {
            for(var i = 0; i< Claim.length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                    throw AppErrors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        internal static void refmul<M,N,T>(Matrix256<M,N,T> A, Block256<N,T> B, Block256<M,T> X)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var m = nati<M>();
            for(var i = 0; i< m; i++)
                X[i] = t_dot.dot(A.GetRow(i), B);                    
        }

        public void dot()
        {
            var v1 = Random.VectorBlock<N256,double>();
            var v2 = Random.VectorBlock<N256,double>();

            var x = mkl.dot(v1,v2).Round(4);
            var y = Dot(v1,v2).Round(4);
            Claim.almost(x,y);
        }

        public void gemm8u()
        {
            gemm_check(Interval.closed((byte)0, (byte)byte.MaxValue));
        }

        
        public void gemm16u()
        {
            gemm_check(Interval.closed((ushort)0, ushort.MaxValue));
        }
        
        public void gemm32u()
        {
            gemm_check(Interval.closed(0u, 1024u));
        }

        public void gemm64i()
        {
            gemm_check(Interval.closed((long)-Pow2.T21, (long)Pow2.T21));
        }

        public void gemm64u()
        {
            gemm_check(Interval.closed(0ul, (ulong)Pow2.T21));
        }

        public void gemm32f()
        {
            gemm_check(Interval.closed(-1024f, 1024f),5f);
        }

        public void gemm64f()
        {
            gemm_check(Interval.closed(-(double)Pow2.T21, (double)Pow2.T21),2d);
        }

        void gemm32f_direct()
        {
            var src = Random.Stream(Interval.closed(-Pow2.T21, Pow2.T21)).Select(x => (float)x);

            gemm_direct_check<N64,N64,N64>(src);
            gemm_direct_check<N3, N3, N3>(src);
            gemm_direct_check<N3, N5, N4>(src);
            gemm_direct_check<N5, N5, N7>(src);
            gemm_direct_check<N10,N10,N10>(src);
            gemm_direct_check<N17,N3,N17>(src);
            gemm_direct_check<N2, N2, N2>(src);
            gemm_direct_check<N4, N4, N4>(src);
            gemm_direct_check<N8, N8, N8>(src);
            gemm_direct_check<N16,N16,N16>(src);
            gemm_direct_check<N32,N32,N32>(src);
        }

        void gemm64f_direct()
        {
            var src = Random.Stream(Interval.closed(-Pow2.T21, Pow2.T21)).Select(x => (double)x);

            gemm_direct_check<N64,N64,N64>(src);
            gemm_direct_check<N3, N3, N3>(src);
            gemm_direct_check<N3, N5, N4>(src);
            gemm_direct_check<N5, N5, N7>(src);
            gemm_direct_check<N10,N10,N10>(src);
            gemm_direct_check<N17,N3,N17>(src);
            gemm_direct_check<N2, N2, N2>(src);
            gemm_direct_check<N4, N4, N4>(src);
            gemm_direct_check<N8, N8, N8>(src);
            gemm_direct_check<N16,N16,N16>(src);
            gemm_direct_check<N32,N32,N32>(src);
        }

        void gemm_check<T>(Interval<T> domain,  T epsilon = default)
            where T : unmanaged
        {
            
            var src = Random.Stream(domain);
            gemm_check(src, epsilon, n64,  n64, n64);
            gemm_check(src, epsilon, n3,  n3, n3);
            gemm_check(src, epsilon, n3,  n5, n4);
            gemm_check(src, epsilon, n5,  n5, n7);
            gemm_check(src, epsilon, n10, n10, n10);
            gemm_check(src, epsilon, n17, n3, n17);
            gemm_check(src, epsilon, n2,  n2, n2);
            gemm_check(src, epsilon, n4,  n4, n4);
            gemm_check(src, epsilon, n8,  n8, n8);
            gemm_check(src, epsilon, n16, n16, n16);
            gemm_check(src, epsilon, n32, n32, n32);
        }
    
        BenchmarkRecord gemm_check<M,K,N,T>(IEnumerable<T> src, T epsilon = default, M m = default, K k = default, N n = default, bool trace = false)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged

        {
            var A = Matrix.blockalloc<M,K,T>();
            var B = Matrix.blockalloc<K,N,T>();
            var X = Matrix.blockalloc<M,N,T>();
            var XU = X.Unblocked;
            var E = Matrix.blockalloc<M,N,T>();
            var EU = E.Unblocked;
            var collect = false;
            var label = $"gemm<N{nati<M>()},N{nati<K>()},N{nati<N>()},{typeof(T).Name}>";

            var runtime = Duration.Zero;
            for(var i=0; i<CycleCount; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);                

                var sw = stopwatch();
                mkl.gemm(A, B, ref X);            
                runtime += snapshot(sw);
                
                Matrix.mul(A, B, ref E);

                if(trace)       
                {
                    var padlen = Int32.MinValue.ToString().Length + 2;
                    Notify($"X = {X.Format()}");
                    Notify($"E = {E.Format()}");
                }
                
                close(E.Unblocked, X.Unblocked, epsilon);
            }

            BenchmarkRecord timing = measured(CycleCount, runtime, label);
            
            if(collect)
                ReportBenchmark(label,CycleCount, TimeSpan.FromMilliseconds(runtime.Ms));
            return timing;
        }

        BenchmarkRecord gemm_direct_check<M,K,N>(IEnumerable<float> src, M m = default, K k = default, N n = default)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat

        {
            var A = Matrix.blockalloc<M,K,float>();
            var B = Matrix.blockalloc<K,N,float>();
            var X = Matrix.blockalloc<M,N,float>();
            var E = Matrix.blockalloc<M,N,float>();
            var collect = false;
        
            var runtime = Duration.Zero;
            for(var i=0; i<CycleCount; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A,B,ref X);            
                runtime += snapshot(sw);
            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            BenchmarkRecord timing = measured(CycleCount, runtime, label);

            if(collect)
                ReportBenchmark(label,CycleCount, TimeSpan.FromMilliseconds(runtime.Ms));
            return timing;
        }

        BenchmarkRecord gemm_direct_check<M,K,N>(IEnumerable<double> src, M m = default, K k = default, N n = default)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat

        {
            var A = Matrix.blockalloc<M,K,double>();
            var B = Matrix.blockalloc<K,N,double>();
            var X = Matrix.blockalloc<M,N,double>();
            var E = Matrix.blockalloc<M,N,double>();
            var collect = false;
        
            var runtime = Duration.Zero;
            for(var i=0; i<CycleCount; i++)
            {
                src.StreamTo(A.Unblocked);
                src.StreamTo(B.Unblocked);
                var sw = stopwatch();
                mkl.gemm(A,B,ref X);            
                runtime += snapshot(sw);
                
                Mul(A, B, ref E);
                Claim.require(E == X);

            }

            var label = $"gemm<{nati<M>()},{nati<K>()},{nati<N>()}>";
            var timing = measured(CycleCount, runtime, label);

            if(collect)
                ReportBenchmark(label,CycleCount, TimeSpan.FromMilliseconds(runtime.Ms));
            return timing;

        }

        BenchmarkRecord Gemv64<M,N>(IEnumerable<double> src, int cycles, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var A = Matrix.blockalloc<M,N,double>();
            var x = RowVector.blockalloc<N,double>();
            var y = RowVector.blockalloc<M,double>();
            var z = RowVector.blockalloc<M,double>();
            var sw = stopwatch(false);

            for(var i=0; i<cycles; i++)
            {
                src.StreamTo(A.Unsized);
                src.StreamTo(x.Unsized);
                src.StreamTo(y.Unsized);
                
                sw.Start();
                mkl.gemv(A,x, ref y);                
                sw.Stop();
                refmul(A,x,z);
                Claim.require(z == y);
            }

            var label = $"gemv<{nati<M>()},{nati<N>()},{typeof(double).DisplayName()}>";
            return measured(cycles, snapshot(sw), label);
        }

        static double Dot<N>(Block256<N,double> x, Block256<N,double> y)
            where N : unmanaged, ITypeNat
        {
            var result = 0d;
            for(var i=0; i< nati<N>(); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static float Dot<N>(Block256<N,float> x, Block256<N,float> y)
            where N : unmanaged, ITypeNat
        {
            var result = 0f;
            for(var i=0; i< nati<N>(); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static float Dot(Span<float> x, Span<float> y)
        {
            var result = 0f;
            for(var i=0; i< Claim.length(x,y); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static double Dot(Span<double> x, Span<double> y)
        {
            var result = 0d;
            for(var i=0; i< Claim.length(x,y); i++)
            {
                result += x[i]*y[i];
            }
            return result;
        }

        static ref Matrix256<M,N,float> Mul<M,K,N>(Matrix256<M,K,float> A, Matrix256<K,N,float> B, ref Matrix256<M,N,float> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i=0; i< m; i++)
            {
                var row = A.GetRow(i);                
                for(var j=0; j< n; j++)
                {
                    var col = B.GetCol(j);
                    X[i,j] = Dot(row,col);
                }
            }
            return ref X;
        }

        static ref Matrix256<M,N,double> Mul<M,K,N>(Matrix256<M,K,double> A, Matrix256<K,N,double> B, ref Matrix256<M,N,double> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i=0; i< m; i++)
            {
                var row = A.GetRow(i);                
                for(var j=0; j< n; j++)
                {
                    var col = B.GetCol(j);
                    X[i,j] = Dot(row,col);
                }
            }
            return ref X;
        }

        void GemmInt32Format()
        {
            var domain = Interval.closed(-32768, 32768);
            var n = n5;
            var m = n5;
            var m1 = Random.MatrixBlock(domain, m, n);
            var m2 = Random.MatrixBlock(domain, m, n);
            var m3 = Matrix.blockalloc(m,n,0);
            var m4 = mkl.gemm(m1,m2,ref m3);
        }
    }
}