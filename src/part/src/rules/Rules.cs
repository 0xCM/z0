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

    using Z0.Lang;

    [ApiHost]
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates a <see cref='Constant{T}'/>
        /// </summary>
        /// <param name="name">The constant identifier</param>
        /// <param name="value">The constant value</param>
        /// <typeparam name="T">The constant type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Constant<T> constant<T>(Identifier name, T value)
            => new Constant<T>(name,value, ClrLiteralKinds.kind<T>());

        /// <summary>
        /// Creates a <see cref='Constant{S,T}'/>
        /// </summary>
        /// <param name="name">The constant identifier</param>
        /// <param name="src">The source value</param>
        /// <param name="map">The source transformer</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The constant type</typeparam>
        public static Constant<S,T> constant<S,T>(Identifier name, S src, ITransformer<S,T> map)
            => map.Transform(src, out var dst)
            ? new Constant<S,T>(name, src, dst,ClrLiteralKinds.kind<T>())
            : @throw<Constant<S,T>>(new Exception(Msg.TransformFailed<S,T>(src)));

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

    partial struct Msg
    {
        static RenderPattern<S,Type> TransformFailedPattern<S>()
            => "The transformation {0}->{1} failed";

        public static string TransformFailed<S,T>(S src)
            => TransformFailedPattern<S>().Format(src, typeof(T));
    }
}