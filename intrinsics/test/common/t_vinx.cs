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
    
    /// <summary>
    /// Base type for vectorized intrinsic tests
    /// </summary>
    /// <typeparam name="X">The concrete subtype</typeparam>
    public abstract class t_vinx<X> : t_inx<X>
        where X : t_vinx<X>
    {
        protected t_vinx()
        {
            Check = new CheckExec(Config);
            Comparisons = Context.Decompostions();
            //Comparisons = ComparisonContext.From(this);
        }
        
        protected ISVValidatorD Comparisons {get;}
        
        protected ISVValidatorD<T> Validator<T>()
            where T : unmanaged
                => Context.Decomposer<T>();

        protected CheckExec Check {get;}

        static void CheckFailed()
            => throw new Exception();

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
                Claim.eq(expect,actual);
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
                Claim.eq(expect,actual);
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
    
        protected void CheckUnaryScalarMatch<F,T>(F f, W128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : ISVUnaryOp128DApi<T>
                => Comparisons.CheckUnaryScalarMatch(f,w,t);

        protected void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256DApi<T>
                => Comparisons.CheckUnaryScalarMatch(f,w,t);
    
        protected void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : ISVShiftOp128DApi<T>
                => Comparisons.CheckShiftScalarMatch(f,w,t);

        protected void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : ISVShiftOp256DApi<T>
                => Comparisons.CheckShiftScalarMatch(f,w,t);

        protected void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
                => Comparisons.CheckBinaryScalarMatch(f,w,t);

        protected void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
                => Comparisons.CheckBinaryScalarMatch(f,w,t);

        protected void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128DApi<T>
                => Comparisons.CheckTernaryScalarMatch(f,w,t);

        protected void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256DApi<T>
                => Comparisons.CheckTernaryScalarMatch(f,w,t);

        protected void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src, SystemCounter count = default)
            where T : unmanaged
            where F : ISVBinaryOp128DApi<T>
                =>  Comparisons.CheckScalarMatch(f,src);
                

        protected void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src, SystemCounter count = default)
            where T : unmanaged
            where F : ISVBinaryOp256DApi<T>
                =>  Comparisons.CheckScalarMatch(f,src);


        protected void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null, SystemCounter count = default) 
            where T : unmanaged
            where F : ISVBinaryOp128Api<T>
                => Comparisons.CheckExplicit(f,left,right,dst,name);


        protected void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null, SystemCounter count = default) 
            where T : unmanaged
            where F : ISVBinaryOp256Api<T>
                => Comparisons.CheckExplicit(f,left,right,dst,name);
    }
}