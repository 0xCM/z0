//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;
    using static math;

    using K = BinaryBitLogicKind;
    using C = BitOpCalc;

    /// <summary>
    /// c  | b |  a | 0000
    /// </summary>
    public readonly struct BitOpCalc
    {
        internal const byte LeftInputIndex = 4;

        internal const byte RightInputIndex = 5;

        internal const byte ResultIndex = 6;

        readonly byte Storage;

        [MethodImpl(Inline)]
        public BitOpCalc(byte data)
        {
            Storage = data;
        }

        public K Operator
        {
            [MethodImpl(Inline)]
            get => (K)(0xF & Storage);
        }

        public bit LeftInput
        {
            [MethodImpl(Inline)]
            get => bit.test(Storage, LeftInputIndex);
        }

        public bit RightInput
        {
            [MethodImpl(Inline)]
            get => bit.test(Storage, RightInputIndex);
        }

        public bit Result
        {
            [MethodImpl(Inline)]
            get => bit.test(Storage, ResultIndex);
        }

        public string Format()
            => BitOpFormatter.service().Format(this);

        public string Format(BitOpFormatter.FormatOption option)
            => BitOpFormatter.service().Format(this, option);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BitOpCalc(byte src)
            => new BitOpCalc(src);
    }

    public class BitOpFormatter
    {
        public static BitOpFormatter service()
            => new BitOpFormatter();

        Symbols<K> OpSymbols;

        CharBlock16 Buffer;

        public BitOpFormatter()
        {
            OpSymbols = Symbols.index<K>();
            Buffer = CharBlock16.Null;
        }

        public enum FormatOption : byte
        {
            Default,

            Functional,

            Bitstrings
        }

        void ClearBuffer()
        {
            Buffer = CharBlock16.Null;
        }

        public string Format(BitOpCalc src, FormatOption option = default)
        {
            ClearBuffer();
            var dst = Buffer.Data;
            var i=0u;
            var length = Render(src, ref i, dst, option);
            return text.format(slice(dst,0,length));
        }

        public static CharBlock4 bitstring(K src)
        {
            var dst = CharBlock4.Null;
            BitRender.render4((byte)src, dst.Data);
            return dst;
        }

        uint Functional(BitOpCalc src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var op = src.Operator;
            text.copy(OpSymbols[op].Expr.Text, ref i, dst);
            seek(dst,i++) = Chars.LParen;
            seek(dst,i++) = src.LeftInput;
            seek(dst,i++) = Chars.Comma;
            seek(dst,i++) = src.RightInput;
            seek(dst,i++) = Chars.RParen;
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Chars.Eq;
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = src.Result;
            return i - i0;
        }

        uint BitStrings(BitOpCalc src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var op = src.Operator;
            text.copy(bitstring(src.Operator), ref i, dst);
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = src.LeftInput;
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = src.RightInput;
            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = src.Result;
            return i - i0;
        }

        public uint Render(BitOpCalc src, ref uint i, Span<char> dst, FormatOption option = default)
        {
            switch(option)
            {
                case FormatOption.Functional:
                    return Functional(src, ref i, dst);
                case FormatOption.Bitstrings:
                    return BitStrings(src, ref i, dst);
                default:
                    return Functional(src, ref i, dst);
            }
        }
    }

    [ApiHost]
    public readonly struct BitStates
    {
        public static uint compute(W1 w, Span<BitOpCalc> dst)
        {
            var m=0u;
            for(var i=0; i<16; i++)
            {
                var op = (K)i;
                for(var j=0; j<2; j++)
                {
                    var a = (bit)j;
                    for(var k=0; k<2; k++)
                    {
                        var b = (bit)k;
                        seek(dst,m++) = compute(op,a,b);
                    }
                }
            }
            return m;
        }

        [Op]
        public static BitOpCalc compute(K op, bit a, bit b)
        {
            const byte AIx = C.LeftInputIndex;
            const byte BIx = C.RightInputIndex;
            const byte RIx = C.ResultIndex;

            var x = (byte)a;
            var y = (byte)b;
            var f = (byte)op;
            switch(op)
            {
                case K.False:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.@false(a,b), RIx));
                case K.And:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.and(a,b), RIx));
                case K.CNonImpl:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.cnonimpl(a,b), RIx));
                case K.Left:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.left(a,b), RIx));
                case K.NonImpl:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.nonimpl(a,b), RIx));
                case K.Right:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.right(a,b), RIx));
                case K.Xor:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.xor(a,b), RIx));
                case K.Or:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.or(a,b), RIx));
                case K.Nor:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.nor(a,b), RIx));
                case K.Xnor:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.xnor(a,b), RIx));
                case K.RNot:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.rnot(a,b), RIx));
                case K.Impl:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.impl(a,b), RIx));
                case K.LNot:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.lnot(a,b), RIx));
                case K.CImpl:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.cimpl(a,b), RIx));
                case K.Nand:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.nand(a,b), RIx));
                case K.True:
                    return or(f, sll(x, AIx), sll(y, BIx), sll(bit.@true(a,b), RIx));
                default:
                    return default;
            }
        }
    }
}