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

        protected Moniker TestOpMoniker(NumericKind kind)
            => OpIdentities.define($"{OpName}_asm",kind);

        protected Moniker TestOpName<T>(T t = default)
            where T : unmanaged
                => TestOpMoniker(NumericType.kind<T>());

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

        /// <summary>
        /// Evaluates a pair of binary operators and asserts their equality over a random sequence
        /// </summary>
        /// <param name="f">The first operator, often interpreted as the reference implementation</param>
        /// <param name="g">The second operator, often interpreted as the operator under test</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operator domain type</typeparam>
        protected void CheckMatch<T>(string opname, BinaryOp<T> f, BinaryOp<T> g)
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
            using var buffer = NativeServices.ExecBuffer();
            var g = buffer.BinaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName(asm.Id));
        }

        protected void CheckAsmMatch<T>(BinaryOp<T> f, AsmCode<T> asm)
            where T : unmanaged
                => CheckAsmMatch(f,asm.Untyped);
        
        protected void CheckAsmMatch<T>(UnaryOp<T> f, AsmCode asm)
            where T : unmanaged
        {
            using var buffer = NativeServices.ExecBuffer();
            var g = buffer.UnaryOp(asm.As<T>());

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    Claim.eq(f(x),g(x));
                }
            }

            CheckAction(check, CaseName(asm.Id));
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