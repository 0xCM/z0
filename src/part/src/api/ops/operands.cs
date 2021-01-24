//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Api
    {
        /// <summary>
        /// Defines a single operand value
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="A"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Operand operand<A>(A value)
            => new Operand<A>(value);

        [MethodImpl(Inline), Op]
        public static Operands operands(params dynamic[] values)
            => new Operands(values);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Operands<T> operands<T>(Index<T> values)
            => new Operands<T>(values);

        [MethodImpl(Inline), Op]
        public static Operands operands<A,B>(A a0, B a1)
            => new Operands<A,B>(a0,a1);

        [MethodImpl(Inline)]
        public static Operands operands<A,B,C>(A a0, B a1, C a2)
            => new Operands<A,B,C>(a0, a1, a2);

        [MethodImpl(Inline)]
        public static Operands operands<A,B,C,D>(A a0, B a1, C a2, D a3)
            => new Operands<A,B,C,D>(a0, a1, a2,a3);
    }
}