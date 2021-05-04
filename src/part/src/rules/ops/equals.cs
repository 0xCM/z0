//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [Op, Closures(Closure)]
        public static bool equals<A>(Antecedant<A> src, Antecedant<A> dst)
            where A : IEquatable<A>
                => Index.equals(src.Terms.View, dst.Terms.View);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool equals<T>(Consequent<T> src, Consequent<T> dst)
            where T : IEquatable<T>
                => src.Term.Equals(dst.Term);

        [MethodImpl(Inline), Op]
        public static bool equals(Consequent src, Consequent dst)
            => src.Term?.Equals(dst.Term) ?? false;

        [MethodImpl(Inline)]
        public static bool equals<A,C>(Proposition<A,C> src, Proposition<A,C> dst)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => equals(src.Antecedant, dst.Antecedant) && equals(src.Consequence, dst.Consequence);
    }
}
