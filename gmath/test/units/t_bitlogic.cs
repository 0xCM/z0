//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using static Nats;
    using S = Surrogates;


    public class t_bitlogic : t_gmath<t_bitlogic>
    {
        public void and_check()
        {
            const string name = "and";

            and_check(S.binary(math.and, name, z8));
            and_check(S.binary(math.and, name, z8i));
            and_check(S.binary(math.and, name, z16));
            and_check(S.binary(math.and, name, z16i));
            and_check(S.binary(math.and, name, z32));
            and_check(S.binary(math.and, name, z32i));
            and_check(S.binary(math.and, name, z64));
            and_check(S.binary(math.and, name, z64i));
        }

        void and_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.and(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void or_check()
        {
            const string name = "or";

            or_check(S.binary(math.or, name, z8));
            or_check(S.binary(math.or, name, z8i));
            or_check(S.binary(math.or, name, z16));
            or_check(S.binary(math.or, name, z16i));
            or_check(S.binary(math.or, name, z32));
            or_check(S.binary(math.or, name, z32i));
            or_check(S.binary(math.or, name, z64));
            or_check(S.binary(math.or, name, z64i));
        }

        void or_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.or(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void xor_check()
        {
            const string name = "xor";

            xor_check(S.binary(math.xor, name, z8));
            xor_check(S.binary(math.xor, name, z8i));
            xor_check(S.binary(math.xor, name, z16));
            xor_check(S.binary(math.xor, name, z16i));
            xor_check(S.binary(math.xor, name, z32));
            xor_check(S.binary(math.xor, name, z32i));
            xor_check(S.binary(math.xor, name, z64));
            xor_check(S.binary(math.xor, name, z64i));

        }

        void xor_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.xor(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void nand_check()
        {
            const string name = "nand";

            nand_check(S.binary(math.nand, name, z8));
            nand_check(S.binary(math.nand, name, z8i));
            nand_check(S.binary(math.nand, name, z16));
            nand_check(S.binary(math.nand, name, z16i));
            nand_check(S.binary(math.nand, name, z32));
            nand_check(S.binary(math.nand, name, z32i));
            nand_check(S.binary(math.nand, name, z64));
            nand_check(S.binary(math.nand, name, z64i));
        }

        void nand_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.nand(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void nor_check()
        {
            const string name = "nor";

            nor_check(S.binary(math.nor, name, z8));
            nor_check(S.binary(math.nor, name, z8i));
            nor_check(S.binary(math.nor, name, z16));
            nor_check(S.binary(math.nor, name, z16i));
            nor_check(S.binary(math.nor, name, z32));
            nor_check(S.binary(math.nor, name, z32i));
            nor_check(S.binary(math.nor, name, z64));
            nor_check(S.binary(math.nor, name, z64i));
        }

        void nor_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.nor(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void xnor_check()
        {
            const string name = "xnor";

            xnor_check(S.binary(math.xnor, name, z8));
            xnor_check(S.binary(math.xnor, name, z8i));
            xnor_check(S.binary(math.xnor, name, z16));
            xnor_check(S.binary(math.xnor, name, z16i));
            xnor_check(S.binary(math.xnor, name, z32));
            xnor_check(S.binary(math.xnor, name, z32i));
            xnor_check(S.binary(math.xnor, name, z64));
            xnor_check(S.binary(math.xnor, name, z64i));
        }

        void xnor_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.xnor(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void not_check()
        {
            const string name = "not";
        
            not_check(S.unary(math.not, name, z8));
            not_check(S.unary(math.not, name, z8i));
            not_check(S.unary(math.not, name, z16));
            not_check(S.unary(math.not, name, z16i));
            not_check(S.unary(math.not, name, z32));
            not_check(S.unary(math.not, name, z32i));
            not_check(S.unary(math.not, name, z64));
            not_check(S.unary(math.not, name, z64i));
        }

        void not_check<T>(S.UnaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.not(t);            
            var validator = this.UnaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);            
        }

        public void impl_check()
        {
            const string name = "impl";

            impl_check(S.binary(math.impl, name, z8));
            impl_check(S.binary(math.impl, name, z8i));
            impl_check(S.binary(math.impl, name, z16));
            impl_check(S.binary(math.impl, name, z16i));
            impl_check(S.binary(math.impl, name, z32));
            impl_check(S.binary(math.impl, name, z32i));
            impl_check(S.binary(math.impl, name, z64));
            impl_check(S.binary(math.impl, name, z64i));
        }

        void impl_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.impl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void nonimpl_check()
        {
            const string name = "nonimpl";

            nonimpl_check(S.binary(math.nonimpl, name, z8));
            nonimpl_check(S.binary(math.nonimpl, name, z8i));
            nonimpl_check(S.binary(math.nonimpl, name, z16));
            nonimpl_check(S.binary(math.nonimpl, name, z16i));
            nonimpl_check(S.binary(math.nonimpl, name, z32));
            nonimpl_check(S.binary(math.nonimpl, name, z32i));
            nonimpl_check(S.binary(math.nonimpl, name, z64));
            nonimpl_check(S.binary(math.nonimpl, name, z64i));
        }

        void nonimpl_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.nonimpl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void cimpl_check()
        {
            const string name = "cimpl";

            cimpl_check(S.binary(math.cimpl, name, z8));
            cimpl_check(S.binary(math.cimpl, name, z8i));
            cimpl_check(S.binary(math.cimpl, name, z16));
            cimpl_check(S.binary(math.cimpl, name, z16i));
            cimpl_check(S.binary(math.cimpl, name, z32));
            cimpl_check(S.binary(math.cimpl, name, z32i));
            cimpl_check(S.binary(math.cimpl, name, z64));
            cimpl_check(S.binary(math.cimpl, name, z64i));
        }

        void cimpl_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.cimpl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void cnonimpl_check()
        {
            const string name = "cnonimpl";

            cnonimpl_check(S.binary(math.cnonimpl, name, z8));
            cnonimpl_check(S.binary(math.cnonimpl, name, z8i));
            cnonimpl_check(S.binary(math.cnonimpl, name, z16));
            cnonimpl_check(S.binary(math.cnonimpl, name, z16i));
            cnonimpl_check(S.binary(math.cnonimpl, name, z32));
            cnonimpl_check(S.binary(math.cnonimpl, name, z32i));
            cnonimpl_check(S.binary(math.cnonimpl, name, z64));
            cnonimpl_check(S.binary(math.cnonimpl, name, z64i));
        }

        void cnonimpl_check<T>(S.BinaryOp<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.cnonimpl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }
    }
}