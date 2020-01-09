//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;
    public abstract class AsmOpTest<U> : UnitTest<U>, IDisposable
        where U : AsmOpTest<U>
    {
        protected override int RepCount => Pow2.T12;

        protected override int CycleCount => Pow2.T08;

        public virtual void Dispose()
        {

        }

        protected virtual string OpName 
            => "anon";

        protected virtual FolderName AsmFolder
            => FolderName.Empty;

        protected Moniker TestOpMoniker(PrimalKind kind)
            => Moniker.define($"{OpName}_asm",kind);

        protected Moniker RefOpName<T>(T t = default)
            where T : unmanaged
                => moniker<T>(OpName);

        protected Moniker TestOpName<T>(T t = default)
            where T : unmanaged
                => TestOpMoniker(Classified.primalkind<T>());

        protected static AsmCode ReadAsm(FolderName folder, Moniker m)
            => AsmLib.Read(folder, m);

        protected static AsmCode ReadAsm(FolderName folder, string opname, PrimalKind kind)
            => AsmLib.Read(folder, Moniker.define(opname,kind));


        protected AsmCode ReadAsm(Moniker m)
            => ReadAsm(AsmFolder, m);

        protected AsmCode ReadAsm(PrimalKind kind)
            => ReadAsm(AsmFolder, OpName, kind);

        protected AsmCode<T> ReadAsm<T>(T t = default)
            where T : unmanaged
                => new AsmCode<T>(ReadAsm(AsmFolder, OpName, typeof(T).Kind()));

        protected void CheckMatch<T>(BinaryOp<Vector128<T>> f, BinaryOp128 g)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                Claim.eq(f(x,y), g.Apply(x,y));
            }            
        }

        protected void CheckMatch<T>(BinaryOp<Vector256<T>> f, BinaryOp256 g)
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(w,t);
                var y = Random.CpuVector(w,t);
                Claim.eq(f(x,y), g.Apply(x,y));
            }            
        }

        protected void RunBench<T>(UnaryOp<T> f, UnaryOp<T> cf, SystemCounter clock = default)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            
            void run_f()
            {
                var src = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref skip(src,j);
                    last = f(x);
                }
                clock.Stop();

                ReportBenchmark(TestOpName<T>(),oc,clock);

            }

            void run_cf()
            {
                var src = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref skip(src,j);
                    last = cf(x);
                }            
                clock.Stop();

                ReportBenchmark(RefOpName<T>(),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        }

        protected void RunBench<T>(BinaryOp<T> cf, BinaryOp<T> f, SystemCounter clock = default)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            
            void run_f()
            {
                var lhs = Random.Span<T>(SampleSize);
                var rhs = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref skip(lhs,j);
                    ref readonly var y = ref skip(rhs,j);                
                    last = f(x,y);
                }
                clock.Stop();

                ReportBenchmark(TestOpName<T>(),oc,clock);

            }

            void run_cf()
            {
                var lhs = Random.Span<T>(SampleSize);
                var rhs = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref skip(lhs,j);
                    ref readonly var y = ref skip(rhs,j);                
                    last = cf(x,y);
                }            
                clock.Stop();

                ReportBenchmark(RefOpName<T>(),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();

        }

        /// <summary>
        /// Evaluates a pair of binary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        protected void CheckMatch<T>(BinaryOp<T> f, BinaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName(TestOpName<T>()));
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
            using var buffer = AsmExecBuffer.Create();            
            var g = buffer.BinOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName(asm.Name));
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f,asm.Untyped);
        
        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
            using var buffer = AsmExecBuffer.Create();            
            var g = buffer.UnaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, CaseName(asm.Name));
        }

        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f, asm.Untyped);

        /// <summary>
        /// Evaluates a pair of unary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        protected void CheckMatch<T>(UnaryOp<T> f, UnaryOp<T> g)
            where T :unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, CaseName(TestOpName<T>()));
        }
    
    }
}