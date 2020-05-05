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
        TestCaseRecord Match(K k, TypeWidth w, UriHex a, UriHex b, BufferTokens dst)
        {
            switch(w)
            {
                case TypeWidth.W8:
                    return Match(k, w8, a, b, dst);

                case TypeWidth.W16:
                    return Match(k, w16, a, b, dst);

                case TypeWidth.W32:
                    return Match(k, w32, a, b, dst);

                case TypeWidth.W64:
                    return Match(k, w64, a, b, dst);

                case TypeWidth.W128:
                    return Match(k, w128, a, b, dst);

                case TypeWidth.W256:
                    return Match(k, w256, a, b, dst);
            }
            throw Unsupported.define(w.GetType());
        }
        
        TestCaseRecord Match(K k, W8 w, UriHex a, UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(K k, W16 w, UriHex a, UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(K k, W32 w, UriHex a, UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(K k, W64 w, UriHex a, UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(K k,  W128 w, UriHex a, UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                          
        }

        TestCaseRecord Match(K k, W256 w, UriHex a, UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());                                                      
        }
    }
}