//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    static class AsmCheckOps
    {
        public static IEnumerable<M> KindedOperators<M>(this IEnumerable<M> src, int? arity = null)
            where M : struct, IApiMember<M>
            => from located in src
                let m = located.Method
                let id = m.KindId()
                where id.HasValue && m.IsOperator() && (arity != null ? m.ArityValue() == arity : true)
                select located;

        public static IEnumerable<M> KindedNumericOperators<M>(this IEnumerable<M> src, int arity)
            where M : struct, IApiMember<M>
                => from located in src
                    let m = located.Method
                    let id = m.KindId()
                    where id.HasValue && m.IsNumericOperator(arity)
                    select located;
    }
}