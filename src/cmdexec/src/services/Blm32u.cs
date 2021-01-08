//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;
    using static BinaryBitLogicKind;

    using BL = BitLogic.Scalar;

    [ApiType]
    public unsafe readonly struct Blm32u
    {
        static MethodInfo[] Methods;

        static MemoryAddress Address;

        static MemberAddress[] MethodAddressData;

        static Blm32u()
        {
            Methods = typeof(Blm32u).DeclaredStaticMethods();
            Address = typeof(Blm32u).TypeHandle.Value.ToPointer();
            MethodAddressData = Methods.Select(Addresses.member);
            Array.Sort(MethodAddressData);
        }

        [MethodImpl(Inline)]
        public MemoryAddress TypeAddress()
            => Address;

        [MethodImpl(Inline)]
        public MemberAddress method(N0 n)
            => MethodAddressData[0];

        [MethodImpl(Inline)]
        public MemberAddress method(N1 n)
            => MethodAddressData[1];

        [MethodImpl(Inline)]
        public MemberAddress method(N2 n)
            => MethodAddressData[2];

        [MethodImpl(Inline)]
        public MemberAddress method(N3 n)
            => MethodAddressData[3];

        [MethodImpl(Inline)]
        public MemberAddress method(N4 n)
            => MethodAddressData[4];

        [MethodImpl(Inline)]
        public MemberAddress method(N5 n)
            => MethodAddressData[5];

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
        static uint rnot(uint a, uint b)
            => BL.rnot(a,b);

        [MethodImpl(NotInline)]
        static uint impl(uint a, uint b)
            => BL.impl(a,b);

        [MethodImpl(NotInline)]
        static uint lnot(uint a, uint b)
            => BL.lnot(a,b);

        [MethodImpl(NotInline)]
        static uint cimpl(uint a, uint b)
            => BL.cimpl(a,b);

        [MethodImpl(NotInline)]
        static uint nand(uint a, uint b)
            => BL.nand(a,b);

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
            }

            return 0;
        }
    }
}