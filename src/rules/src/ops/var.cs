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
        /// Defines a <see cref='Var'/>
        /// </summary>
        /// <param name="scope">The variable scope</param>
        /// <param name="name">The variable name</param>
        /// <param name="type">The sort of value the variable can hold</param>
        [MethodImpl(Inline), Op]
        public static Var var(IScope scope, string name, DataType type)
            => new Var(scope,name,type);
    }
}