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

    using K = Kinds.BinaryOpClass;
    
    public interface ITestDynamicBinary : ITester, ITestOperatorMatch
    {
        TestCaseRecord Match(in BufferSeq buffers, K k, TypeWidth w, IdentifiedCode a, IdentifiedCode b)
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

        TestCaseRecord Match(in BufferSeq buffers, K k, W8 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W16 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W32 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W64 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k,  W128 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(in BufferSeq buffers, K k, W256 w, IdentifiedCode a, IdentifiedCode b)
        {
            var f = Dynamic.EmitFixedBinary(buffers[Left], w, a);
            var g = Dynamic.EmitFixedBinary(buffers[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }        
    }
}