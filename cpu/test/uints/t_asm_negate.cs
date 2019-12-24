//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_asm_negate : AsmOpTest<t_asm_negate>
    {        

        public void negate_asm_8i()
        {
            VerifyOp(AsmOps.Negate<sbyte>(), math.negate);
        }

        public void negate_asm_8u()
        {
            VerifyOp(AsmOps.Negate<byte>(), math.negate);
        }

        public void negate_asm_16i()
        {
            VerifyOp(AsmOps.Negate<short>(), math.negate);
        }

        public void negate_asm_16u()
        {
            VerifyOp(AsmOps.Negate<ushort>(), math.negate);
        }

        public void negate_asm_32i()
        {
            VerifyOp(AsmOps.Negate<int>(), math.negate);
        }

        public void negate_asm_32u()
        {
            VerifyOp(AsmOps.Negate<uint>(), math.negate);            
        }

        public void negate_asm_64i()
        {
            VerifyOp(AsmOps.Negate<long>(), math.negate);
        }

        public void negate_asm_64u()
        {
            VerifyOp(AsmOps.Negate<ulong>(), math.negate);
        }

        public void negate_asm64f()
        {
            VerifyOp(AsmOps.Negate<float>(), math.negate);
            VerifyOp(AsmOps.Negate<double>(), math.negate);
        }



        void negate_bench<T>(SystemCounter subject = default, SystemCounter compare = default)
            where T : unmanaged
        {
            var last = default(T);
            var asmop = AsmOps.Negate<T>();
            
            for(var i=0; i<OpCount; i++)
            {
                var a = Random.Next<T>();
                subject.Start();
                last = asmop(a);
                subject.Stop();

                var b = Random.Next<T>();                
                compare.Start();
                last = gmath.negate(b);
                compare.Stop();

            }

            ReportBenchmark($"negate{moniker<T>()}_asm", OpCount, subject);
            ReportBenchmark($"negate{moniker<T>()}", OpCount,compare);

        }

    }

}
