//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public abstract class UnitTest<U> : TestContext<U>, IUnitTest
        where U : UnitTest<U>
    {

        protected UnitTest(ITestConfig config = null)
            : base(config)
            {

            }        

        /// <summary>
        /// Produces the name of the test case for the specified operator
        /// </summary>
        /// <param name="op">The operator</param>
        [MethodImpl(Inline)]
        protected string TestCaseName(IOp op)
            => $"{GetType().Name}/{op.Moniker}";

        [MethodImpl(Inline)]
        static int vcount<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => TypeMath.div(w,t);

        protected void check_explicit<T>(IVBinOp128<T> op, Block128<T> left, Block128<T> right, Block128<T> dst, SystemCounter count = default) 
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var blocks = left.BlockCount;
            
            count.Start();
            try
            {
                for(var block=0; block<blocks; block++)
                {
                    var x = left.LoadVector(block);
                    var y = right.LoadVector(block);
                    var actual = op.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    Claim.yea(ginx.vsame(actual,expect));
                }
            }
            catch(Exception e)
            {
                error(e,TestCaseName(op));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(op),succeeded,count);
            }

        }

        protected void check_explicit<T>(IVBinOp256<T> op, Block256<T> left, Block256<T> right, Block256<T> dst, SystemCounter count = default) 
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var blocks = left.BlockCount;
            
            count.Start();
            try
            {
                for(var block=0; block<blocks; block++)
                {
                    var x = left.LoadVector(block);
                    var y = right.LoadVector(block);
                    var actual = op.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    Claim.yea(ginx.vsame(actual,expect));
                }
            }
            catch(Exception e)
            {
                error(e,TestCaseName(op));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(op),succeeded,count);
            }
        }

        /// <summary>
        /// Checks that two unary operators agree over a sequence of random points
        /// </summary>
        /// <param name="expect">The reference operator</param>
        /// <param name="actual">The operator under test</param>
        /// <param name="t">A point representative</param>
        /// <param name="clock">The counter to use to measure the time under test</param>
        /// <typeparam name="F">The reference operator type</typeparam>
        /// <typeparam name="G">The test operator type</typeparam>
        /// <typeparam name="T">The domain over which the operators are defined</typeparam>
        protected void check_unary_match<F,G,T>(F expect, G actual, T t = default, bool nozero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IUnaryOp<T>
            where G : IUnaryOp<T>
        {
            var succeeded = true;
            var next = nozero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<SampleCount; i++)
                {
                    var x = next();
                    var y = next();
                    Claim.eq(expect.Invoke(x), actual.Invoke(x));
                }
            }
            catch(Exception e)
            {
                error(e, TestCaseName(actual));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(expect),succeeded,clock);
            }
        }

        /// <summary>
        /// Checks that two binary operators agree over a sequence of random points
        /// </summary>
        /// <param name="expect">The reference operator</param>
        /// <param name="actual">The operator under test</param>
        /// <param name="t">A point representative</param>
        /// <param name="clock">The counter to use to measure the time under test</param>
        /// <typeparam name="F">The reference operator type</typeparam>
        /// <typeparam name="G">The test operator type</typeparam>
        /// <typeparam name="T">The domain over which the operators are defined</typeparam>
        protected void check_binarypred_match<F,G,T>(F expect, G actual, T t = default, SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryPred<T>
            where G : IBinaryPred<T>
        {
            var succeeded = true;
            
            clock.Start();
            try
            {
                for(var i=0; i<SampleCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();                    
                    Claim.eq(expect.Invoke(x,y), actual.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                error(e, TestCaseName(actual));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(expect),succeeded,clock);
            }
        }

        /// <summary>
        /// Checks that two binary operators agree over a sequence of random points
        /// </summary>
        /// <param name="expect">The reference operator</param>
        /// <param name="actual">The operator under test</param>
        /// <param name="t">A point representative</param>
        /// <param name="clock">The counter to use to measure the time under test</param>
        /// <typeparam name="F">The reference operator type</typeparam>
        /// <typeparam name="G">The test operator type</typeparam>
        /// <typeparam name="T">The domain over which the operators are defined</typeparam>
        protected void check_binary_match<F,G,T>(F expect, G actual, T t = default, bool nozero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryOp<T>
            where G : IBinaryOp<T>
        {
            var succeeded = true;
            var next = nozero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<SampleCount; i++)
                {
                    var x = next();
                    var y = next();
                    Claim.eq(expect.Invoke(x,y), actual.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                error(e, TestCaseName(actual));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(expect),succeeded,clock);
            }
        }

        /// <summary>
        /// Checks that two tarnary operators agree over a sequence of random points
        /// </summary>
        /// <param name="expect">The reference operator</param>
        /// <param name="actual">The operator under test</param>
        /// <param name="t">A point representative</param>
        /// <param name="clock">The counter to use to measure the time under test</param>
        /// <typeparam name="F">The reference operator type</typeparam>
        /// <typeparam name="G">The test operator type</typeparam>
        /// <typeparam name="T">The domain over which the operators are defined</typeparam>
        protected void check_ternary_match<F,G,T>(F expect, G actual, T t = default, bool nozero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : ITernaryOp<T>
            where G : ITernaryOp<T>
        {
            var succeeded = true;
            var next = nozero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<SampleCount; i++)
                {
                    var x = next();
                    var y = next();
                    var z = next();
                    Claim.eq(expect.Invoke(x,y,z), actual.Invoke(x,y,z));
                }
            }
            catch(Exception e)
            {
                error(e, TestCaseName(actual));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(expect),succeeded,clock);
            }
        }

        protected void check_scalar_match<T>(IVBinOp128<T> op, SystemCounter count = default)
            where T : unmanaged
        {
            var w = n128;
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            
            count.Start();
            try
            {
                for(var i=0; i<SampleCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = op.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.eq(op.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                error(e,TestCaseName(op));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(op),succeeded,count);
            }
        }

        protected void check_scalar_match<T>(IVBinOp256<T> op, SystemCounter count = default)
            where T : unmanaged
        {
            var w = n256;
            var t = default(T);
            var len = vcount(w,t);
            var succeeded = true;

            count.Start();
            try
            {
                for(var i=0; i<SampleCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = op.Invoke(x,y);
                    for(var j=0; j< len; j++)
                        Claim.eq(op.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                
                error(e,TestCaseName(op));
                succeeded = false;
            }
            finally
            {
                ReportOutcome(TestCaseName(op),succeeded,count);
            }
        }

    }
}