//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using Z0.Asm;
    
    using static BufferSeqId;
    using static Memories;

    using K = Kinds;

    public interface IAsmChecks : IService, ITestFixed, ITestVectors, ITestAction
    {
        TestCaseRecord TestMatch<T>(in BufferSeq buffers, BinaryOp<Vector128<T>> f, ApiBits bits)
            where T : unmanaged;

        TestCaseRecord TestMatch<T>(in BufferSeq buffers, BinaryOp<Vector256<T>> f, ApiBits bits)
            where T : unmanaged;                    

        TestCaseRecord TestImm<T>(in CaptureExchange exchange, BufferToken buffer, W256 w, K.BinaryOpClass k, MethodInfo src, byte imm)
            where T : unmanaged;                    

        IDynamicOps Dynamic {get;}

        ITestFixed TestFixed => this;

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k, TypeWidth w, IdentifiedCode a, IdentifiedCode b)
        {
            switch(w)
            {
                case TypeWidth.W8:
                    return TestMatch(buffers, k, w8,a,b);

                case TypeWidth.W16:
                    return TestMatch(buffers, k, w16,a,b);

                case TypeWidth.W32:
                    return TestMatch(buffers, k, w32,a,b);

                case TypeWidth.W64:
                    return TestMatch(buffers, k, w64,a,b);

                case TypeWidth.W128:
                    return TestMatch(buffers, k, w128,a,b);

                case TypeWidth.W256:
                    return TestMatch(buffers, k, w256, a, b);
            }
            throw Unsupported.define(w.GetType());
        }

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k, W8 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return TestFixed.TestMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k, W16 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return TestFixed.TestMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k, W32 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return TestFixed.TestMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k, W64 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return TestFixed.TestMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k,  W128 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return TestFixed.TestMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord TestMatch(in BufferSeq buffers, K.BinaryOpClass k, W256 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return TestFixed.TestMatch(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }
    }
}