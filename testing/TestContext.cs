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

    public interface ITestContext : IContext
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        IEnumerable<OpTime> Benchmarks {get;}        
    }

    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        public TestContext(ITestConfig config = null, IPolyrand random = null)
            : base(random ?? Rng.XOrShift1024(Seed1024.TestSeed).ToPolyrand())
        {
            this.Config = config ?? TestConfigDefaults.Default();
        }

        protected static readonly N256 DefaultSampleNat = default;

        /// <summary>
        /// The default number of elements to be selected from some sort of stream
        /// </summary>
        protected const int DefaultSampleSize = Pow2.T08;

        /// <summary>
        /// The default number times to repeat an activity
        /// </summary>
        protected const int DefaltCycleCount = Pow2.T03;

        /// <summary>
        /// The default number times to repeat a cycle
        /// </summary>
        protected const int DefaultRoundCount = Pow2.T01;

        /// <summary>
        /// The default rouding precision
        /// </summary>
        protected const int DefaultScale = 6;

        public ITestConfig Config {get; private set;}

        public void Configure(ITestConfig config)
            => Config = config;

       protected K[] RandArray<K>(bool nonzero = false)
            where K : unmanaged
        {
            var config = Config.Get<K>();
             return nonzero 
                ? Random.NonZeroArray<K>(config.SampleSize, SampleDomain<K>())                
                : Random.Array<K>(config.SampleSize, SampleDomain<K>());
        }

        protected void Verify(Action a)
        {
            for(var i=0; i< CycleCount; i++)
                a();
        }

        protected override bool TraceEnabled
            => Config.TraceEnabled;

        protected virtual Interval<K> SampleDomain<K>()
            where K : unmanaged
                => RngDefaults.get<K>().SampleDomain;
                
        /// <summary>
        /// The number of elements to be selected from some sort of stream
        /// </summary>
        protected virtual int SampleSize
            => DefaultSampleSize;
        
        /// <summary>
        /// The number times to repeat an action
        /// </summary>
        protected virtual int CycleCount
            => DefaltCycleCount;

        /// <summary>
        /// The number of times to repeat a cycle
        /// </summary>
        protected virtual int RoundCount
            => DefaultRoundCount;

        /// <summary>
        /// The number of operations performed in a benchmarking expercise
        /// </summary>
        protected virtual int OpCount
            => RoundCount*CycleCount;

        /// <summary>
        /// Specifies the number of decimal places that relevant for some purpose
        /// </summary>
        protected virtual int Scale
            => DefaultScale;
        
        protected virtual Interval<byte> ShiftRange<K>()
            where K : unmanaged
        {
            var offsetMin = (byte)1;
            var offsetMax = (byte)(bitsize<K>() - 2);
            return closed(offsetMin,offsetMax);                
        }

        protected void Benchmark(string opname,TimeSpan time)
        {
            Collect((OpCount, time, opname));
        }

        protected void Benchmark(string opname, TimeSpan time, int opcount)
        {
            Collect((opcount, time, opname));
        }

        protected void RunBench<K>(Func<K,K,long,SystemCounter,OpTime> benchmark, K? s0 = null, K? s1 = null)
            where K : unmanaged
        {
            var a = s0 ?? Random.Next<K>();
            var b = s1 ?? Random.Next<K>();
            var counter = SystemCounter.New();
            Collect(benchmark(a,b,OpCount,counter));
        }


        /// <summary>
        /// Collects benchmark stats for worker that processes a sample array
        /// </summary>
        /// <param name="min">The minimum operand value</param>
        /// <param name="max">The maximum operand value</param>
        /// <param name="oplabel">The name of the operation, excluding type info</param>
        /// <param name="worker">The sample processor to be measured</param>
        /// <typeparam name="K">The primal operand type</typeparam>
        protected OpTime Benchmark<K>(Action<K[]> worker, string oplabel,  K min, K max)
            where K : unmanaged
        {
            var buffer = new K[SampleSize];
            var sw = stopwatch(false);
            for(var round = 0; round < RoundCount; round++)
            {
                for(var cycle=0; cycle < CycleCount; cycle++)
                {                
                    Random.Fill((min,max), buffer.Length, ref buffer[0]);

                    sw.Start();
                    worker(buffer);
                    sw.Stop();
                }
            }
            
            var opname = oplabel + angled(type<K>().DisplayName());  
            OpTime timing = (SampleSize*CycleCount*RoundCount, sw, opname);          
            Collect(timing);
            return timing;
        }

        /// <summary>
        /// Collects benchmark stats for worker that processes a sample array
        /// </summary>
        /// <param name="oplabel">The name of the operation, excluding type info</param>
        /// <param name="worker">The sample processor to be measured</param>
        /// <param name="domain">The sample domain, if specified</param>
        /// <typeparam name="K">The primal operand type</typeparam>
        protected OpTime Benchmark<K>(Action<K[]> worker, string oplabel)
            where K : unmanaged
        {
            var bounds = Interval<K>.Full;
            return Benchmark(worker, oplabel, bounds.Left, bounds.Right);
        }


        protected void opcheck<K>(UnaryOp<K> baseline, UnaryOp<K> subject) 
            where K : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<K>();
                var x = baseline(a);
                var y = subject(a);
                Claim.eq(x,y);

            }
        }

        protected void opcheck<K>(BinaryOp<K> baseline, BinaryOp<K> subject) 
            where K : unmanaged
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<K>();
                var b = Random.Next<K>();
                var x = baseline(a,b);
                var y = subject(a,b);
                Claim.eq(x,y);

            }
        }

        protected void VerifyOp<K>(UnaryOp<K> subject, UnaryOp<K> baseline, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : unmanaged
        {
            var src = RandArray<K>(nonzero);
            var timing = stopwatch();                        

            for(var i = 0; i<src.Length; i++)
                Claim.eq(baseline(src[i]), subject(src[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, UnaryOp<K> subject, UnaryOp<K> baseline, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : unmanaged
        {
            var src = RandArray<K>(nonzero);
            var timing = stopwatch();                        

            for(var i = 0; i<src.Length; i++)
                Claim.eq(baseline(src[i]),subject(src[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(BinaryPred<K> baseline, BinaryPred<K> op, bool nonzero = false, 
            [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : unmanaged
        {
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();            

            for(var i = 0; i<len; i++)
                Claim.eq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }


        protected void VerifyOp<K>(BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : unmanaged
        {
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void VerifyOp<K>(OpKind opKind, BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where K : unmanaged
        {
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

        protected void TypeCaseStart<C>([CallerMemberName] string caller = null)
            => Notify(AppMsg.Define($"{typename<T>()}/{caller}<{typename<C>()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<C>([CallerMemberName] string caller = null)
            => Notify(AppMsg.Define($"{typename<T>()}/{caller}<{typename<C>()}> succeeded", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<C>(AppMsg msg, [CallerMemberName] string caller = null)
            => Notify(AppMsg.Define($"{typename<T>()}/{caller}<{typename<C>()}> succeeded: {msg}", SeverityLevel.HiliteCL));

        protected void TypeCaseStart<A,B>([CallerMemberName] string caller = null)
            => Notify(AppMsg.Define($"{typename<T>()}/{caller}<{typeof(A).DisplayName()},{typeof(B).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<A,B>([CallerMemberName] string caller = null)
            => Notify(AppMsg.Define($"{typename<T>()}/{caller}<{typeof(A).DisplayName()},{typeof(B).DisplayName()}> succeeded", SeverityLevel.HiliteCL));

        protected void NatCaseStart<N,A>([CallerMemberName] string caller = null)
            where N : unmanaged, ITypeNat
            => Notify(AppMsg.Define($"{typename<T>()}/{caller}<N{nati<N>()},{typeof(A).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseStart<M,N,S>([CallerMemberName] string caller = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where S : unmanaged
                => Notify(AppMsg.Define($"{typeof(T).DisplayName()}/{caller}<N{nati<M>()}xN{nati<N>()}:{typeof(S).DisplayName()}> executing", SeverityLevel.HiliteCL));

        protected void TypeCaseEnd<M,N,S>([CallerMemberName] string caller = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where S : unmanaged
                => Notify(AppMsg.Define($"{typeof(T).Name}/{caller}<N{nati<M>()}xN{nati<N>()}:{typeof(S).DisplayName()}> succeeded", SeverityLevel.HiliteCL));
    }
}