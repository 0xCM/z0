//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public static class AsmCheckOps
    {
        public static IEnumerable<M> KindedOperators<M>(this IEnumerable<M> src, int? arity = null)
            where M : struct, IMemberOp<M>
            => from located in src
                let m = located.Method
                let id = m.KindId()
                where id.HasValue && m.IsOperator() && (arity != null ? m.Arity() == arity : true)
                select located;

        public static IEnumerable<M> KindedNumericOperators<M>(this IEnumerable<M> src, int arity)
            where M : struct, IMemberOp<M>
                => from located in src
                    let m = located.Method
                    let id = m.KindId()
                    where id.HasValue && m.IsNumericOperator(arity)
                    select located;
    }
}