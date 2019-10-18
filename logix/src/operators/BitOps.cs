//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BitLogic;
    using static LogicOps;
    using static TernaryLogicOpKind;

    public static class BitOps
    {
        static bit Off
        {
            [MethodImpl(Inline)]
            get => bit.Off;
        }

        static bit On
        {
            [MethodImpl(Inline)]
            get => bit.On;
        }

        /// <summary>
        /// Advertises the supported ternary opeators
        /// </summary>
        public static IEnumerable<TernaryLogicOpKind> TernaryKinds
            => range((byte)1,(byte)X30).Cast<TernaryLogicOpKind>();

        /// <summary>
        /// Evaluates a specified ternary operator over the operands
        /// </summary>
        /// <param name="op">The ternary operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static bit eval(TernaryLogicOpKind op, bit a, bit b, bit c)
            => BitOps.lookup(op)(a,b,c);

        public static UnaryOp<bit> lookup(UnaryLogicOpKind id)
        {
            switch(id)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return identity;
                default: return dne<bit>(id);
            }
        }

        public static BinaryOp<bit> lookup(BinaryLogicOpKind id)
        {
            switch(id)
            {
                case BinaryLogicOpKind.And: return and;
                case BinaryLogicOpKind.Nand: return nand;
                case BinaryLogicOpKind.Or: return or;
                case BinaryLogicOpKind.Nor: return nor;
                case BinaryLogicOpKind.XOr: return xor;
                case BinaryLogicOpKind.Xnor: return xnor;
                case BinaryLogicOpKind.AndNot: return andnot;
                default: return dne<bit>(id);
            }
        }


        public static TernaryOp<bit> lookup(TernaryLogicOpKind id)
        {
            switch(id)
            {
                case X01: return f01;
                case X02: return f02;
                case X03: return f03;
                case X04: return f04;
                case X05: return f05;
                case X06: return f06;
                case X07: return f07;
                case X08: return f08;
                case X09: return f09;
                case X0A: return f0a;
                case X0B: return f0b;
                case X0C: return f0c;
                case X0D: return f0d;
                case X0E: return f0e;
                case X0F: return f0f;
                case X10: return f10;
                case X11: return f11;
                case X12: return f12;
                case X13: return f13;
                case X14: return f14;
                case X15: return f15;
                case X16: return f16;
                case X17: return f17;
                case X18: return f18;
                case X19: return f19;
                case X1A: return f1a;
                case X1B: return f1b;
                case X1C: return f1c;
                case X1D: return f1d;
                case X1E: return f1e;
                case X1F: return f1f;
                case X20: return f20;
                case X21: return f21;
                case X22: return f22;
                case X23: return f23;
                case X24: return f24;
                case X25: return f25;
                case X26: return f26;
                case X27: return f27;
                case X28: return f28;
                case X29: return f29;
                case X2A: return f2a;
                case X2B: return f2b;
                case X2C: return f2c;
                case X2D: return f2d;
                case X2E: return f2e;
                case X2F: return f2f;
                case X30: return f30;
                default: return dne<bit>(id);

            }
        }
    
        public static BitMatrix<N4,N3,byte> table(BinaryLogicOpKind op)
        {
            var tt = BitMatrix.Alloc<N4,N3,byte>();
            var f = lookup(op);
            tt[0] = BitVector.Define<N3,byte>(Bits.pack3(f(Off, Off), Off, Off));
            tt[1] = BitVector.Define<N3,byte>(Bits.pack3(f(On, Off), Off, On));
            tt[2] = BitVector.Define<N3,byte>(Bits.pack3(f(Off, On), On, Off));
            tt[3] = BitVector.Define<N3,byte>(Bits.pack3(f(On, On),  On, On));
            return tt;
        }

        public static BitMatrix<N8,N4, byte> table(TernaryLogicOpKind op)
        {
            var tt = BitMatrix.Alloc<N8,N4,byte>();
            var f = lookup(op);
            tt[0] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, Off, Off), Off, Off, Off));
            tt[1] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, Off, On), Off, Off, On));
            tt[2] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, On, Off), Off, On, Off));
            tt[3] = BitVector.Define<N4,byte>(Bits.pack4(f(Off, On, On), Off, On, On));
            tt[4] = BitVector.Define<N4,byte>(Bits.pack4(f(On, Off, Off), On, Off, Off));
            tt[5] = BitVector.Define<N4,byte>(Bits.pack4(f(On, Off, On), On, Off, On));
            tt[6] = BitVector.Define<N4,byte>(Bits.pack4(f(On, On, Off), Off, On, On));
            tt[7] = BitVector.Define<N4,byte>(Bits.pack4(f(On, On, On), On, On, On));
            return tt;
        }

    }

}