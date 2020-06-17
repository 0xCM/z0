//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static BufferSeqId;

    public interface ITestCapture : IAsmTester
    {
        Option<AsmFunction> CaptureAsm<D>(DynamicDelegate<D> src)
            where D : Delegate
                => from capture in CaptureService.Capture(CaptureExchange.Context, src.Id, src)
                from asm in Decoder.Decode(capture)
                select asm;        

        TestCaseRecord TestMatch<T>(BinaryOp<T> f, UriHex src)
            where T : unmanaged
        {                                  
            var g = Dynamic.EmitBinaryOp<T>(this[Main],src);
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
    }
}