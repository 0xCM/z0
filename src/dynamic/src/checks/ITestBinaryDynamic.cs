//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = BinaryOpClass;
    using Test = TestBinaryDynamic;


    public interface ITestBinaryDynamic : TTestOperatorMatch, TCheckDynamic
    {
        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, TypeWidth w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W8 w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W16 w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W32 w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W64 w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k,  W128 w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);

        [MethodImpl(Inline)]
        TestCaseRecord Match(K k, W256 w, ApiHex a, ApiHex b, BufferTokens dst)
            => Test.Check((TTestFixedBinaryOp)this).Match(k,w,a,b,dst);
    }
}