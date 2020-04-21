//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    partial class XTend
    {
        public static IEnumerable<M> KindedOperators<M>(this IEnumerable<M> src, int? arity = null)
            where M : struct, IApiMember<M>
            => from located in src
                let m = located.Method
                let id = m.KindId()
                where id != 0 && m.IsOperator() && (arity != null ? m.ArityValue() == arity : true)
                select located;

        public static IEnumerable<M> KindedNumericOperators<M>(this IEnumerable<M> src, int arity)
            where M : struct, IApiMember<M>
                => from located in src
                    let m = located.Method
                    let id = m.KindId()
                    where id !=0 && m.IsNumericOperator(arity)
                    select located;            
    }
}