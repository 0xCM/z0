//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using static OpSurrogates;
    using static Literals;

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

        void and_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.and(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

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

        void or_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.or(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

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

        void xor_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.xor(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

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

        void nand_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.nand(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

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

        void nor_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.nor(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

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

        void xnor_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.xnor(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

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

        void not_check<T>(UnaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.not(t);            
            var validator = this.UnaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);            
        }

        public void impl_check()
        {
            const string name = "impl";

            impl_check(binary(math.impl, name, z8));
            impl_check(binary(math.impl, name, z8i));
            impl_check(binary(math.impl, name, z16));
            impl_check(binary(math.impl, name, z16i));
            impl_check(binary(math.impl, name, z32));
            impl_check(binary(math.impl, name, z32i));
            impl_check(binary(math.impl, name, z64));
            impl_check(binary(math.impl, name, z64i));
        }

        void impl_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.impl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void nonimpl_check()
        {
            const string name = "nonimpl";

            nonimpl_check(binary(math.nonimpl, name, z8));
            nonimpl_check(binary(math.nonimpl, name, z8i));
            nonimpl_check(binary(math.nonimpl, name, z16));
            nonimpl_check(binary(math.nonimpl, name, z16i));
            nonimpl_check(binary(math.nonimpl, name, z32));
            nonimpl_check(binary(math.nonimpl, name, z32i));
            nonimpl_check(binary(math.nonimpl, name, z64));
            nonimpl_check(binary(math.nonimpl, name, z64i));
        }

        void nonimpl_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.nonimpl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void cimpl_check()
        {
            const string name = "cimpl";

            cimpl_check(binary(math.cimpl, name, z8));
            cimpl_check(binary(math.cimpl, name, z8i));
            cimpl_check(binary(math.cimpl, name, z16));
            cimpl_check(binary(math.cimpl, name, z16i));
            cimpl_check(binary(math.cimpl, name, z32));
            cimpl_check(binary(math.cimpl, name, z32i));
            cimpl_check(binary(math.cimpl, name, z64));
            cimpl_check(binary(math.cimpl, name, z64i));
        }

        void cimpl_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.cimpl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void cnonimpl_check()
        {
            const string name = "cnonimpl";

            cnonimpl_check(binary(math.cnonimpl, name, z8));
            cnonimpl_check(binary(math.cnonimpl, name, z8i));
            cnonimpl_check(binary(math.cnonimpl, name, z16));
            cnonimpl_check(binary(math.cnonimpl, name, z16i));
            cnonimpl_check(binary(math.cnonimpl, name, z32));
            cnonimpl_check(binary(math.cnonimpl, name, z32i));
            cnonimpl_check(binary(math.cnonimpl, name, z64));
            cnonimpl_check(binary(math.cnonimpl, name, z64i));
        }

        void cnonimpl_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.cnonimpl(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }
    }
}