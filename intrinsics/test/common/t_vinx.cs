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
    
    using static zfunc;

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
        }
        
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

        protected void CheckUnaryScalarMatch<F,T>(F f, N128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVUnaryOp128D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckUnaryScalarMatch<F,T>(F f, N256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVUnaryOp256D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);

            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }
    
        protected void CheckShiftScalarMatch<F,T>(F f, N128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVShiftOp128D<T>
        {
            var casename = CaseName(f);
            var cells = vcount(w,t);
            var succeeded = true;
            var bounds = ((byte)0, (byte)(bitsize(t) - 1));
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckShiftScalarMatch<F,T>(F f, N256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVShiftOp256D<T>
        {
            var casename = CaseName(f);
            var cells = vcount(w,t);
            var succeeded = true;
            var bounds = ((byte)0, (byte)(bitsize(t) - 1));
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckBinaryScalarMatch<F,T>(F f, N128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckBinaryScalarMatch<F,T>(F f, N256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
        {
            var len = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);

            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< len; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {                
                error(e,casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckTernaryScalarMatch<F,T>(F f, N128 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVTernaryOp128D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var a = Random.CpuVector(w,t);
                    var b = Random.CpuVector(w,t);
                    var c = Random.CpuVector(w,t);
                    var z = f.Invoke(a,b,c);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(a,j),vcell(b,j), vcell(c,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckTernaryScalarMatch<F,T>(F f, N256 w, T t = default, SystemCounter count = default)
            where T : unmanaged
            where F : IVTernaryOp256D<T>
        {
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            
            count.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var a = Random.CpuVector(w,t);
                    var b = Random.CpuVector(w,t);
                    var c = Random.CpuVector(w,t);
                    var z = f.Invoke(a,b,c);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(a,j),vcell(b,j), vcell(c,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector128<T>>> src, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinOp128D<T>
        {
            var cells = vcount<T>(n128);
            var succeeded = true;
            var casename = CaseName(f);
            
            count.Start();
            try
            {
                for(var i=0; i < RepCount; i++)
                {
                    (var x, var y) = src(i);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }

        protected void CheckScalarMatch<F,T>(F f, Func<int,Pair<Vector256<T>>> src, SystemCounter count = default)
            where T : unmanaged
            where F : IVBinOp256D<T>
        {
            var cells = vcount<T>(n256);
            var succeeded = true;
            var casename = CaseName(f);
            
            count.Start();
            try
            {
                for(var i=0; i < RepCount; i++)
                {
                    (var x, var y) = src(i);
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,count);
            }
        }       
    }
}