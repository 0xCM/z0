//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BufferSeqId;
    using static Memories;

    using K = BinaryOpClass;

    public readonly struct TestBinaryDynamic : ITestBinaryDynamic
    {
        readonly TTestFixedBinaryOp Matcher;

        public IPolyrand Random
            => Matcher.Random;

        [MethodImpl(Inline)]
        public static ITestBinaryDynamic Service(TTestFixedBinaryOp matcher)
            => new TestBinaryDynamic(matcher);

        [MethodImpl(Inline)]
        internal static TestBinaryDynamic Check(TTestFixedBinaryOp matcher)
            => new TestBinaryDynamic(matcher);

        internal TestBinaryDynamic(TTestFixedBinaryOp matcher)
        {
            Matcher = matcher;
        }

        IDynexus Dynamic => CheckDynamic.Checker.Dynamic;

        public TestCaseRecord Match(K k, TypeWidth w, X86UriHex a, X86UriHex b, BufferTokens dst)
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

        public TestCaseRecord Match(K k, W8 w, X86UriHex a, X86UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W16 w, X86UriHex a, X86UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W32 w, X86UriHex a, X86UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W64 w, X86UriHex a, X86UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k,  W128 w, X86UriHex a, X86UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W256 w, X86UriHex a, X86UriHex b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }
    }
}