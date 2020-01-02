//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static OpDelegate;
    using static OpDelegates;

    public class t_bitlogic : t_gmath<t_bitlogic>
    {

        public void and_check()
        {
            const string name = "and";

            and_check(binary(math.and, name, z8));
            and_check(binary(math.and, name, z8i));
            and_check(binary(math.and, name, z16));
            and_check(binary(math.and, name, z16i));
            and_check(binary(math.and, name, z32));
            and_check(binary(math.and, name, z32i));
            and_check(binary(math.and, name, z64));
            and_check(binary(math.and, name, z64i));

        }

        [MethodImpl(Inline)]
        void and_check<T>(BinaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckBinaryPredMatch(expect, GX.and(t), t);

        public void nand_check()
        {
            const string name = "nand";

            nand_check(binary(math.nand, name, z8));
            nand_check(binary(math.nand, name, z8i));
            nand_check(binary(math.nand, name, z16));
            nand_check(binary(math.nand, name, z16i));
            nand_check(binary(math.nand, name, z32));
            nand_check(binary(math.nand, name, z32i));
            nand_check(binary(math.nand, name, z64));
            nand_check(binary(math.nand, name, z64i));

        }

        [MethodImpl(Inline)]
        void nand_check<T>(BinaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckBinaryPredMatch(expect, GX.nand(t), t);

        public void or_check()
        {
            const string name = "or";

            or_check(binary(math.or, name, z8));
            or_check(binary(math.or, name, z8i));
            or_check(binary(math.or, name, z16));
            or_check(binary(math.or, name, z16i));
            or_check(binary(math.or, name, z32));
            or_check(binary(math.or, name, z32i));
            or_check(binary(math.or, name, z64));
            or_check(binary(math.or, name, z64i));

        }

        [MethodImpl(Inline)]
        void or_check<T>(BinaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckBinaryPredMatch(expect, GX.or(t), t);

        public void nor_check()
        {
            const string name = "nor";

            nor_check(binary(math.nor, name, z8));
            nor_check(binary(math.nor, name, z8i));
            nor_check(binary(math.nor, name, z16));
            nor_check(binary(math.nor, name, z16i));
            nor_check(binary(math.nor, name, z32));
            nor_check(binary(math.nor, name, z32i));
            nor_check(binary(math.nor, name, z64));
            nor_check(binary(math.nor, name, z64i));

        }

        [MethodImpl(Inline)]
        void nor_check<T>(BinaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckBinaryPredMatch(expect, GX.nor(t), t);

        public void xor_check()
        {
            const string name = "xor";

            xor_check(binary(math.xor, name, z8));
            xor_check(binary(math.xor, name, z8i));
            xor_check(binary(math.xor, name, z16));
            xor_check(binary(math.xor, name, z16i));
            xor_check(binary(math.xor, name, z32));
            xor_check(binary(math.xor, name, z32i));
            xor_check(binary(math.xor, name, z64));
            xor_check(binary(math.xor, name, z64i));

        }

        [MethodImpl(Inline)]
        void xor_check<T>(BinaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckBinaryPredMatch(expect, GX.xor(t), t);

        public void xnor_check()
        {
            const string name = "xnor";

            xnor_check(binary(math.xnor, name, z8));
            xnor_check(binary(math.xnor, name, z8i));
            xnor_check(binary(math.xnor, name, z16));
            xnor_check(binary(math.xnor, name, z16i));
            xnor_check(binary(math.xnor, name, z32));
            xnor_check(binary(math.xnor, name, z32i));
            xnor_check(binary(math.xnor, name, z64));
            xnor_check(binary(math.xnor, name, z64i));

        }

        [MethodImpl(Inline)]
        void xnor_check<T>(BinaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckBinaryPredMatch(expect, GX.xnor(t), t);

        public void not_check()
        {
            const string name = "not";
        
            not_check(unary(math.not, name, z8));
            not_check(unary(math.not, name, z8i));
            not_check(unary(math.not, name, z16));
            not_check(unary(math.not, name, z16i));
            not_check(unary(math.not, name, z32));
            not_check(unary(math.not, name, z32i));
            not_check(unary(math.not, name, z64));
            not_check(unary(math.not, name, z64i));

        }

        [MethodImpl(Inline)]
        void not_check<T>(UnaryDelegate<T> expect, T t = default)
            where  T : unmanaged
                => CheckUnaryMatch(expect, GX.not(t), t);


    }
}