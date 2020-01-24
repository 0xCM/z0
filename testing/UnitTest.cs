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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

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

        /// <summary>
        /// Verifies that two 8-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch(BinaryOp8 f, Moniker fId, BinaryOp8 g, Moniker gId)
        {
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(n8);
                    var y = Random.Fixed(n8);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 16-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch(BinaryOp16 f, Moniker fId, BinaryOp16 g, Moniker gId)
        {
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(n16);
                    var y = Random.Fixed(n16);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch(BinaryOp32 f, Moniker fId, BinaryOp32 g, Moniker gId)
        {
            var w = n32;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 64-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch(BinaryOp64 f, Moniker fId, BinaryOp64 g, Moniker gId)
        {
            var w = n64;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 128-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch(BinaryOp128 f, Moniker fId, BinaryOp128 g, Moniker gId)
        {
            var w = n128;
            
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 128-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch(BinaryOp256 f, Moniker fId, BinaryOp256 g, Moniker gId)
        {
            var w = n256;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Fixed(w);
                    var y = Random.Fixed(w);
                    Claim.eq(f(x,y),g(x,y));
                }
            }

            CheckAction(check, CaseName($"{fId}~/~{gId}"));
        }

        /// <summary>
        /// Verifies that two 128-bit vectorized binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch<T>(BinaryOp<Vector128<T>> f, BinaryOp128 g, Moniker name)
            where T : unmanaged
        {
            void check()
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

            CheckAction(check, name);      

        }

        /// <summary>
        /// Verifies that two 256-bit vectorized binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator, considered as a basline</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator, considered as the operation under test</param>
        /// <param name="gId">The identity of the second operator</param>
        protected void CheckMatch<T>(BinaryOp<Vector256<T>> f, BinaryOp256 g, Moniker name)
            where T : unmanaged
        {
            void check()
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

            CheckAction(check, name);      
        }

        /// <summary>
        /// Manages the execution of an action test case
        /// </summary>
        /// <param name="f">The action under test</param>
        /// <param name="name">The action name</param>
        /// <param name="clock">Accumulates the test case execution time</param>
        protected void CheckAction(Action f, Moniker name, SystemCounter count = default)
        {
            var succeeded = true;
            
            count.Start();
            try
            {
                f();
            }
            catch(Exception e)
            {
                errout(e, name.Text);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(CaseName(name), succeeded,count);
            }
        }

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
                errout(e, name);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(name,succeeded,count);
            }
        }

        protected INativeWriter NativeTestWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, Paths.HexExt);    
            return path.NativeWriter();                                
        }

    }
}