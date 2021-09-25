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
    }
}
