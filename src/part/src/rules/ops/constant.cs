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

    partial struct Rules
    {
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
}
