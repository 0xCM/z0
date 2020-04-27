//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static BufferSeqId;
    using static Memories;

    using K = Kinds.UnaryOpClass;

    public interface ITestDynamicUnary : ITester, ITestOperatorMatch, ICheckDynamic
    {
        TestCaseRecord Match(in BufferSeq buffers, K k, TypeWidth w, OperationCode a, OperationCode b)
        {
            switch(w)
            {
                case TypeWidth.W8:
                    return Match(buffers, k, w8, a, b);

                case TypeWidth.W16:
                    return Match(buffers, k, w16, a, b);

                case TypeWidth.W32:
                    return Match(buffers, k, w32, a, b);

                case TypeWidth.W64:
                    return Match(buffers, k, w64, a, b);

                case TypeWidth.W128:
                    return Match(buffers, k, w128, a, b);

                case TypeWidth.W256:
                    return Match(buffers, k, w256, a, b);
            }
            throw Unsupported.define(w.GetType());
        }
        
        TestCaseRecord Match(in BufferSeq buffers, K k, W8 w, OperationCode a, OperationCode b)
        {
            var f = Dynamic.EmitFixedUnary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedUnary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W16 w, OperationCode a, OperationCode b)
        {
            var f = Dynamic.EmitFixedUnary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedUnary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W32 w, OperationCode a, OperationCode b)
        {
            var f = Dynamic.EmitFixedUnary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedUnary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W64 w, OperationCode a, OperationCode b)
        {
            var f = Dynamic.EmitFixedUnary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedUnary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k,  W128 w, OperationCode a, OperationCode b)
        {
            var f = Dynamic.EmitFixedUnary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedUnary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W256 w, OperationCode a, OperationCode b)
        {
            var f = Dynamic.EmitFixedUnary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedUnary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }
    }
}