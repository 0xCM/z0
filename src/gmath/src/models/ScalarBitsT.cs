//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ScalarBits<T> : IBooleanAlgebra<ScalarBits<T>>
        where T : unmanaged
    {
        readonly T Value;

        [MethodImpl(Inline)]
        public ScalarBits(T value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public ScalarBits<T> And(ScalarBits<T> a)
            => gmath.and(Value,a.Value);

        [MethodImpl(Inline)]
        public ScalarBits<T> Nand(ScalarBits<T> a)
            => gmath.nand(Value,a.Value);

        [MethodImpl(Inline)]
        public ScalarBits<T> Or(ScalarBits<T> a)
            => gmath.or(Value,a.Value);

        [MethodImpl(Inline)]
        public ScalarBits<T> Nor(ScalarBits<T> a)
            => gmath.nor(Value,a.Value);

        [MethodImpl(Inline)]
        public ScalarBits<T> Not()
            => gmath.not(Value);

        [MethodImpl(Inline)]
        public ScalarBits<T> Sll(byte count)
            => gmath.sll(Value, count);

        [MethodImpl(Inline)]
        public ScalarBits<T> Srl(byte count)
            => gmath.srl(Value, count);

        [MethodImpl(Inline)]
        public ScalarBits<T> Rotl(byte count)
            => gmath.rotl(Value, count);

        [MethodImpl(Inline)]
        public ScalarBits<T> Rotr(byte count)
            => gmath.rotr(Value, count);

        [MethodImpl(Inline)]
        public ScalarBits<T> Negate()
            => gmath.negate(Value);

        [MethodImpl(Inline)]
        public ScalarBits<T> Xor(ScalarBits<T> a)
            => gmath.xor(Value,a.Value);

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator &(ScalarBits<T> a, ScalarBits<T> b)
            => a.And(b);

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator |(ScalarBits<T> a, ScalarBits<T> b)
            => a.Or(b);

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator ^(ScalarBits<T> a, ScalarBits<T> b)
            => a.Xor(b);

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator <<(ScalarBits<T> a, int count)
            => a.Sll((byte)count);

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator >>(ScalarBits<T> a, int count)
            => a.Srl((byte)count);

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator ~(ScalarBits<T> a)
            => a.Not();

        [MethodImpl(Inline)]
        public static ScalarBits<T> operator -(ScalarBits<T> a)
            => a.Negate();

        [MethodImpl(Inline)]
        public static implicit operator ScalarBits<T>(T src)
            => new ScalarBits<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(ScalarBits<T> src)
            => src.Value;
    }
}