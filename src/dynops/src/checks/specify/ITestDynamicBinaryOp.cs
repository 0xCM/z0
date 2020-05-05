//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;        

    using K = Kinds.BinaryOpClass;
    using Test = TestDynamicBinaryOp;
    
    public interface ITestDynamicBinaryOp : ITestOperatorMatch, ICheckDynamic
    {        
        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, TypeWidth w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W8 w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W16 w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W32 w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W64 w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k,  W128 w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W256 w, UriHex a, UriHex b, BufferTokens dst)
            => Test.Check((ITestFixedBinaryOp)this).Match(k,w,a,b,dst);
    }
}