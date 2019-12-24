//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using D = GDel;
    
    public class t_add : t_gmath<t_add>
    {
        protected override int CycleCount => Pow2.T09;

        public void add_8i()
            => opcheck((x,y) => (sbyte)(x + y), D.add<sbyte>());

        public void add_8u()
            => opcheck((x,y) => (byte)(x + y), D.add<byte>());

        public void add_16i()
            => opcheck((x,y) => (short)(x + y), D.add<short>());

        public void add_16u()
            => opcheck((x,y) => (ushort)(x + y), D.add<ushort>());

        public void add_32i()
            => opcheck((x,y) => (x + y), D.add<int>());

        public void add_32u()
            => opcheck((x,y) => (x + y), D.add<uint>());

        public void add_64i()
            => opcheck((x,y) => (x + y), D.add<long>());

        public void add_64u()
            => opcheck((x,y) => (x + y), D.add<ulong>());

        public void add_32f()
            => VerifyOp((x,y) => (x + y), D.add<float>());

        public void add_64()
            => VerifyOp((x,y) => (x + y), D.add<double>());              


        public void add_g8i_bench()
            => gadd_bench<sbyte>();


        public void add_g8u_bench()
            => gadd_bench<byte>();


        public void add_g16i_bench()
        {
            gadd_bench<short>();
        }

        public void add_g16u_bench()
        {
            gadd_bench<ushort>();
        }

        public void add_g32i_bench()
        {
            gadd_bench<int>();
        }

        public void add_g32u_bench()
        {
            gadd_bench<uint>();
        }

        public void add_g64i_bench()
        {
            gadd_bench<long>();
        }

        public void add_g64u_bench()
        {
            gadd_bench<ulong>();
        }

        public void add_g32f_bench()
        {
            gadd_bench<float>();
        }

        public void add_g64f_bench()
        {
            gadd_bench<double>();
        }

        public void add_d32_baseline()
        {
            add_d32_bench();
        }

        public void add_ms32i_check()
        {
            var lhsSrc = Random.ReadOnlySpan<int>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Random.ReadOnlySpan<int>(lhsSrc.Length);
            mathspan.add(lhs, rhs);           

            var expect = span<int>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.yea(lhs.Identical(expect));
        }

        public void add_ms64i_check()
        {
            var lhsSrc = Random.ReadOnlySpan<long>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Random.ReadOnlySpan<long>(lhsSrc.Length);
            mathspan.add(lhs,rhs);

            var expect = span<long>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.yea(lhs.Identical(expect));
        }

        public void polyadd()
        {
            polyadd_check(MathOps.add<sbyte>());
            polyadd_check(MathOps.add<byte>());
            polyadd_check(MathOps.add<short>());
            polyadd_check(MathOps.add<ushort>());
            polyadd_check(MathOps.add<int>());
            polyadd_check(MathOps.add<uint>());
            polyadd_check(MathOps.add<long>());
            polyadd_check(MathOps.add<ulong>());
            polyadd_check(MathOps.add<float>());
            polyadd_check(MathOps.add<double>());            
        }
        
        public void polyadd_bench()
        {
            polyadd_bench(MathOps.add<sbyte>());
            polyadd_bench(MathOps.add<byte>());
            polyadd_bench(MathOps.add<short>());
            polyadd_bench(MathOps.add<ushort>());
            polyadd_bench(MathOps.add<int>());
            polyadd_bench(MathOps.add<uint>());
            polyadd_bench(MathOps.add<long>());
            polyadd_bench(MathOps.add<ulong>());
            polyadd_bench(MathOps.add<float>());
            polyadd_bench(MathOps.add<double>());
        }

        void polyadd_check<T>(IBinaryOp<T> op)
            where T : unmanaged
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var a = op.Invoke(x,y);
                var b = gmath.add(x,y);
                Claim.eq(a,b);
            }
        }

        void gadd_bench<T>(SystemCounter counter = default)
            where T : unmanaged
        {
            var last = gmath.zero<T>();
            for(var i = 0; i < OpCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                
                counter.Start();
                last = gmath.add(a,b);
                counter.Stop();
            }
            Benchmark($"add_g{moniker<T>()}", counter);

        }

        void add_d32_bench(SystemCounter counter = default)
        {
            var last = 0;
            for(var i = 0; i < OpCount; i++)
            {
                var a = Random.Next<int>();
                var b = Random.Next<int>();
                
                counter.Start();
                last = a + b;
                counter.Stop();
            }
            Benchmark($"add_d{moniker<int>()}", counter);
        }

        void polyadd_bench<T>(IBinaryOp<T> op, SystemCounter counter = default)
            where T : unmanaged
        {
            var sw = stopwatch(false);
            var last = default(T);
            for(var i=0; i< OpCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();

                counter.Start();
                last = op.Invoke(x,y);
                counter.Stop();
            }

            Benchmark($"polyadd_g{moniker<T>()}", counter);
        }
    }
}

