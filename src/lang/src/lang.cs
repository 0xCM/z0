//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct lang
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Keyword keyword(string name)
            => new Keyword(name);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Keyword<A> keyword<A>(Keyword @base, A a0)
            => new Keyword<A>(@base.Address, a0);


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
    }

    partial struct Msg
    {
        static RenderPattern<S,Type> TransformFailedPattern<S>()
            => "The transformation {0}->{1} failed";

        public static string TransformFailed<S,T>(S src)
            => TransformFailedPattern<S>().Format(src, typeof(T));
    }
}