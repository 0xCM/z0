//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;


        [Op, Closures(Closure)]
        public static string format<A>(Antecedant<A> src)
            where A : IEquatable<A>
                => string.Format("({0}):{1}", src.Terms.Delimit(Chars.Amp),  typeof(A).Name);

        [MethodImpl(Inline)]
        public static bool equals<A>(Antecedant<A> src, Antecedant<A> dst)
            where A : IEquatable<A>
                => Index.equals(src.Terms.View, dst.Terms.View);

        [MethodImpl(Inline)]
        public static bool equals<C>(Consequent<C> src, Consequent<C> dst)
            where C : IEquatable<C>
                => src.Term.Equals(dst.Term);

        [MethodImpl(Inline)]
        public static bool equals<A,C>(Proposition<A,C> src, Proposition<A,C> dst)
            where A : IEquatable<A>
            where C : IEquatable<C>
                => equals(src.Antecedant, dst.Antecedant) && equals(src.Consequence, dst.Consequence);
    }
}