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
    using static BitOps;
    using static LogicOps;
    using static TernaryLogicOpKind;

    public static class BitOpApi
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
            => range((byte)1,(byte)X4F).Cast<TernaryLogicOpKind>();

        /// <summary>
        /// Advertises the supported binary opeators
        /// </summary>
        public static IEnumerable<BinaryLogicOpKind> BinaryKinds
            => EnumValues.Get<BinaryLogicOpKind>().Enumerate();

        /// <summary>
        /// Evaluates a unary operator
        /// </summary>
        /// <param name="op">The ternary operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static bit eval(UnaryLogicOpKind op, bit a)
            => BitOpApi.lookup(op)(a);

        /// <summary>
        /// Evaluates a binary operator
        /// </summary>
        /// <param name="op">The ternary operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static bit eval(BinaryLogicOpKind op, bit a, bit b)
            => BitOpApi.lookup(op)(a,b);

        /// <summary>
        /// Evaluates a ternary operator
        /// </summary>
        /// <param name="op">The ternary operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline)]
        public static bit eval(TernaryLogicOpKind op, bit a, bit b, bit c)
            => BitOpApi.lookup(op)(a,b,c);

        /// <summary>
        /// Returns the kind-indentified unary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static UnaryOp<bit> lookup(UnaryLogicOpKind kind)
        {
            switch(kind)
            {
                case UnaryLogicOpKind.Not: return not;
                case UnaryLogicOpKind.Identity: return identity;
                default: return dne<bit>(kind);
            }
        }


        /// <summary>
        /// Returns the kind-indentified binary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BinaryOp<bit> lookup(BinaryLogicOpKind kind)
        {
            switch(kind)
            {
                case BinaryLogicOpKind.False: return @false;
                case BinaryLogicOpKind.And: return and;
                case BinaryLogicOpKind.Nand: return nand;
                case BinaryLogicOpKind.Or: return or;
                case BinaryLogicOpKind.Nor: return nor;
                case BinaryLogicOpKind.XOr: return xor;
                case BinaryLogicOpKind.Xnor: return xnor;
                case BinaryLogicOpKind.AndNot: return andnot;
                case BinaryLogicOpKind.True: return @true;
                case BinaryLogicOpKind.Implies: return implies;
                default: return dne<bit>(kind);
            }
        }

        /// <summary>
        /// Returns the kind-indentified ternary operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static TernaryOp<bit> lookup(TernaryLogicOpKind kind)
        {
            switch(kind)
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
                case X31: return f31;
                case X32: return f32;
                case X33: return f33;
                case X34: return f34;
                case X35: return f35;
                case X36: return f36;
                case X37: return f37;
                case X38: return f38;
                case X39: return f39;
                case X3A: return f3a;
                case X3B: return f3b;
                case X3C: return f3c;
                case X3D: return f3d;
                case X3E: return f3e;
                case X3F: return f3f;
                case X40: return f40;
                case X41: return f41;
                case X42: return f42;
                case X43: return f43;
                case X44: return f44;
                case X45: return f45;
                case X46: return f46;
                case X47: return f47;
                case X48: return f48;
                case X49: return f49;
                case X4A: return f4a;
                case X4B: return f4b;
                case X4C: return f4c;
                case X4D: return f4d;
                case X4E: return f4e;
                case X4F: return f4f;
                default: return dne<bit>(kind);

            }
        }
    
        /// <summary>
        /// Returns the truth table for a kind-identified operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BitMatrix<N4,N3,byte> table(BinaryLogicOpKind kind)
        {
            var tt = BitMatrix.Alloc<N4,N3,byte>();
            var f = lookup(kind);
            tt[0] = BitVector.Define<N3,byte>(Bits.pack3(f(Off, Off), Off, Off));
            tt[1] = BitVector.Define<N3,byte>(Bits.pack3(f(On, Off), Off, On));
            tt[2] = BitVector.Define<N3,byte>(Bits.pack3(f(Off, On), On, Off));
            tt[3] = BitVector.Define<N3,byte>(Bits.pack3(f(On, On),  On, On));
            return tt;
        }

        /// <summary>
        /// Returns the truth table for a kind-identified operator
        /// </summary>
        /// <param name="kind">The operator kind</param>
        public static BitMatrix<N8,N4, byte> table(TernaryLogicOpKind kind)
        {
            var tt = BitMatrix.Alloc<N8,N4,byte>();
            var f = lookup(kind);
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