//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmCodes;

    /// <summary>
    /// Generates <see cref='RexBCode'/> tables
    /// </summary>
    public sealed class RexBGenerator : AsmModelFactory<RexBGenerator>
    {
        // RexBBits:[Index[00000] | Token[000]]
        public static RexBCode rexb(RexBToken token, RegIndexCode r)
            => new RexBCode(token,r);

        Symbols<RexBToken> _Tokens;

        [MethodImpl(Inline)]
        static RexBToken None()
            => RexBToken.None;

        [MethodImpl(Inline)]
        static RexBToken rb()
            => RexBToken.rb;

        [MethodImpl(Inline)]
        static RexBToken rw()
            => RexBToken.rw;

        [MethodImpl(Inline)]
        static RexBToken rd()
            => RexBToken.rd;

        [MethodImpl(Inline)]
        static RexBToken ro()
            => RexBToken.ro;

        [MethodImpl(Inline)]
        static RexBToken NA()
            => RexBToken.NA;

        [MethodImpl(Inline)]
        static RexBToken NE()
            => RexBToken.NE;

        public RexBGenerator()
        {
            _Tokens = Symbols.index<RexBToken>();
        }

        ReadOnlySpan<RexBToken> Tokens
        {
            [MethodImpl(Inline)]
            get => _Tokens.Kinds;
        }

        public ReadOnlySpan<RexBCode> Generate()
        {
            var dst = span<RexBCode>(256);
            var i=0u;
            var counter = 0u;
            counter += IncludeGp8(ref i, dst);
            counter += IncludeGp16(ref i, dst);
            counter += IncludeGp32(ref i, dst);
            counter += IncludeGp8(ref i, dst);
            counter += IncludeGp8Hi(ref i, dst);
            return slice(dst,0,counter);
        }

        byte IncludeGp8(ref uint i, Span<RexBCode> dst)
        {
            const byte RegCount = 16;
            var i0 = i;
            var j = z8;
            var regs = Gp8Regs().Kinds;
            for(j=0; j<RegCount; j++, i++)
            {
                var token = j<4 ? None() : rb();
                seek(dst,i) = rexb(token, (RegIndexCode)skip(regs,j));
            }

            return (byte)(i - i0);
        }

        byte IncludeGp16(ref uint i, Span<RexBCode> dst)
        {
            const byte RegCount = 16;
            var i0 = i;
            var regs = Gp16Regs().Kinds;
            var j = z8;
            for(j=0; j<RegCount; j++)
            {
                var token = j<8 ? None() : rw();
                seek(dst,i) = rexb(token, (RegIndexCode)skip(regs,j));
            }

            return (byte)(i - i0);
        }

        byte IncludeGp32(ref uint i, Span<RexBCode> dst)
        {
            const byte RegCount = 16;
            var i0 = i;
            var j = z8;
            var regs = Gp32Regs().Kinds;
            for(j=0; j<RegCount; j++)
            {
                var token = j<8 ? None() : rd();
                seek(dst,i) = rexb(token, (RegIndexCode)skip(regs,j));
            }
            return (byte)(i - i0);
        }

        byte IncludeGp64(ref uint i, Span<RexBCode> dst)
        {
            const byte RegCount = 16;
            var i0 = i;
            var j = z8;
            var regs = Gp64Regs().Kinds;
            for(j=0; j<RegCount; j++)
            {
                var token = (i<4 ? None() : (i < 8 ? NA() : ro()));
                seek(dst,i) = rexb(token, (RegIndexCode)skip(regs,j));
            }
            return (byte)(i - i0);
        }

        byte IncludeGp8Hi(ref uint i, Span<RexBCode> dst)
        {
            const byte RegCount = 4;
            var i0 = i;
            var regs = Gp8Regs(true).Kinds;
            var j = z8;
            for(j=0; j<RegCount; j++)
            {
                var token = NE();
                seek(dst,i) = rexb(token, (RegIndexCode)skip(regs,j));
            }
            return (byte)(i - i0);
        }

    }
}