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
    using static FunctionSurrogates;

    public class t_compare : t_gmath<t_compare>
    {     
        public void eq_check()
        {
            const string name = "eq";

            eq_check(predicate(math.eq, name, z8));
            eq_check(predicate(math.eq, name, z8i));
            eq_check(predicate(math.eq, name, z16));
            eq_check(predicate(math.eq, name, z16i));
            eq_check(predicate(math.eq, name, z32));
            eq_check(predicate(math.eq, name, z32i));
            eq_check(predicate(math.eq, name, z64));
            eq_check(predicate(math.eq, name, z64i));
            eq_check(predicate(fmath.eq, name, z32f));
            eq_check(predicate(fmath.eq, name, z64f));

        }

        [MethodImpl(Inline)]
        void eq_check<T>(BinaryPredSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.eq(t);
            var validator = this.BinaryPredicateValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void neq()
        {
            const string name = "neq";

            neq_check(predicate(math.neq, name, z8));
            neq_check(predicate(math.neq, name, z8i));
            neq_check(predicate(math.neq, name, z16));
            neq_check(predicate(math.neq, name, z16i));
            neq_check(predicate(math.neq, name, z32));
            neq_check(predicate(math.neq, name, z32i));
            neq_check(predicate(math.neq, name, z64));
            neq_check(predicate(math.neq, name, z64i));
            neq_check(predicate(fmath.neq, name, z32f));
            neq_check(predicate(fmath.neq, name, z64f));

        }

        [MethodImpl(Inline)]
        void neq_check<T>(BinaryPredSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.neq(t);
            var validator = this.BinaryPredicateValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void gt()
        {
            const string name = "gt";

            gt_check(predicate(math.gt, name, z8));
            gt_check(predicate(math.gt, name, z8i));
            gt_check(predicate(math.gt, name, z16));
            gt_check(predicate(math.gt, name, z16i));
            gt_check(predicate(math.gt, name, z32));
            gt_check(predicate(math.gt, name, z32i));
            gt_check(predicate(math.gt, name, z64));
            gt_check(predicate(math.gt, name, z64i));
            gt_check(predicate(fmath.gt, name, z32f));
            gt_check(predicate(fmath.gt, name, z64f));

        }

        [MethodImpl(Inline)]
        void gt_check<T>(BinaryPredSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.gt(t);
            var validator = this.BinaryPredicateValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void gteq()
        {
            const string name = "gteq";

            gteq_check(predicate(math.gteq, name, z8));
            gteq_check(predicate(math.gteq, name, z8i));
            gteq_check(predicate(math.gteq, name, z16));
            gteq_check(predicate(math.gteq, name, z16i));
            gteq_check(predicate(math.gteq, name, z32));
            gteq_check(predicate(math.gteq, name, z32i));
            gteq_check(predicate(math.gteq, name, z64));
            gteq_check(predicate(math.gteq, name, z64i));
            gteq_check(predicate(fmath.gteq, name, z32f));
            gteq_check(predicate(fmath.gteq, name, z64f));            
        }

        void gteq_check<T>(BinaryPredSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.gteq(t);
            var validator = this.BinaryPredicateValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void lt()
        {
            const string name = "lt";

            lt_check(predicate(math.lt, name, z8));
            lt_check(predicate(math.lt, name, z8i));
            lt_check(predicate(math.lt, name, z16));
            lt_check(predicate(math.lt, name, z16i));
            lt_check(predicate(math.lt, name, z32));
            lt_check(predicate(math.lt, name, z32i));
            lt_check(predicate(math.lt, name, z64));
            lt_check(predicate(math.lt, name, z64i));
            lt_check(predicate(fmath.lt, name, z32f));
            lt_check(predicate(fmath.lt, name, z64f));

        }

        void lt_check<T>(BinaryPredSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.lt(t);
            var validator = this.BinaryPredicateValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void lteq()
        {
            const string name = "lteq";

            lteq_check(predicate(math.lteq, name, z8));
            lteq_check(predicate(math.lteq, name, z8i));
            lteq_check(predicate(math.lteq, name, z16));
            lteq_check(predicate(math.lteq, name, z16i));
            lteq_check(predicate(math.lteq, name, z32));
            lteq_check(predicate(math.lteq, name, z32i));
            lteq_check(predicate(math.lteq, name, z64));
            lteq_check(predicate(math.lteq, name, z64i));
            lteq_check(predicate(fmath.lteq, name, z32f));
            lteq_check(predicate(fmath.lteq, name, z64f));

        }

        void lteq_check<T>(BinaryPredSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.lteq(t);
            var validator = this.BinaryPredicateValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void max_check()
        {
            const string name = "max";

            max_check(binary(math.max, name, z8));
            max_check(binary(math.max, name, z8i));
            max_check(binary(math.max, name, z16));
            max_check(binary(math.max, name, z16i));
            max_check(binary(math.max, name, z32));
            max_check(binary(math.max, name, z32i));
            max_check(binary(math.max, name, z64));
            max_check(binary(math.max, name, z64i));
            max_check(binary(fmath.max, name, z32f));
            max_check(binary(fmath.max, name, z64f));
        }

        void max_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.max(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }

        public void min_check()
        {
            const string name = "min";

            min_check(binary(math.min, name, z8));
            min_check(binary(math.min, name, z8i));
            min_check(binary(math.min, name, z16));
            min_check(binary(math.min, name, z16i));
            min_check(binary(math.min, name, z32));
            min_check(binary(math.min, name, z32i));
            min_check(binary(math.min, name, z64));
            min_check(binary(math.min, name, z64i));
            min_check(binary(fmath.min, name, z32f));
            min_check(binary(fmath.min, name, z64f));
        }

        void min_check<T>(BinaryOpSurrogate<T> f, T t = default)
            where  T : unmanaged
        {
            var g = MathSvcFactory.min(t);
            var validator = this.BinaryValidator(t);
            validator.CheckMatch(f,g);
            validator.CheckSpan(f,g);
        }
    }
}