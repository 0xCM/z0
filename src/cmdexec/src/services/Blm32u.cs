//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static BinaryBitLogicKind;
    using static memory;
    using static ScalarBitLogic;


    readonly struct BitLogicOps
    {
        readonly Index<MemberAddress> Members;

        readonly Index<ClrMemberName> MemberNames;

        public static BitLogicOps init()
        {
            var methods = typeof(ScalarBitLogic).DeclaredStaticMethods().Prepare();
            return new BitLogicOps(methods);
        }

        BitLogicOps(MethodInfo[] src)
        {
            Members = src.Select(Addresses.member);
            Array.Sort(Members);
            var count = Members.Length;
            MemberNames = alloc<ClrMemberName>(count);
            ref var name = ref MemberNames.First;
            for(var i=0; i<count; i++)
                seek(name,i) = Members[i].Member.Name;
        }

    }
    [ApiHost]
    public unsafe readonly struct BitLogicEvaluator
    {
        readonly BitLogicOps Cache;

        [MethodImpl(Inline)]
        internal BitLogicEvaluator(BitLogicOps cache)
        {
            Cache = cache;
        }

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