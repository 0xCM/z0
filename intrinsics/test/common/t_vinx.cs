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
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Root;
    using static Nats;
    using static vgeneric;

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
            Comparisons = Context.Comparisons();
            //Comparisons = ComparisonContext.From(this);
        }
        
        protected IComparisonService Comparisons {get;}
        
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
            where F : IVPatternSource128<T>
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
            where F : IVPatternSource256<T>
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
            where F : IVFactory128<S,T>
            where C : IVChecker128<S,T>
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
            where F : IVFactory256<S,T>
            where C : IVChecker256<S,T>
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
            where F : IVUnaryOp128D<T>
                => Comparisons.CheckUnaryScalarMatch(f,w,t);

        protected void CheckUnaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVUnaryOp256D<T>
                => Comparisons.CheckUnaryScalarMatch(f,w,t);
    
        protected void CheckShiftScalarMatch<F,T>(F f, W128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVShiftOp128D<T>
                => Comparisons.CheckShiftScalarMatch(f,w,t);

        protected void CheckShiftScalarMatch<F,T>(F f, W256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVShiftOp256D<T>
                => Comparisons.CheckShiftScalarMatch(f,w,t);

        protected void CheckBinaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVBinaryOp128D<T>
                => Comparisons.CheckBinaryScalarMatch(f,w,t);

        protected void CheckBinaryScalarMatch<F,T>(F f, W256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinaryOp256D<T>
                => Comparisons.CheckBinaryScalarMatch(f,w,t);

        protected void CheckTernaryScalarMatch<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : IVTernaryOp128D<T>
                => Comparisons.CheckTernaryScalarMatch(f,w,t);

        protected void CheckTernaryScalarMatch<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : IVTernaryOp256D<T>
                => Comparisons.CheckTernaryScalarMatch(f,w,t);

        protected void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinaryOp128D<T>
                =>  Comparisons.CheckScalarMatch(f,src);
                
        // {
        //     var cells = vcount<T>(n128);
        //     var succeeded = true;
        //     var casename = CaseName(f);
            
        //     count.Start();
        //     try
        //     {
        //         for(var i=0; i < RepCount; i++)
        //         {
        //             (var x, var y) = src(i);
        //             var z = f.Invoke(x,y);
        //             for(var j=0; j< cells; j++)
        //                 Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
        //         }
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e, casename);
        //         succeeded = false;
        //     }
        //     finally
        //     {
        //         ReportOutcome(casename,succeeded,count);
        //     }
        // }

        protected void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinaryOp256D<T>
                =>  Comparisons.CheckScalarMatch(f,src);

        // {
        //     var cells = vcount<T>(n256);
        //     var succeeded = true;
        //     var casename = CaseName(f);
            
        //     count.Start();
        //     try
        //     {
        //         for(var i=0; i < RepCount; i++)
        //         {
        //             (var x, var y) = src(i);
        //             var z = f.Invoke(x,y);
        //             for(var j=0; j< cells; j++)
        //                 Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
        //         }
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e, casename);
        //         succeeded = false;
        //     }
        //     finally
        //     {
        //         ReportOutcome(casename,succeeded,count);
        //     }
        // }       

        protected void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null, SystemCounter count = default) 
            where T : unmanaged
            where F : IVBinaryOp128<T>
                => Comparisons.CheckExplicit(f,left,right,dst,name);

        // {
        //     var casename = name ?? CaseName(f);
        //     var w = n128;
        //     var t = default(T);
        //     var cells = vcount(w,t);
        //     var succeeded = true;
        //     var blocks = left.BlockCount;

        //     count.Start();
        //     try
        //     {
        //         for(var block=0; block<blocks; block++)
        //         {
        //             var x = left.LoadVector(block);
        //             var y = right.LoadVector(block);
        //             var actual = f.Invoke(x,y);
        //             var expect = dst.LoadVector(block);
        //             Claim.yea(gvec.vsame(actual,expect));
        //         }
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e, casename);
        //         succeeded = false;
        //     }
        //     finally
        //     {
        //         ReportOutcome(casename, succeeded,count);
        //     }
        // }

        protected void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null, SystemCounter count = default) 
            where T : unmanaged
            where F : IVBinaryOp256<T>
                => Comparisons.CheckExplicit(f,left,right,dst,name);
        // {
        //     var casename = name ?? CaseName(f);
        //     var w = n256;
        //     var t = default(T);
        //     var cells = vcount(w,t);
        //     var succeeded = true;
        //     var blocks = left.BlockCount;
            
        //     count.Start();
        //     try
        //     {
        //         for(var block=0; block<blocks; block++)
        //         {
        //             var x = left.LoadVector(block);
        //             var y = right.LoadVector(block);
        //             var actual = f.Invoke(x,y);
        //             var expect = dst.LoadVector(block);
        //             Claim.yea(gvec.vsame(actual,expect));
        //         }
        //     }
        //     catch(Exception e)
        //     {
        //         term.error(e,casename);
        //         succeeded = false;
        //     }
        //     finally
        //     {
        //         ReportOutcome(casename,succeeded,count);
        //     }
        // }
    }
}