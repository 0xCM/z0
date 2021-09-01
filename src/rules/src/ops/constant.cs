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
        /// <summary>
        /// Creates a <see cref='Constant{T}'/>
        /// </summary>
        /// <param name="name">The constant identifier</param>
        /// <param name="value">The constant value</param>
        /// <typeparam name="T">The constant type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Constant<T> constant<T>(T value)
            => new Constant<T>(value, (ConstantKind)LiteralKinds.kind<T>());

        /// <summary>
        /// Creates a <see cref='ConstExpr{S,T}'/>
        /// </summary>
        /// <param name="name">The constant identifier</param>
        /// <param name="src">The source value</param>
        /// <param name="map">The source transformer</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The constant type</typeparam>
        public static ConstExpr<S,T> constexpr<S,T>(string name, S src, ITransformer2<S,T> map)
            => map.Transform(src, out var dst)
            ? new ConstExpr<S,T>(name, src, dst, (ConstantKind)LiteralKinds.kind<T>())
            : @throw<ConstExpr<S,T>>(new Exception(Msg.TransformFailed<S,T>(src)));
    }
}
