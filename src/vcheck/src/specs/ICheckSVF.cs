//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    using K = Kinds;
    
    readonly struct CheckSVF : ICheckSVF
    {
        public ITestContext Context {get;}

        [MethodImpl(Inline)]
        public static CheckSVF Create(ITestContext context)
            => new CheckSVF(context);

        [MethodImpl(Inline)]
        public CheckSVF(ITestContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]
        void ISink<TestCaseRecord>.Deposit(TestCaseRecord src)
            => Context.Deposit(src);
    }    

    public interface ICheckSVF : ITestService, ICheckVectors, ITestRandom, ICheckAction
    {
        ICheckSVF<T> Typed<T>()
            where T : unmanaged
                => Context.CheckSVF<T>();

        void CheckUnaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp128D<T>
                => Typed<T>().CheckSVF(f, K.UnaryOp, w);
        
        void CheckUnaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVUnaryOp256D<T>
                => Typed<T>().CheckSVF(f, K.UnaryOp, w);

        void CheckShiftOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp128D<T>
                => Typed<T>().CheckSVF(f, K.ShiftOp, w);

        void CheckShiftOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVShiftOp256D<T>
                => Typed<T>().CheckSVF(f, K.ShiftOp, w);

        void CheckBinaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp128D<T>
                => Typed<T>().CheckSVF(f, K.BinaryOp, w);

        void CheckBinaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVBinaryOp256D<T>
                => Typed<T>().CheckSVF(f, K.BinaryOp, w);

        void CheckTernaryOp<F,T>(F f, W128 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp128D<T>
                => Typed<T>().CheckSVF(f, K.TernaryOp, w);

        void CheckTernaryOp<F,T>(F f, W256 w, T t = default)
            where T : unmanaged
            where F : ISVTernaryOp256D<T>
                => Typed<T>().CheckSVF(f, K.TernaryOp, w);

        void CheckCells<F,T>(F f, Func<int,Pair<Vector128<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp128D<T>
        {
            var cells = vcount<T>(n128);
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();
            try
            {
                for(var i=0; i < RepCount; i++)
                {
                    (var x, var y) = src(i);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }
        }
            
        void CheckCells<F,T>(F f, Func<int,Pair<Vector256<T>>> src)
            where T : unmanaged
            where F : ISVBinaryOp256D<T>
        {
            var cells = vcount<T>(n256);
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();
            try
            {
                for(var i=0; i < RepCount; i++)
                {
                    (var x, var y) = src(i);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }
        }       

        void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp128<T>
        {
            var casename = name ?? Context.CaseName(f);
            var w = n128;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var blocks = left.BlockCount;
            var count = time.counter();

            count.Start();
            try
            {
                for(var block=0; block<blocks; block++)
                {
                    var x = left.LoadVector(block);
                    var y = right.LoadVector(block);
                    var actual = f.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    eq(actual, expect);
                }
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename, succeeded,count);
            }
        }

        void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null) 
            where T : unmanaged
            where F : ISVBinaryOp256<T>
        {
            var casename = name ?? Context.CaseName(f);
            var w = n256;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var blocks = left.BlockCount;
            var count = time.counter();
            
            count.Start();
            try
            {
                for(var block=0; block<blocks; block++)
                {
                    var x = left.LoadVector(block);
                    var y = right.LoadVector(block);
                    var actual = f.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    eq(actual, expect);
                }
            }
            catch(Exception e)
            {
                term.errlabel(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }
        }


        /// <summary>
        /// Verifies that a vectorized pattern source produces the expected pattern
        /// </summary>
        /// <param name="f">The pattern source</param>
        /// <param name="expect">The expected pattern</param>
        /// <typeparam name="F">The pattern source type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        void CheckPattern<F,T>(F f, Vector128<T> expect)
            where T : unmanaged
            where F : ISVPatternSource128<T>
        {
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();

            try
            {
                eq(expect,f.Invoke());
            }
            catch(Exception e)
            {
                term.errlabel(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }                   
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
            where F : ISVPatternSource256<T>
        {
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();

            try
            {
                eq(expect,f.Invoke());
            }
            catch(Exception e)
            {
                term.errlabel(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }                   
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
            where F : ISVFactory128<S,T>
            where C : ICheckSF128<S,T>
        {            
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();

            void exec()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    Require(check.Invoke(a,v), ClaimKind.Eq);
                }
            }

            try
            {
                exec();
            }
            catch(Exception e)
            {
                term.errlabel(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }                   
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
            where F : ISVFactory256<S,T>
            where C : ICheckSF256<S,T>
        {
            var succeeded = true;
            var casename = Context.CaseName(f);
            var count = time.counter();
            
            count.Start();

            void exec()
            {
                for(var i=0; i< RepCount; i++)
                {
                    var a = Random.Next<S>();
                    var v = f.Invoke(a);
                    Require(check.Invoke(a,v), ClaimKind.Eq);
                }
            }

            try
            {
                exec();
            }
            catch(Exception e)
            {
                term.errlabel(e,casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,count);
            }                   
        }
    }
}