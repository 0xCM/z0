//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static z;
    using static Checks;

    using static CheckBitMasksStep;

    [Step]
    public readonly struct CheckBitMasksStep : IWfStep<CheckBitMasksStep>
    {
        public static WfStepId StepId
            => AB.step<CheckBitMasksStep>();
    }

    [ApiHost]
    public ref struct CheckBitMasks
    {
        readonly StringBuilder Log;

        readonly IWfShell Wf;

        uint SuccessCount;

        uint FailureCount;

        public Pair<uint> Counts;

        readonly IPolyrand Random;

        public CheckBitMasks(IWfShell wf, IPolyrand random, StringBuilder log)
        {
            Wf = wf;
            Log = log;
            SuccessCount = 0;
            FailureCount = 0;
            Counts = default;
            Random = random;
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);

            Check(base2);
            Counts = (SuccessCount,FailureCount);

            Wf.Ran(StepId, Counts);

        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        void Check(Base2 @base)
        {
            Check(@base, z8);
            Check(@base, z16);
            Check(@base, z32);
            Check(@base, z64);
        }

        [Op, Closures(UnsignedInts)]
        void Check<T>(Base2 @base, T t = default)
            where T : unmanaged
        {
            var literals = Literals.attributed<T>(@base, typeof(MaskLiterals));
            var masks = literals.ToArray();
            foreach(var m in masks)
            {
                var bits = BitSpans.parse(m.Text);
                var bitval = bits.Convert<T>();
                var ok = gmath.eq(bitval,m.Data);

                if(ok)
                    SuccessCount++;
                else
                    FailureCount++;

                var sym = ok ? "==" : "!=";
                var title = ok ? "Success" : "Failure";
                var normalized = BitString.normalize(m.Text);
                var bs = BitString.scalar(m.Data);
                var expr = text.format("{0} {1} {2}", normalized, sym, bs);
                var description = text.format("{0} | {1} | {2}", title, m.Name, expr);
                Log.AppendLine(description);
            }
        }

        [Op]
        public void lomask_case1()
        {
            eq((Pow2.pow(3) - 1)^Pow2.pow(3), lo64(3));
            eq((Pow2.pow(7) - 1)^Pow2.pow(7), lo64(7));
            eq((Pow2.pow(13) - 1)^Pow2.pow(13), lo64(13));
            eq((Pow2.pow(25) - 1)^Pow2.pow(25), lo64(25));
            eq((Pow2.pow(59) - 1)^Pow2.pow(59), lo64(59));
        }

        [Op]
        public void lomask_case2()
        {
            eq(4u, Bits.pop(lo64(3)));
            eq(7u, Bits.pop(lo64(6)));
            eq(13u, Bits.pop(lo64(12)));
            eq(25u, Bits.pop(lo64(24)));
            eq(59u, Bits.pop(lo64(58)));
        }

        public void lomask_case3()
        {
            var lomask = BitMasks.lo<uint>(6);
            var himask = BitMasks.hi<uint>(8);
            var src = uint.MaxValue;
            var dst = gmath.xor(gmath.xor(src,lomask), himask);
            eq(7u, gbits.ntz(dst));
            eq(8u, (uint)gbits.nlz(dst));

            eq(7u, Bits.pop(BitMasks.lo<uint>(6)));
            eq(12u, Bits.pop(BitMasks.lo<uint>(11)));
        }

        [Op]
        public void himask_8u()
            => check_himask(z8);

        [Op]
        public void himask_16u()
            => check_himask(z16);

        [Op]
        public void himask_32u()
            => check_himask(z32);

        [Op]
        public void himask_64u()
            => check_himask(z64);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        void check_himask<T>(T t = default)
            where T : unmanaged
        {
            var mincount = (byte)1;
            var maxcount = (byte)bitsize<T>();
            for(var i=0; i<Reps; i++)
            {
                var count = Random.One(mincount,maxcount);
                var mask = BitMasks.hi(count,t);
                var pop = gbits.pop(mask);
                if(pop != count)
                {
                    pair("count", count.ToString());
                    pair("popcount", pop.ToString());
                    pair("mask", BitString.scalar(mask).Format());
                }

                eq(count, gbits.pop(mask));

                var lowered = gmath.srl(mask, (byte)(bitsize(t) -  count));
                var width = gbits.effwidth(lowered);
                if(count != width)
                {
                    pair("mask", BitString.scalar(mask).Format());
                    pair("lowered", BitString.scalar(lowered).Format());
                }
                eq(count, width);
            }
        }
    }
}