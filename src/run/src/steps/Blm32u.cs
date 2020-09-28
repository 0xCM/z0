//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static BinaryBitLogicKind;

    using BL = BitLogic.Scalar;

    [ApiDataType]
    public readonly struct Blm32u
    {
        [MethodImpl(NotInline)]
        static uint @false(uint a, uint b)
            => BL.@false(a,b);

        [MethodImpl(NotInline)]
        static uint and(uint a, uint b)
            => BL.and(a,b);

        [MethodImpl(NotInline)]
        static uint cnonimpl(uint a, uint b)
            => BL.cnonimpl(a,b);

        [MethodImpl(NotInline)]
        static uint left(uint a, uint b)
            => BL.left(a,b);

        [MethodImpl(NotInline)]
        static uint nonimpl(uint a, uint b)
            => BL.nonimpl(a,b);

        [MethodImpl(NotInline)]
        static uint right(uint a, uint b)
            => BL.right(a,b);

        [MethodImpl(NotInline)]
        static uint xor(uint a, uint b)
            => BL.xor(a,b);

        [MethodImpl(NotInline)]
        static uint or(uint a, uint b)
            => BL.or(a,b);

        [MethodImpl(NotInline)]
        static uint nor(uint a, uint b)
            => BL.nor(a,b);

        [MethodImpl(NotInline)]
        static uint xnor(uint a, uint b)
            => BL.xnor(a,b);

        [MethodImpl(NotInline)]
        static uint nand(uint a, uint b)
            => BL.nand(a,b);

        [Ignore]
        public uint Evaluate<K>(uint a, uint b, K k = default)
            where K : unmanaged, IBitLogicKind
        {
            return 0;
        }

        public uint Evaluate(uint a, uint b, BinaryBitLogicKind k)
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
            }

            return 0;
        }
    }
}