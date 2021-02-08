//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Hex8Seq;

    using BL = ScalarBitLogic;

    [ApiDeep]
    public readonly ref struct Switch16
    {
        readonly Span<MemoryAddress> Slots;

        [MethodImpl(NotInline)]
        public byte Op00(byte a, byte b)
            => BL.@false(a,b);

        [MethodImpl(NotInline)]
        public byte Op01(byte a, byte b)
            => BL.and(a,b);

        [MethodImpl(NotInline)]
        public byte Op02(byte a, byte b)
            => BL.cnonimpl(a,b);

        [MethodImpl(NotInline)]
        public byte Op03(byte a, byte b)
            => BL.left(a,b);

        [MethodImpl(NotInline)]
        public byte Op04(byte a, byte b)
            => BL.nonimpl(a,b);

        [MethodImpl(NotInline)]
        public byte Op05(byte a, byte b)
            => BL.right(a,b);

        [MethodImpl(NotInline)]
        public byte Op06(byte a, byte b)
            => BL.xor(a,b);

        [MethodImpl(NotInline)]
        public byte Op07(byte a, byte b)
            => BL.or(a,b);

        [MethodImpl(NotInline)]
        public byte Op08(byte a, byte b)
            => BL.nor(a,b);

        [MethodImpl(NotInline)]
        public byte Op09(byte a, byte b)
            => BL.xnor(a,b);

        [MethodImpl(NotInline)]
        public byte Op0a(byte a, byte b)
            => BL.rnot(a,b);

        [MethodImpl(NotInline)]
        public byte Op0b(byte a, byte b)
            => BL.impl(a,b);

        [MethodImpl(NotInline)]
        public byte Op0c(byte a, byte b)
            => BL.lnot(a,b);

        [MethodImpl(NotInline)]
        public byte Op0d(byte a, byte b)
            => BL.cimpl(a,b);

        public byte Call(X00 op, byte a, byte b)
            => Op00(a,b);

        public byte Call(X01 op, byte a, byte b)
            => Op01(a,b);

        public byte Call(X02 op, byte a, byte b)
            => Op02(a,b);

        public byte Call(X03 op, byte a, byte b)
            => Op03(a,b);

        public byte Call(X04 op, byte a, byte b)
            => Op04(a,b);

        public byte Call(X05 op, byte a, byte b)
            => Op05(a,b);

        public byte Call(X06 op, byte a, byte b)
            => Op06(a,b);

        public byte Call(X07 op, byte a, byte b)
            => Op07(a,b);

        public byte Call(X08 op, byte a, byte b)
            => Op08(a,b);

        public byte Call(X09 op, byte a, byte b)
            => Op09(a,b);

        public byte Call(X0A op, byte a, byte b)
            => Op0a(a,b);

        public byte Call(X0B op, byte a, byte b)
            => Op0b(a,b);

        public byte Call(X0C op, byte a, byte b)
            => Op0c(a,b);

        public byte Eval2(byte a, byte b, Hex8Seq code)
        {
            switch(code)
            {
                case x00:
                    goto op00;
                case x01:
                    goto op01;
                case x02:
                    goto op02;
                case x03:
                    goto op03;
                case x04:
                    goto op04;
                case x05:
                    goto op05;
                case x06:
                    goto op06;
                case x07:
                    goto op07;
                case x08:
                    goto op08;
                case x09:
                    goto op09;
                case x0a:
                    goto op0a;
                case x0b:
                    goto op0b;
                default:
                    return 0;
            }
            op00:
                return Op00(a,b);
            op01:
                return Op01(a,b);
            op02:
                return Op02(a,b);
            op03:
                return Op03(a,b);
            op04:
                return Op04(a,b);
            op05:
                return Op05(a,b);
            op06:
                return Op06(a,b);
            op07:
                return Op07(a,b);
            op08:
                return Op08(a,b);
            op09:
                return Op09(a,b);
            op0a:
                return Op0a(a,b);
            op0b:
                return Op0b(a,b);
        }
    }
}