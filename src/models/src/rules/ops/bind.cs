//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct api
    {
       [MethodImpl(Inline), Op, Closures(Closure)]
        public static VarBinding<T> bind<T>(Var var, T val)
            where T : ITerm<T>
                => var.Bind(val);
    }
}