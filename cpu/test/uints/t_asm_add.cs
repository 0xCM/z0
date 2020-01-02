//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_asm_add : AsmOpTest<t_asm_add>
    {        

        public void add8i_check()
            => VerifyOp(AsmOps.Add<sbyte>(), math.add);

        public void add8i_bench()
            => add_bench<sbyte>();

        public void add8u_check()
            => VerifyOp(AsmOps.Add<byte>(), math.add);

        public void add8u_bench()
            => add_bench<byte>();

        public void add16i_check()
            => VerifyOp(AsmOps.Add<short>(), math.add);

        public void add16i_bench()
            => add_bench<short>();

        public void add16u_check()
            => VerifyOp(AsmOps.Add<ushort>(), math.add);

        public void add_asm16u_bench()
            => add_bench<ushort>();

        public void add32i_check()
            => VerifyOp(AsmOps.Add<int>(), math.add);

        public void add32i_bench()
            => add_bench<int>();

        public void add32u_check()
            => VerifyOp(AsmOps.Add<uint>(), math.add);

        public void add32u_bench()
            => add_bench<uint>();

        public void add64i_check()
            => VerifyOp(AsmOps.Add<long>(), math.add);

        public void add64i_bench()        
            => add_bench<long>();

        public void add64u_check()
            => VerifyOp(AsmOps.Add<ulong>(), math.add);

        public void add64u_bench()
            => add_bench<ulong>();

        public void add64f_check()
            => VerifyOp(AsmOps.Add<double>(), fmath.add);

        public void add_asm64f_bench()
            => add_bench<double>();

        void add_bench<T>(SystemCounter subject = default, SystemCounter compare = default)
            where T : unmanaged
        {
            var last = default(T);
            var asmop = AsmOps.Add<T>();
            
            for(var i=0; i<OpCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();                
                subject.Start();
                last = asmop(a,b);
                subject.Stop();

                compare.Start();
                last = gmath.add(a,b);
                compare.Stop();

            }

            ReportBenchmark($"add{moniker<T>()}_asm", OpCount,subject);
            ReportBenchmark($"add{moniker<T>()}", OpCount,compare);
        }


    }


}
