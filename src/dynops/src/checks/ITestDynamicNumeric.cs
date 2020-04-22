//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    
    using static BufferSeqId;
    using static Memories;
    using static TestDynamic;

    public interface ITestDynamicNumeric : ITestRandom, ITestOperatorMatch, ICheckNumeric
    {
        TestCaseRecord MatchNumeric<T>(in BufferSeq buffers, UnaryOp<T> f, IdentifiedCode src)
            where T : unmanaged
        {                                  
            var g = Dynamic.EmitUnaryOp<T>(buffers[Main],src);
            
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T>();
                    eq(f(x), g(x));
                }
            }

            return TestAction(check, src.Id);
        }

        TestCaseRecord MatchNumeric<T>(in BufferSeq buffers, BinaryOp<T> f, IdentifiedCode src)
            where T : unmanaged
        {                                  
            var g = Dynamic.EmitBinaryOp<T>(buffers[Main],src);
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();
                    eq(f(x,y),g(x,y));
                }
            }

            return TestAction(check, src.Id);
        }

        TestCaseRecord MatchNumeric<T>(in BufferSeq buffers, TernaryOp<T> f, IdentifiedCode src)
            where T : unmanaged
        {                                  
            var g = Dynamic.EmitTernaryOp<T>(buffers[Main],src);
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y, var z) = Random.NextTriple<T>();
                    eq(f(x,y,z),g(x,y,z));
                }
            }

            return TestAction(check, src.Id);
        }
    }
}