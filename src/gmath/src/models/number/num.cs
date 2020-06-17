//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static Konst;

    public partial class num
    {
        [MethodImpl(Inline), Factory, Closures(AllNumeric)]
        public static num<T> from<T>(T value)
            where T : unmanaged
                => new num<T>(value);

        [MethodImpl(Inline), Const, Closures(AllNumeric)]
        public static num<T> zero<T>()
            where T : unmanaged
                => new num<T>(NumericLiterals.zero<T>());

        [MethodImpl(Inline), Const, Closures(AllNumeric)]
        public static num<T> one<T>()
            where T : unmanaged
                => new num<T>(NumericLiterals.one<T>());

        [MethodImpl(Inline), Const, Closures(AllNumeric)]
        public static num<T> ones<T>()
            where T : unmanaged
                => new num<T>(NumericLiterals.ones<T>());

        [MethodImpl(Inline), Add, Closures(AllNumeric)]
        public static num<T> add<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.add(a.Value, b.Value));

        [MethodImpl(Inline), Mul, Closures(AllNumeric)]
        public static num<T> mul<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.mul(a.Value, b.Value));

        [MethodImpl(Inline), Sub, Closures(AllNumeric)]
        public static num<T> sub<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.sub(a.Value, b.Value));

        [MethodImpl(Inline), Div, Closures(AllNumeric)]
        public static num<T> div<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.div(a.Value, b.Value));

        [MethodImpl(Inline), Mod, Closures(AllNumeric)]
        public static num<T> mod<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.mod(a.Value, b.Value));

        [MethodImpl(Inline), Negate, Closures(AllNumeric)]
        public static num<T> negate<T>(num<T> a)
            where T : unmanaged
                => from(gmath.negate(a.Value));

        [MethodImpl(Inline), And, Closures(Integers)]
        public static num<T> and<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.and(a.Value, b.Value));

        [MethodImpl(Inline), Or, Closures(Integers)]
        public static num<T> or<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.or(a.Value, b.Value));

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static num<T> xor<T>(num<T> a, num<T> b)
            where T : unmanaged
                => from(gmath.xor(a.Value, b.Value));

        [MethodImpl(Inline), Not, Closures(Integers)]
        public static num<T> not<T>(num<T> a)
            where T : unmanaged
                => from(gmath.not(a.Value));

        [MethodImpl(Inline), Sll, Closures(Integers)]
        public static num<T> sll<T>(num<T> a, byte offset)
            where T : unmanaged
                => from(gmath.sll(a.Value, offset));
        
        [MethodImpl(Inline), Srl, Closures(Integers)]
        public static num<T> srl<T>(num<T> a, byte offset)
            where T : unmanaged
                => from(gmath.srl(a.Value, offset));
        
        [MethodImpl(Inline), Eq, Closures(AllNumeric)]
        public static bit eq<T>(num<T> a, num<T> b)
            where T : unmanaged
                => gmath.eq(a.Value,b.Value);

        [MethodImpl(Inline), Neq, Closures(AllNumeric)]
        public static bit neq<T>(num<T> a, num<T> b)
            where T : unmanaged
                => gmath.neq(a.Value,b.Value);

        [MethodImpl(Inline), Lt, Closures(AllNumeric)]
        public static bit lt<T>(num<T> a, num<T> b)
            where T : unmanaged
                => gmath.lt(a.Value,b.Value);

        [MethodImpl(Inline), Gt, Closures(AllNumeric)]
        public static bit gt<T>(num<T> a, num<T> b)
            where T : unmanaged
                => gmath.gt(a.Value,b.Value);

        [MethodImpl(Inline), LtEq, Closures(AllNumeric)]
        public static bit lteq<T>(num<T> a, num<T> b)
            where T : unmanaged
                => gmath.lteq(a.Value,b.Value);

        [MethodImpl(Inline), GtEq, Closures(AllNumeric)]
        public static bit gteq<T>(num<T> a, num<T> b)
            where T : unmanaged
                => gmath.gteq(a.Value,b.Value);
    }

    public struct num<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static bool operator ==(num<T> a, num<T> b)
            => num.eq(a,b);

        [MethodImpl(Inline)]
        public static bool operator !=(num<T> a, num<T> b)
            => num.neq(a,b);

        [MethodImpl(Inline)]
        public static bool operator <(num<T> a, num<T> b)
            => num.lt(a,b);

        [MethodImpl(Inline)]
        public static bool operator >(num<T> a, num<T> b)
            => num.gt(a,b);

        [MethodImpl(Inline)]
        public static bool operator <=(num<T> a, num<T> b)
            => num.lteq(a,b);

        [MethodImpl(Inline)]
        public static bool operator >=(num<T> a, num<T> b)
            => num.gteq(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator +(num<T> a, num<T> b)
            => num.add(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator -(num<T> a, num<T> b)
            => num.sub(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator *(num<T> a, num<T> b)
            => num.mul(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator /(num<T> a, num<T> b)
            => num.div(a,b);
        
        [MethodImpl(Inline)]
        public static num<T> operator %(num<T> a, num<T> b)
            => num.mod(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator -(num<T> a)
            => num.negate(a);

        [MethodImpl(Inline)]
        public static num<T> operator &(num<T> a, num<T> b)
            => num.and(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator |(num<T> a, num<T> b)
            => num.or(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator ^(num<T> a, num<T> b)
            => num.xor(a,b);

        [MethodImpl(Inline)]
        public static num<T> operator >>(num<T> a, int offset)
            => num.srl(a,(byte)offset);

        [MethodImpl(Inline)]
        public static num<T> operator <<(num<T> a, int offset)
            => num.sll(a,(byte)offset);

        [MethodImpl(Inline)]
        public static num<T> operator ~(num<T> a)
            => num.not(a);

        [MethodImpl(Inline)]
        public static implicit operator T(num<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public num(T value)
            => Value = value;

        public T Value;

        [MethodImpl(Inline)]
        public bool Equals(num<T> src)
            => num.eq(this, src);

        public override int GetHashCode()
            => Value.GetHashCode();

        public override string ToString()
            => Value.ToString();        

        public override bool Equals(object src)
            => src is num<T> x && Equals(x);
    }
}