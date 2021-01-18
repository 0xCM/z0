//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BufferSeqId;

    using K = BinaryClass;

    public readonly struct CheckBinaryDynamic : ITestBinaryDynamic
    {
        readonly ICheckBinaryCellOp Matcher;

        public IPolyrand Random
            => Matcher.Random;

        [MethodImpl(Inline)]
        public static ITestBinaryDynamic Service(ICheckBinaryCellOp matcher)
            => new CheckBinaryDynamic(matcher);

        [MethodImpl(Inline)]
        internal static CheckBinaryDynamic Check(ICheckBinaryCellOp matcher)
            => new CheckBinaryDynamic(matcher);

        internal CheckBinaryDynamic(ICheckBinaryCellOp matcher)
        {
            Matcher = matcher;
        }

        IDynexus Dynamic => CheckDynamic.Checker.Dynamic;

        public TestCaseRecord Match(K k, TypeWidth w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
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

        public TestCaseRecord Match(K k, W8 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W16 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W32 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W64 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k,  W128 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        public TestCaseRecord Match(K k, W256 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedBinary(dst[Left], w, a);
            var g = Dynamic.EmitFixedBinary(dst[Right], w, b);
            return Matcher.Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }
    }
}