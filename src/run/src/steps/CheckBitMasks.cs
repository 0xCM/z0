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
    using static CheckBitMasksStep;


    [Step(typeof(CheckBitMasks))]
    public readonly struct CheckBitMasksStep : IWfStep<CheckBitMasksStep>
    {
        public const string StepName = nameof(CheckBitMasks);

        public static WfStepId StepId => AB.step<CheckBitMasksStep>();
    }

    public ref struct CheckBitMasks
    {
        readonly StringBuilder Log;

        readonly IWfContext Wf;

        uint SuccessCount;

        uint FailureCount;

        public Pair<uint> Counts;

        public CheckBitMasks(IWfContext wf, StringBuilder log)
        {
            Wf = wf;
            Log = log;
            SuccessCount = 0;
            FailureCount = 0;
            Counts = default;
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

        void Check<T>(Base2 @base, T t = default)
            where T : unmanaged
        {
            var literals = Literals.attributed<T>(@base, typeof(BitMasks));
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
    }
}