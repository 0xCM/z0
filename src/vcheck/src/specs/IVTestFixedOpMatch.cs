//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public interface IVTestFixedOpMatch : ITestAction, IVectorEqualityCheck
    {
        TestCaseRecord TestMatch<T>(BinaryOp<Vector128<T>> f, OpIdentity fId, BinaryOp128 g, OpIdentity gId)
            where T : unmanaged
        {
            var w = w128;
            var t = default(T);

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    eq(f(x,y), g.Apply(x,y));
                }
            }            

            return TestAction(check, CaseName<T>($"{fId}~/~{gId}"));                   
        }

        TestCaseRecord TestMatch<T>(BinaryOp<Vector256<T>> f, OpIdentity fId, BinaryOp256 g, OpIdentity gId)
            where T : unmanaged
        {
            var w = w256;
            var t = default(T);

            void check()            
            {

                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    eq(f(x,y), g.Apply(x,y));
                }
            }            

            return TestAction(check, CaseName<T>($"{fId}~/~{gId}"));            
        }        
    }
}