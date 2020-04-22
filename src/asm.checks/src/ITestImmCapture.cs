//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;

    using static BufferSeqId;

    using K = Kinds;

    public interface ITestImmCapture : ITestCapture
    {
        TestCaseRecord TestImm<T>(W256 w, K.BinaryOpClass k, MethodInfo src, byte imm)
            where T : unmanaged        
        {            
            void check()
            {
                var injector = Dynamic.BinaryInjector<T>(w);
                var f = injector.EmbedImmediate(src, imm);

                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);            
                var v1 = f.DynamicOp.Invoke(x,y);
                
                var asm = CaptureAsm(f).Require();
                var h = Dynamic.EmitFixedBinary(this[Main], w, asm.Code);
                var v2 = h(x.ToFixed(),y.ToFixed()).ToVector<T>();
                veq(v1,v2);
            }

            return TestAction(check, CaseName<T>(src.Name));
        }    

        TestCaseRecord TestBinaryImm<T>(W128 w, MethodInfo method, byte imm)
            where T : unmanaged
        {                        
            void check()
            {
                var injector = Dynamic.BinaryInjector<T>(w);
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);
                
                var f = injector.EmbedImmediate(method,imm);
                var v1 = f.DynamicOp.Invoke(x,y);
                var captured = CaptureService.Capture(Exchange.Context, f.Id, f.DynamicOp).Require();            
                var asm = Decoder.Decode(captured).Require();
                var g = Dynamic.EmitFixedBinary<Fixed128>(this[Main], asm.Code);
                var v2 = g(x.ToFixed(),y.ToFixed()).ToVector<T>();            
                veq(v1,v2);
            }
            return TestAction(check, CaseName<T>(method.Name));
        }
        
        TestCaseRecord TestUnaryImm<T>(W256 w, MethodInfo method, byte imm)
            where T : unmanaged
        {            

            void check()
            {
                var k = K.UnaryOp;
                var injector = Dynamic.UnaryInjector<T>(w);                        
                var dynop = injector.EmbedImmediate(method,imm);

                var x = Random.CpuVector<T>(w);
                var v1 = dynop.DynamicOp.Invoke(x);
                
                var capture = CaptureService.Capture(Exchange.Context, dynop.Id, dynop).Require();            
                var asm = Decoder.Decode(capture).Require();

                var f = Dynamic.EmitFixedUnary<Fixed256>(this[Main], capture.Code);
                var v2 = f(x.ToFixed()).ToVector<T>();
                veq(v1,v2);
            }

            return TestAction(check, CaseName<T>(method.Name));
        }
    }
}