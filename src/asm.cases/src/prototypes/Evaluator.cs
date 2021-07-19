//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static BinaryBitLogicKind;
    using static math;
    using static core;

    partial struct Prototypes
    {
        [ApiHost(prototypes + dispatcher)]
        public readonly struct Dispatcher
        {
           [Op]
            public ulong Eval(ulong a, ulong b, BinaryBitLogicKind k, ReadOnlySpan<Func<ulong,ulong,ulong>> f)
            {
                switch(k)
                {
                    case False:
                        return skip(f,0)(a,b);
                    case And:
                        return skip(f,1)(a,b);
                    case CNonImpl:
                        return skip(f,2)(a,b);
                    case LProject:
                        return skip(f,3)(a,b);
                    case NonImpl:
                        return skip(f,4)(a,b);
                    case RProject:
                        return skip(f,5)(a,b);
                    case Xor:
                        return skip(f,6)(a,b);
                    case Or:
                        return skip(f,7)(a,b);
                    case Nor:
                        return skip(f,8)(a,b);
                    case Xnor:
                        return skip(f,9)(a,b);
                    case RNot:
                        return skip(f,10)(a,b);
                    case Impl:
                        return skip(f,11)(a,b);
                    case LNot:
                        return skip(f,12)(a,b);
                    case CImpl:
                        return skip(f,13)(a,b);
                    case Nand:
                        return skip(f,14)(a,b);
                    case True:
                        return skip(f,15)(a,b);
                }

                return ulong.MaxValue;
            }
        }

        //[ApiHost(prototypes + dot + evaluator)]
        public readonly struct Evaluator
        {
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

        //[ApiHost(prototypes + evaluator + contracted)]
        public readonly struct ContractedEvaluator : IEvaluator
        {
            readonly Evaluator E;

            [Op]
            public static IEvaluator create()
                => new ContractedEvaluator(new Evaluator());

            ContractedEvaluator(Evaluator e)
            {
                E = e;
            }

            [Op]
            public sbyte Eval(sbyte a, sbyte b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public byte Eval(byte a, byte b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public short Eval(short a, short b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public ushort Eval(ushort a, ushort b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public int Eval(int a, int b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public uint Eval(uint a, uint b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public long Eval(long a, long b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public ulong Eval(ulong a, ulong b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);
        }


        //[ApiHost(prototypes + eval + client)]
        public readonly struct EvalClient
        {
            readonly Evaluator E;

            [Op]
            public static EvalClient create()
                => new EvalClient(new Evaluator());

            EvalClient(Evaluator e)
            {
                E = e;
            }

            [Op]
            public sbyte Eval(sbyte a, sbyte b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public byte Eval(byte a, byte b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public short Eval(short a, short b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public ushort Eval(ushort a, ushort b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public int Eval(int a, int b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public uint Eval(uint a, uint b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public long Eval(long a, long b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);

            [Op]
            public ulong Eval(ulong a, ulong b, BinaryBitLogicKind k)
                => E.Eval(a,b,k);
        }


        public interface IEvaluator
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
    }
}