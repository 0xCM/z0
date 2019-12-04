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
        protected override int CycleCount => Pow2.T16;

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
            polyadd_check(SDel.add<sbyte>());
            polyadd_check(SDel.add<byte>());
            polyadd_check(SDel.add<short>());
            polyadd_check(SDel.add<ushort>());
            polyadd_check(SDel.add<int>());
            polyadd_check(SDel.add<uint>());
            polyadd_check(SDel.add<long>());
            polyadd_check(SDel.add<ulong>());
            polyadd_check(SDel.add<float>());
            polyadd_check(SDel.add<double>());            
        }
        
        public void polyadd_bench()
        {
            polyadd_bench(SDel.add<sbyte>());
            polyadd_bench(SDel.add<byte>());
            polyadd_bench(SDel.add<short>());
            polyadd_bench(SDel.add<ushort>());
            polyadd_bench(SDel.add<int>());
            polyadd_bench(SDel.add<uint>());
            polyadd_bench(SDel.add<long>());
            polyadd_bench(SDel.add<ulong>());
            polyadd_bench(SDel.add<float>());
            polyadd_bench(SDel.add<double>());
        }

        void polyadd_check<T>(IBinaryOp<T> op)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                var a = op.apply(x,y);
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
                last = op.apply(x,y);
                counter.Stop();
            }

            Benchmark($"polyadd_g{moniker<T>()}", counter);
        }
    }
}

