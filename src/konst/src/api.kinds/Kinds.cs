//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.XKinds)]
    public static partial class XKinds
    {
        const NumericKind Closure = NumericKind.All;

    }

    [ApiHost]
    public partial class Kinds
    {
        const NumericKind Closure = NumericKind.All;

        public static IEnumerable<M> KindedOperators<M>(IEnumerable<M> src, int? arity = null)
            where M : struct, IApiMember<M>
            => from located in src
                let m = located.Method
                let id = m.KindId()
                where id != 0 && m.IsOperator() && (arity != null ? m.ArityValue() == arity : true)
                select located;

        public static IEnumerable<M> NumericOperators<M>(IEnumerable<M> src, int arity)
            where M : struct, IApiMember<M>
                => from located in src
                    let m = located.Method
                    let id = m.KindId()
                    where id !=0 && m.IsNumericOperator(arity)
                    select located;
    }
}