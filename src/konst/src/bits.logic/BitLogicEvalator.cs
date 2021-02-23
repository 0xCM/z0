//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BinaryBitLogicKind;
    using static ScalarBitLogic;

    public interface IBitLogicEvaluator
    {
        sbyte Eval(sbyte a, sbyte b, BinaryBitLogicKind k);

        byte Eval(byte a, byte b, BinaryBitLogicKind k);

        short Eval(short a, short b, BinaryBitLogicKind k);

        ushort Eval(ushort a, ushort b, BinaryBitLogicKind k);

        int Eval(int a, int b, BinaryBitLogicKind k);

        uint Eval(uint a, uint b, BinaryBitLogicKind k);

        long Eval(long a, long b, BinaryBitLogicKind k);

        ulong Eval(ulong a, ulong b, BinaryBitLogicKind k);
    }

    [ApiHost]
    public readonly struct BitLogicEvaluator : IBitLogicEvaluator
    {
        [Op]
        public static IBitLogicEvaluator create()
            => default(BitLogicEvaluator);

        [Op]
        public sbyte Eval(sbyte a, sbyte b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public byte Eval(byte a, byte b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public short Eval(short a, short b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public ushort Eval(ushort a, ushort b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public int Eval(int a, int b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public uint Eval(uint a, uint b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public long Eval(long a, long b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }

        [Op]
        public ulong Eval(ulong a, ulong b, BinaryBitLogicKind k)
        {
            switch(k)
            {
                case False:
                    return @false(a,b);
                case And:
                    return and(a,b);
                case CNonImpl:
                    return cnonimpl(a,b);
                case LProject:
                    return left(a,b);
                case NonImpl:
                    return nonimpl(a,b);
                case RProject:
                    return right(a,b);
                case Xor:
                    return xor(a,b);
                case Or:
                    return or(a,b);
                case Nor:
                    return nor(a,b);
                case Xnor:
                    return xnor(a,b);
                case RNot:
                    return rnot(a,b);
                case Impl:
                    return impl(a,b);
                case LNot:
                    return lnot(a,b);
                case CImpl:
                    return cimpl(a,b);
                case Nand:
                    return nand(a,b);
                case True:
                    return @true(a,b);
            }

            return 0;
        }
    }
}