//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static OpSurrogates;
    using static SurrogateTypes;
    
    public class t_arithmetic : t_gmath<t_arithmetic>
    {
        
        public void add_check()
        {
            const string name = "add";

            add_check(binary(math.add, name, z8));
            add_check(binary(math.add, name, z8i));
            add_check(binary(math.add, name, z16));
            add_check(binary(math.add, name, z16i));
            add_check(binary(math.add, name, z32));
            add_check(binary(math.add, name, z32i));
            add_check(binary(math.add, name, z64));
            add_check(binary(math.add, name, z64i));
            add_check(binary(fmath.add, name, z32f));
            add_check(binary(fmath.add, name, z64f));
        }        

        [MethodImpl(Inline)]
        void add_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.add(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }
        
        public void sub_check()
        {
            const string name = "sub";

            sub_check(binary(math.sub, name, z8));
            sub_check(binary(math.sub, name, z8i));
            sub_check(binary(math.sub, name, z16));
            sub_check(binary(math.sub, name, z16i));
            sub_check(binary(math.sub, name, z32));
            sub_check(binary(math.sub, name, z32i));
            sub_check(binary(math.sub, name, z64));
            sub_check(binary(math.sub, name, z64i));
            sub_check(binary(fmath.sub, name, z32f));
            sub_check(binary(fmath.sub, name, z64f));
        }

        [MethodImpl(Inline)]
        void sub_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.sub(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void mul_check()
        {
            const string name = "mul";

            mul_check(binary(math.mul, name, z8));
            mul_check(binary(math.mul, name, z8i));
            mul_check(binary(math.mul, name, z16));
            mul_check(binary(math.mul, name, z16i));
            mul_check(binary(math.mul, name, z32));
            mul_check(binary(math.mul, name, z32i));
            mul_check(binary(math.mul, name, z64));
            mul_check(binary(math.mul, name, z64i));
            mul_check(binary(fmath.mul, name, z32f));
            mul_check(binary(fmath.mul, name, z64f));
        }

        [MethodImpl(Inline)]
        void mul_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.mul(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void div_check()
        {
            const string name = "div";

            div_check(binary(math.div, name, z8));
            div_check(binary(math.div, name, z8i));
            div_check(binary(math.div, name, z16));
            div_check(binary(math.div, name, z16i));
            div_check(binary(math.div, name, z32));
            div_check(binary(math.div, name, z32i));
            div_check(binary(math.div, name, z64));
            div_check(binary(math.div, name, z64i));
            div_check(binary(fmath.div, name, z32f));
            div_check(binary(fmath.div, name, z64f));
        }

        [MethodImpl(Inline)]
        void div_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.div(t);
            var validator = this.BinaryValidator(true,t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void mod_check()
        {
            const string name = "mod";

            mod_check(binary(math.mod, name, z8));
            mod_check(binary(math.mod, name, z8i));
            mod_check(binary(math.mod, name, z16));
            mod_check(binary(math.mod, name, z16i));
            mod_check(binary(math.mod, name, z32));
            mod_check(binary(math.mod, name, z32i));
            mod_check(binary(math.mod, name, z64));
            mod_check(binary(math.mod, name, z64i));
            mod_check(binary(fmath.mod, name, z32f));
            mod_check(binary(fmath.mod, name, z64f));
        }

        [MethodImpl(Inline)]
        void mod_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.mod(t);
            var validator = this.BinaryValidator(true,t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void modmul_check()
        {
            const string name = "modmul";

            modmul_check(ternary(math.modmul, name, z8));
            modmul_check(ternary(math.modmul, name, z8i));
            modmul_check(ternary(math.modmul, name, z16));
            modmul_check(ternary(math.modmul, name, z16i));
            modmul_check(ternary(math.modmul, name, z32));
            modmul_check(ternary(math.modmul, name, z32i));
            modmul_check(ternary(math.modmul, name, z64));
            modmul_check(ternary(math.modmul, name, z64i));
            modmul_check(ternary(math.modmul, name, z64f));
            modmul_check(ternary(math.modmul, name, z32f));
        }

        [MethodImpl(Inline)]
        void modmul_check<T>(TernaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.modmul(t);
            var validator = this.TernaryValidator(true,t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void clamp_check()
        {
            const string name = "clamp";

            clamp_check(binary(math.clamp, name, z8));
            clamp_check(binary(math.clamp, name, z8i));
            clamp_check(binary(math.clamp, name, z16));
            clamp_check(binary(math.clamp, name, z16i));
            clamp_check(binary(math.clamp, name, z32));
            clamp_check(binary(math.clamp, name, z32i));
            clamp_check(binary(math.clamp, name, z64));
            clamp_check(binary(math.clamp, name, z64i));
            clamp_check(binary(fmath.clamp, name, z32f));
            clamp_check(binary(fmath.clamp, name, z64f));
        }

        [MethodImpl(Inline)]
        void clamp_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.clamp(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void inc_check()
        {
            const string name = "inc";

            inc_check(unary(math.inc, name, z8));
            inc_check(unary(math.inc, name, z8i));
            inc_check(unary(math.inc, name, z16));
            inc_check(unary(math.inc, name, z16i));
            inc_check(unary(math.inc, name, z32));
            inc_check(unary(math.inc, name, z32i));
            inc_check(unary(math.inc, name, z64));
            inc_check(unary(math.inc, name, z64i));
            inc_check(unary(fmath.inc, name, z32f));
            inc_check(unary(fmath.inc, name, z64f));
        }

        [MethodImpl(Inline)]
        void inc_check<T>(UnaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.inc(t);
            var validator = this.UnaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);            
        }

        public void dec_check()
        {
            const string name = "dec";            

            dec_check(unary(math.dec, name, z8));
            dec_check(unary(math.dec, name, z8i));
            dec_check(unary(math.dec, name, z16));
            dec_check(unary(math.dec, name, z16i));
            dec_check(unary(math.dec, name, z32));
            dec_check(unary(math.dec, name, z32i));
            dec_check(unary(math.dec, name, z64));
            dec_check(unary(math.dec, name, z64i));
            dec_check(unary(fmath.dec, name, z32f));
            dec_check(unary(fmath.dec, name, z64f));
        }

        [MethodImpl(Inline)]
        void dec_check<T>(UnaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.dec(t);
            var validator = this.UnaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);            
        }

        public void negate_check()
        {
            const string name = "negate";

            negate_check(unary(math.negate, name, z8));
            negate_check(unary(math.negate, name, z8i));
            negate_check(unary(math.negate, name, z16));
            negate_check(unary(math.negate, name, z16i));
            negate_check(unary(math.negate, name, z32));
            negate_check(unary(math.negate, name, z32i));
            negate_check(unary(math.negate, name, z64));
            negate_check(unary(math.negate, name, z64i));
            negate_check(unary(fmath.negate, name, z32f));
            negate_check(unary(fmath.negate, name, z64f));
        }

        [MethodImpl(Inline)]
        void negate_check<T>(UnaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.negate(t);
            var validator = this.UnaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);            
        }

        public void abs_check()
        {
            const string name = "abs";

            abs_check(unary(Math.Abs, name, z8i));
            abs_check(unary(Math.Abs, name, z16i));
            abs_check(unary(Math.Abs, name, z32i));
            abs_check(unary(Math.Abs, name, z64i));
            abs_check(unary(MathF.Abs, name, z32f));
            abs_check(unary(Math.Abs, name, z64f));
        }

        [MethodImpl(Inline)]
        void abs_check<T>(UnaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = GX.abs(t);
            var validator = this.UnaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);            
        }

        public void check_increments()
        {
            const string name = "increments";
            CheckAction(() => check_increments(z8), CaseName(name, z8));
            CheckAction(() => check_increments(z8i), CaseName(name, z8i));
            CheckAction(() => check_increments(z16), CaseName(name, z16));
            CheckAction(() => check_increments(z16i), CaseName(name, z16i));
            CheckAction(() => check_increments(z32), CaseName(name, z32));
            CheckAction(() => check_increments(z32i), CaseName(name, z32i));
            CheckAction(() => check_increments(z64), CaseName(name, z64));
            CheckAction(() => check_increments(z64i), CaseName(name, z64i));
        }

        void check_increments<T>(T first = default)
            where T : unmanaged
        {
            var count = Random.Next(21, 256);
            Span<T> data = new T[count];
            ref var src = ref head(data);
            gmath.increments(first, count, ref src);
            
            for(var i=0; i < count; i++)
                Claim.eq(gmath.add(first, convert<T>(i)), data[i]);
        }

        public void signum_8i()
            => signum_check<sbyte>();

        public void signum_16i()
            => signum_check<short>();

        public void signum_32i()
            => signum_check<int>();

        public void signum_64i()
            => signum_check<long>();

        public void signum_32f()
            => signum_check<float>();

        public void signum_64f()
            => signum_check<double>();

        protected void signum_check<T>(T t = default)
            where T : unmanaged
        {
            var zero = gmath.zero<T>();
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var expect = gmath.lt(x, zero) ? Sign.Neg : (gmath.gt(x, zero) ? Sign.Pos : Sign.None);
                var actual = gmath.signum(x);
                Claim.eq(expect,actual);
            }
        }
    }
}