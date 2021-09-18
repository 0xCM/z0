//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static BufferSeqId;
    using static CellDelegates;

    using K = UnaryOperatorClass;
    using Eq = CheckEquatable;

    public interface ICheckUnaryDynamic : ITester, ITestOperatorMatch, ICheckDynamic
    {
        TestCaseRecord Match(K k, TypeWidth w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
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

        TestCaseRecord Match(K k, W8 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        TestCaseRecord Match(K k, W16 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        TestCaseRecord Match(K k, W32 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        TestCaseRecord Match(K k, W64 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        TestCaseRecord Match(K k,  W128 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        TestCaseRecord Match(K k, W256 w, ApiCodeBlock a, ApiCodeBlock b, BufferTokens dst)
        {
            var f = Dynamic.EmitFixedUnary(dst[Left], w, a);
            var g = Dynamic.EmitFixedUnary(dst[Right], w, b);
            return Match(f, a.Id.WithAsm(), g, b.Id.WithAsm());
        }

        /// <summary>
        /// Verifies that two 8-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator</param>
        /// <param name="gId">The identity of the second operator</param>
        TestCaseRecord Match(UnaryOp8 f, OpIdentity fId, UnaryOp8 g, OpIdentity gId)
        {
            var w = w8;
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    Eq.Checker.eq(f(x),g(x));
                }
            }

            return TestAction(check, match(fId, gId));
        }

        /// <summary>
        /// Verifies that two 16-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator</param>
        /// <param name="gId">The identity of the second operator</param>
        TestCaseRecord Match(UnaryOp16 f, OpIdentity fId, UnaryOp16 g, OpIdentity gId)
        {
            var w = w16;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    var a = f(x);
                    var b = g(x);
                    Eq.Checker.eq(f(x),g(x));
                }
            }

            return TestAction(check, match(fId, gId));
        }

        /// <summary>
        /// Verifies that two 32-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator</param>
        /// <param name="gId">The identity of the second operator</param>
        TestCaseRecord Match(UnaryOp32 f, OpIdentity fId, UnaryOp32 g, OpIdentity gId)
        {
            var w = w32;
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    var a = f(x);
                    var b = g(x);
                    Eq.Checker.eq(f(x),g(x));
                }
            }

            return TestAction(check, match(fId, gId));
        }

        /// <summary>
        /// Verifies that two 64-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator</param>
        /// <param name="gId">The identity of the second operator</param>
        TestCaseRecord Match(UnaryOp64 f, OpIdentity fId, UnaryOp64 g, OpIdentity gId)
        {
            var w = w64;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    var a = f(x);
                    var b = g(x);
                    Eq.Checker.eq(f(x),g(x));
                }
            }

            return TestAction(check, match(fId, gId));
        }

        /// <summary>
        /// Verifies that two 128-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator</param>
        /// <param name="gId">The identity of the second operator</param>
        TestCaseRecord Match(UnaryOp128 f, OpIdentity fId, UnaryOp128 g, OpIdentity gId)
        {
            var w = w128;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    var a = f(x);
                    var b = g(x);
                    Eq.Checker.eq(f(x),g(x));
                }
            }

            return TestAction(check, match(fId, gId));
        }

        /// <summary>
        /// Verifies that two 128-bit binary operators agree over a random set of points
        /// </summary>
        /// <param name="f">The first operator</param>
        /// <param name="fId">The identity of the first operator</param>
        /// <param name="g">The second operator</param>
        /// <param name="gId">The identity of the second operator</param>
        TestCaseRecord Match(UnaryOp256 f, OpIdentity fId, UnaryOp256 g, OpIdentity gId)
        {
            var w = w256;
            void check()
            {
                for(var i=0; i < RepCount; i++)
                {
                    var x = Random.Cell(w);
                    var y = Random.Cell(w);
                    var a = f(x);
                    var b = g(x);
                    Eq.Checker.eq(f(x),g(x));
                }
            }

            return TestAction(check, match(fId, gId));
        }
    }
}