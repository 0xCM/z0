//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct CheckVectorServices : ICheckVectorServices
    {        
        public ITestContext Context {get;}

        public ICheckSFCells Decomposer {get;}

        [MethodImpl(Inline)]
        public static ICheckVectorServices Create(ITestContext context, ICheckSFCells decomposer)
            => new CheckVectorServices(context, decomposer);
    
        [MethodImpl(Inline)]
        CheckVectorServices(ITestContext context, ICheckSFCells decomposer)
        {
            this.Context = context;
            this.Decomposer = decomposer;
        }
    }

    public interface ICheckVectorServices : ICheckVectors, ICheckAction, ITestRandom, ITestService, ICheckSFCells
    {
        ICheckSFCells Decomposer {get;}

        [MethodImpl(Inline)]
        void ISink<TestCaseRecord>.Deposit(TestCaseRecord src)
            => Context.Deposit(src);

        /// <summary>
        /// Verifies that a vectorized pattern source produces the expected pattern
        /// </summary>
        /// <param name="f">The pattern source</param>
        /// <param name="expect">The expected pattern</param>
        /// <typeparam name="F">The pattern source type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        void CheckPattern<F,T>(F f, Vector128<T> expect)
            where T : unmanaged
            where F : ISVPatternSource128Api<T>
        {
            void exec()
            {
                var actual = f.Invoke();
                eq(expect,actual);
            }

            CheckAction(exec, CaseName(f));            
        }

        /// <summary>
        /// Verifies that a vectorized pattern source produces the expected pattern
        /// </summary>
        /// <param name="f">The pattern source</param>
        /// <param name="expect">The expected pattern</param>
        /// <typeparam name="F">The pattern source type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        void CheckPattern<F,T>(F f, Vector256<T> expect)
            where T : unmanaged
            where F : ISVPatternSource256Api<T>
        {
            void exec()
            {
                var actual = f.Invoke();
                eq(expect,actual);
            }
            
            CheckAction(exec, CaseName(f));            
        }


        /// <summary>
        /// Verifies the correct function of a vectorized factory operator
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="f">The factory operator to verify</param>
        /// <param name="check">The adjudication operator</param>
        /// <param name="s">A factory input type representative</param>
        /// <param name="t">A target vector component type representative</param>
        /// <typeparam name="F">The factory type</typeparam>
        /// <typeparam name="C">The check operator type</typeparam>
        /// <typeparam name="S">The factory input type</typeparam>
        /// <typeparam name="T">The target vector component type</typeparam>
        void CheckFactory<F,C,S,T>(N128 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : ISVFactory128Api<S,T>
            where C : ICheckSF128<S,T>
        {            
            void exec()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    Require(check.Invoke(a,v), ClaimKind.Eq);
                }
            }

            CheckAction(exec, CaseName(f));
        }

        /// <summary>
        /// Verifies the correct function of a vectorized factory operator
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="f">The factory operator to verify</param>
        /// <param name="check">The adjudication operator</param>
        /// <param name="s">A factory input type representative</param>
        /// <param name="t">A target vector component type representative</param>
        /// <typeparam name="F">The factory type</typeparam>
        /// <typeparam name="C">The check operator type</typeparam>
        /// <typeparam name="S">The factory input type</typeparam>
        /// <typeparam name="T">The target vector component type</typeparam>
        void CheckFactory<F,C,S,T>(N256 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : ISVFactory256Api<S,T>
            where C : ICheckSF256<S,T>
        {
            void exec()
            {
                for(var i=0; i< RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    Require(check.Invoke(a,v), ClaimKind.Eq);
                }
            }

            CheckAction(exec, CaseName(f));
        }            
    }
}