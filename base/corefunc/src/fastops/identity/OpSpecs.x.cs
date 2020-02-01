//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    partial class FastOpX
    {
        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureInfo> Close(this GenericOpSpec op)
            => from k in op.Kinds
                let pt = k.ToClrType()
                where pt.IsSome()
                let id = OpIdentities.Provider.DefineIdentity(op.Root, k)
                where !id.IsEmpty
                select OpClosureInfo.Define(id, k, op.Root.MakeGenericMethod(pt.Value));                
    }
}