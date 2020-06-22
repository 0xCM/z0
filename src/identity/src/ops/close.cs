//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    using static Konst;
    
    partial class Identity
    {
        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedApiMethod> close(GenericApiMethod op)
             => from k in op.Kinds
                let pt = k.SystemType().ToOption() where pt.IsSome()
                let id = Identity.identify(op.Method, k) where !id.IsEmpty
                select new ClosedApiMethod(op.Host, id, k, op.Method.MakeGenericMethod(pt.Value)); 

    }
}