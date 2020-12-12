//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NT = NatTypes;

    partial class TypeNats
    {
        /// <summary>
        /// For a natural number n <= 9, returns the type of the corresponding natural primitive. If n > 9, returns the zero type
        /// </summary>
        /// <param name="n">The number to evaluate</param>
        [MethodImpl(Inline), Op]
        public static Type primitive(byte n)
        {
            if(n == 1)
                return typeof(N1);
            else if(n == 2)
                return typeof(N2);
            else if(n == 3)
                return typeof(N3);
            else if(n == 4)
                return typeof(N4);
            else if(n == 5)
                return typeof(N5);
            else if(n == 6)
                return typeof(N6);
            else if(n == 7)
                return typeof(N7);
            else if(n == 8)
                return typeof(N8);
            else if(n == 9)
                return typeof(N9);
            else
                return typeof(N0);
        }

        /// <summary>
        /// Constructs an array of types that defines a sequence of natural primitives
        /// </summary>
        /// <param name="digits">The digit values where each value is in the range 0..9</param>
        public static Type[] primitives(byte[] digits)
        {
            var types = new Type[digits.Length];
            ref var tHead = ref types[0];
            ref var dHead = ref digits[0];
            for(var i=0; i< digits.Length; i++)
                Unsafe.Add(ref tHead, i) = primitive(Unsafe.Add(ref dHead, i));
            return types;
        }

        /// <summary>
        /// Creates a reflected natural sequence from a sequence of primitive values
        /// </summary>
        /// <param name="digits">The source digits</param>
        public static INatSeq seq(byte[] digits)
        {
            var dtypes = primitives(digits);
            var nattype = NatTypes.sequence((uint)dtypes.Length).MakeGenericType(dtypes);
            return (INatSeq)Activator.CreateInstance(nattype);
        }

        /// <summary>
        /// Creates a two-term natural sequence {D0, D1} from primitive natural types D0 and D1 that represents the value k = d0*10 + d1
        /// </summary>
        /// <param name="d0">The primal representative of the leading term</param>
        /// <param name="d1">The primal representative of the second term</param>
        /// <typeparam name="D0">The primitive type of the leading term</typeparam>
        /// <typeparam name="D1">The primitive type of the second term</typeparam>
        [MethodImpl(Inline)]
        public static NatSeq<D0,D1> seq<D0,D1>(D0 d0 = default, D1 d1 = default)
            where D0 : unmanaged, INatPrimitive<D0>
            where D1 : unmanaged, INatPrimitive<D1>
                => NatSeq<D0,D1>.Rep;

        /// <summary>
        /// Creates a three-term natural sequence {D0, D1, D2} from natural primitive types D0, D1, D2
        /// that represents the value k = d0*10^2 + d1*10^1 + d2
        /// </summary>
        /// <param name="d0">The primal representative of the leading term</param>
        /// <param name="d1">The primal representative of the second term</param>
        /// <param name="d2">The primal representative of the third term</param>
        /// <typeparam name="D0">The primitive type of the leading term</typeparam>
        /// <typeparam name="D1">The primitive type of the second term</typeparam>
        /// <typeparam name="D2">The primitive type of the third term</typeparam>
        [MethodImpl(Inline)]
        public static NatSeq<D0,D1,D2> seq<D0,D1,D2>(D0 d0 = default, D1 d1 = default, D2 d2 = default)
            where D0 : unmanaged, INatPrimitive<D0>
            where D1 : unmanaged, INatPrimitive<D1>
            where D2 : unmanaged, INatPrimitive<D2>
                => NatSeq<D0,D1,D2>.Rep;

        /// <summary>
        /// Creates a four-term natural sequence {D0, D1, D2, D3} from natural primitive types D0, D1, D2, D3
        /// that represents the value k = d0*10^3 + d1*10^2 + d2*10 + d3
        /// </summary>
        /// <param name="d0">The primal representative of the leading term</param>
        /// <param name="d1">The primal representative of the second term</param>
        /// <param name="d2">The primal representative of the third term</param>
        /// <param name="d3">The primal representative of the fourth term</param>
        /// <typeparam name="D0">The primitive type of the leading term</typeparam>
        /// <typeparam name="D1">The primitive type of the second term</typeparam>
        /// <typeparam name="D2">The primitive type of the third term</typeparam>
        /// <typeparam name="D3">The primitive type of the fourth term</typeparam>
        [MethodImpl(Inline)]
        public static NatSeq<D0,D1,D2,D3> seq<D0,D1,D2,D3>(D0 d0 = default, D1 d1 = default, D2 d2 = default, D3 d3 = default)
            where D0 : unmanaged, INatPrimitive<D0>
            where D1 : unmanaged, INatPrimitive<D1>
            where D2 : unmanaged, INatPrimitive<D2>
            where D3 : unmanaged, INatPrimitive<D3>
                => NatSeq<D0,D1,D2,D3>.Rep;

        /// <summary>
        /// Creates a five-term natural sequence {D0, D1, D2, D3, D4} from natural primitive types D0, D1, D2, D3, D4
        /// that represents the value k = d0*10^4 + d1*10^3 + d2*10^2 + d3*10 + d4
        /// </summary>
        /// <param name="d0">The primal representative of the leading term</param>
        /// <param name="d1">The primal representative of the second term</param>
        /// <param name="d2">The primal representative of the third term</param>
        /// <param name="d3">The primal representative of the fourth term</param>
        /// <param name="d4">The primal representative of the fifth term</param>
        /// <typeparam name="D0">The primitive type of the leading term</typeparam>
        /// <typeparam name="D1">The primitive type of the second term</typeparam>
        /// <typeparam name="D2">The primitive type of the third term</typeparam>
        /// <typeparam name="D3">The primitive type of the fourth term</typeparam>
        /// <typeparam name="D4">The primitive type of the fifth term</typeparam>
        [MethodImpl(Inline)]
        public static NatSeq<D0,D1,D2,D3,D4> seq<D0,D1,D2,D3,D4>(D0 d0 = default, D1 d1 = default, D2 d2 = default, D3 d3 = default, D4 d4 = default)
            where D0 : unmanaged, INatPrimitive<D0>
            where D1 : unmanaged, INatPrimitive<D1>
            where D2 : unmanaged, INatPrimitive<D2>
            where D3 : unmanaged, INatPrimitive<D3>
            where D4 : unmanaged, INatPrimitive<D4>
                => NatSeq<D0,D1,D2,D3,D4>.Rep;

        /// <summary>
        /// Creates a reflected two-term natural sequence {d0, d1} from three primitive values d0 and d1
        /// </summary>
        /// <param name="d0">The value of the leading term</param>
        /// <param name="d1">The value of the second term</param>
        [MethodImpl(Inline)]
        public static INatSeq seq(byte d0, byte d1)
            => (INatSeq) Activator.CreateInstance(close(NT.sequence(2), primitive(d0), primitive(d1)));

        /// <summary>
        /// Creates a reflected three-term natural sequence {d0, d1, d2} from three primitive values d0, d1, d2
        /// </summary>
        /// <param name="d0">The value of the leading term</param>
        /// <param name="d1">The value of the second term</param>
        /// <param name="d2">The value of the third term</param>
        [MethodImpl(Inline)]
        public static INatSeq seq(byte d0, byte d1, byte d2)
            => (INatSeq) Activator.CreateInstance(close(NT.sequence(3), primitive(d0), primitive(d1), primitive(d2)));

        /// <summary>
        /// Creates a reflected four-term natural sequence from three primitive values
        /// </summary>
        /// <param name="d0">The value of the leading term</param>
        /// <param name="d1">The value of the second term</param>
        /// <param name="d2">The value of the third term</param>
        /// <param name="d3">The value of the fourth term</param>
        [MethodImpl(Inline)]
        public static INatSeq seq(byte d0, byte d1, byte d2, byte d3)
            => (INatSeq) Activator.CreateInstance(close(NT.sequence(4), primitive(d0), primitive(d1), primitive(d2), primitive(d3)));

        [MethodImpl(Inline)]
        static Type close(Type t, params Type[] args)
            => t.MakeGenericType(args);
    }
}