//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;


    public abstract class t_vsvc<X> : UnitTest<X>    
        where X : t_vsvc<X>, new()
    {

        protected new ICheckNumeric Claim => ICheckNumeric.Checker;

        protected CheckExec Check {get;}

        protected IVSvcCheck VChecks {get;}
        
        protected t_vsvc()
        {
            Check = new CheckExec();

            VChecks = VSvcCheck.Create(VSvcCheckContext.Create(Context.Decomposer()));
        }


        static void CheckFailed()
            => throw new Exception();

        protected ISVFDecomposer<T> Validator<T>()
            where T : unmanaged
                => Context.Decomposer<T>();

        /// <summary>
        /// Verifies that a vectorized pattern source produces the expected pattern
        /// </summary>
        /// <param name="f">The pattern source</param>
        /// <param name="expect">The expected pattern</param>
        /// <typeparam name="F">The pattern source type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        protected void CheckPattern<F,T>(F f, Vector128<T> expect)
            where T : unmanaged
            where F : ISVPatternSource128Api<T>
        {
            void exec()
            {
                var actual = f.Invoke();
                Claim.veq(expect,actual);
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
        protected void CheckPattern<F,T>(F f, Vector256<T> expect)
            where T : unmanaged
            where F : ISVPatternSource256Api<T>
        {
            void exec()
            {
                var actual = f.Invoke();
                Claim.veq(expect,actual);
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
        protected void CheckFactory<F,C,S,T>(N128 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : ISVFactory128Api<S,T>
            where C : ISFChecker128Api<S,T>
        {
            var casename = CaseName(f);
            void exec()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    if(!check.Invoke(a,v))
                        CheckFailed();
                }
            }

            CheckAction(exec, casename);
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
        protected void CheckFactory<F,C,S,T>(N256 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : ISVFactory256Api<S,T>
            where C : ISFChecker256Api<S,T>
        {
            var casename = CaseName(f);

            void exec()
            {
                for(var i=0; i< RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    if(!check.Invoke(a,v))
                        CheckFailed();
                }
            }

            CheckAction(exec, casename);
        }
    
    }
}
