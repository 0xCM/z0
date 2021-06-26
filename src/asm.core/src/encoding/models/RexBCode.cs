//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static core;
    using static AsmOpCodeTokens;
    using static AsmCodes;
    using K = AsmCodes;

    public struct RexBCode
    {
        readonly byte Value;

        internal RexBCode(RexBToken token, RegIndex reg, RegWidth width)
        {
            Value = (byte)token;
        }

        public byte Encoded
        {
            get => default;
        }
    }


    public readonly struct RexBCodes
    {
        public static ReadOnlySpan<RexBCode> generate()
        {

            return default;
        }

        static byte include(ReadOnlySpan<Gp8> src, ref uint i, Span<RexBCode> dst)
        {
            var i0 = i;


            return (byte)(i - i0);
        }

        static byte include(ReadOnlySpan<Gp8Hi> src, ref uint i, Span<RexBCode> dst)
        {
            var i0 = i;


            return (byte)(i - i0);
        }

        static byte include(ReadOnlySpan<Gp16> src, ref uint i, Span<RexBCode> dst)
        {
            var i0 = i;


            return (byte)(i - i0);
        }

        static byte include(ReadOnlySpan<Gp32> src, ref uint i, Span<RexBCode> dst)
        {
            var i0 = i;


            return (byte)(i - i0);
        }

        static byte include(ReadOnlySpan<Gp64> src, ref uint i, Span<RexBCode> dst)
        {
            var i0 = i;


            return (byte)(i - i0);
        }


    }
}