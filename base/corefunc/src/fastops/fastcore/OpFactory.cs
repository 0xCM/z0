//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static zfunc;

    public static class OpFactory
    {            
        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> close(GenericOpSpec op)
            => from k in op.Kinds
                let definition = op.Method
                let id = OpIdentity.Provider.DefineIdentity(definition, k)
                where !id.IsEmpty
                let closed = definition.MakeGenericMethod(k.ToPrimalType())
                select OpClosureInfo.Define(id, k, closed);            
    }
}