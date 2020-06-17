//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static LogicSig;
    using static BitLogix;    

    using BLK = BinaryLogicKind;

    partial class BitLogixOps
    {
        [MethodImpl(Inline)]
        public static bit eval<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind
                => eval_1(a,b, kind);

        [MethodImpl(Inline)]
        static bit eval_1<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind
        {
            if(typeof(F) == typeof(Kinds.True))
                return @true(a, b);
            else if(typeof(F) == typeof(Kinds.False))  
                return @false(a, b);
            else if(typeof(F) == typeof(Kinds.And))
                return and(a, b);
            else if (typeof(F) == typeof(Kinds.Nand))
                return nand(a, b);
            else
                return eval_2(a, b, kind);
        }

        [MethodImpl(Inline)]
        static bit eval_2<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind
        {
            if (typeof(F) == typeof(Kinds.Or))
                return or(a, b);
            else if (typeof(F) == typeof(Kinds.Nor))
                return nor(a, b);
            else if (typeof(F) == typeof(Kinds.Xor))
                return xor(a, b);
            else if (typeof(F) == typeof(Kinds.Xnor))
                return xnor(a, b);
            else
                return eval_3(a, b, kind);
        }

        [MethodImpl(Inline)]
        static bit eval_3<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind
        {
            if (typeof(F) == typeof(Kinds.Impl))
                return impl(a, b);
            else if (typeof(F) == typeof(Kinds.NonImpl))
                return nonimpl(a, b);
            else if (typeof(F) == typeof(Kinds.LProject))
                return left(a, b);
            else if (typeof(F) == typeof(Kinds.RProject))
                return right(a, b);
            else
                return eval_4(a, b, kind);
        }

        [MethodImpl(Inline)]
        static bit eval_4<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind
        {
            if (typeof(F) == typeof(Kinds.LNot))
                return lnot(a, b);
            else if (typeof(F) == typeof(Kinds.RNot))
                return rnot(a, b);
            else if (typeof(F) == typeof(Kinds.CImpl))
                return cimpl(a, b);
            else if (typeof(F) == typeof(Kinds.CNonImpl))
                return cnonimpl(a, b);
            else
                throw Unsupported.define<F>();
        }

        /// <summary>
        /// Evaluates a binary operator without lookup/delegate indirection
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        public static bit eval(BLK kind, bit a, bit b)
        {
            switch(kind)
            {
                case BLK.True: return @true(a,b);
                case BLK.False: return @false(a,b);

                case BLK.And: return and(a,b);
                case BLK.Nand: return nand(a,b);

                case BLK.Or: return or(a,b);
                case BLK.Nor: return nor(a,b);

                case BLK.Xor: return xor(a,b);
                case BLK.Xnor: return xnor(a,b);

                case BLK.Impl: return impl(a,b); 
                case BLK.NonImpl: return nonimpl(a,b);

                case BLK.LProject: return left(a,b);
                case BLK.RProject: return right(a,b);

                case BLK.LNot: return lnot(a,b);
                case BLK.RNot: return rnot(a,b);
                
                case BLK.CImpl: return cimpl(a,b);
                case BLK.CNonImpl: return cnonimpl(a,b);

                default: throw Unsupported.value(sig(kind));
            }
        }
    }
}