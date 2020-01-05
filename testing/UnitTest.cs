//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    public abstract class UnitTest<U> : TestContext<U>, IUnitTest
        where U : UnitTest<U>
    {
        protected UnitTest()
            : base(null,null)
        {

        }

        protected UnitTest(ITestConfig config)
            : base(config, null)
            {

            }        

        protected UnitTest(ITestConfig config, IPolyrand random)
            : base(config, random)
            {

            }        

        protected UnitTest(IPolyrand random)
            : base(null, random)
        {

        }        

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        [MethodImpl(Inline)]
        protected string CaseName(IFunc f)
            => $"{GetType().Name}/{f.Moniker}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        [MethodImpl(Inline)]
        protected string CaseName(string fullname)
            => $"{GetType().Name}/{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        [MethodImpl(Inline)]
        protected string CaseName<T>(string root, T t = default)
            => $"{GetType().Name}/{root}_{suffix(t)}";

        [MethodImpl(Inline)]
        protected string CaseName<W,T>(string root, W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => $"{GetType().Name}/{moniker(root,w,t)}";

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, string name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                error(e, name);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(name,succeeded,count);
            }

        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="t">A discrinator representative</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        /// <typeparam name="T">The discriminator type</typeparam>
        protected void CheckAction<T>(Action f, string name, T t = default, SystemCounter clock = default)
        {
            var casename = CaseName(name,t);
            var succeeded = true;
            
            clock.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
            }

        }

        protected void CheckExplicit<F,T>(F f, Block128<T> left, Block128<T> right, Block128<T> dst, string name = null, SystemCounter count = default) 
            where T : unmanaged
            where F : IVBinOp128<T>
        {
            var casename = name ?? CaseName(f);
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
                    var actual = f.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    Claim.yea(ginx.vsame(actual,expect));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename, succeeded,count);
            }
        }

        protected void CheckExplicit<F,T>(F f, Block256<T> left, Block256<T> right, Block256<T> dst, string name = null, SystemCounter count = default) 
            where T : unmanaged
            where F : IVBinOp256<T>
        {
            var casename = name ?? CaseName(f);
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
                    var actual = f.Invoke(x,y);
                    var expect = dst.LoadVector(block);
                    Claim.yea(ginx.vsame(actual,expect));
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
        protected void CheckUnaryMatch<F,G,T>(F expect, G actual, T t = default, bool nozero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IUnaryOp<T>
            where G : IUnaryOp<T>
        {
            var casename = CaseName(actual);
            var succeeded = true;
            var next = nozero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next();
                    var y = next();
                    Claim.eq(expect.Invoke(x), actual.Invoke(x));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
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
        protected void CheckBinaryPredMatch<F,G,T>(F expect, G actual, T t = default, SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryPred<T>
            where G : IBinaryPred<T>
        {
            var casename = CaseName(actual);
            var succeeded = true;
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();                    
                    Claim.eq(expect.Invoke(x,y), actual.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
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
        protected void CheckBinaryPredMatch<F,G,T>(F expect, G actual, T t = default, bool nozero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryOp<T>
            where G : IBinaryOp<T>
        {
            var casename = CaseName(actual);
            var succeeded = true;
            var next = nozero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next();
                    var y = next();
                    Claim.eq(expect.Invoke(x,y), actual.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
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
        protected void CheckTernaryMatch<F,G,T>(F expect, G actual, T t = default, bool nozero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : ITernaryOp<T>
            where G : ITernaryOp<T>
        {
            var casename = CaseName(actual);
            var succeeded = true;
            var next = nozero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next();
                    var y = next();
                    var z = next();
                    Claim.eq(expect.Invoke(x,y,z), actual.Invoke(x,y,z));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
            }
        }


    }
}