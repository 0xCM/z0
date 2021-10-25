//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct expr
    {
        /// <summary>
        /// Creates a global scope
        /// </summary>
        /// <param name="name">The scope name</param>
        [MethodImpl(Inline), Op]
        public static Scope scope(Label name)
            => new Scope(Label.Empty, name);

        /// <summary>
        /// Creates a child scope
        /// </summary>
        /// <param name="name">The scope name</param>
        [MethodImpl(Inline), Op]
        public static Scope scope(Label parent, Label name)
            => new Scope(parent,name);
    }
}