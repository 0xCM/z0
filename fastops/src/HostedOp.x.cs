//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class HostedOpX
    {
        /// <summary>
        /// Determines the direct operations available through an api host
        /// </summary>
        /// <param name="src">The source host</param>
        public static IEnumerable<DirectOpGroup> DirectOps(this ApiHost src)
            => HostedOps.groups(src);

        /// <summary>
        /// Determines the generic operations available through an api host
        /// </summary>
        /// <param name="src">The source host</param>
        public static IEnumerable<GenericOpSpec> GenericOps(this ApiHost src)
            => HostedOps.generic(src);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<ClosedOpSpec> Close(this GenericOpSpec op)
            => HostedOps.close(op);        

        public static IEnumerable<EncodedOp> EncodedOps(this ApiHost host)
        {
            var generic = from m in host.DeclaredMethods.OpenGeneric()                
                          where 
                               m.Attributed<OpAttribute>() 
                            && m.Attributed<NumericClosuresAttribute>() 
                            && !m.AcceptsImmediate()
                          let c = m.CustomAttribute<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                          where c != NumericKind.None
                          from t in c.DistinctKinds().Select(x => x.ToClrType())
                          where t.IsSome()
                          let concrete = m.MakeGenericMethod(t.Value)
                          let address =  MemoryAddress.Define(concrete.Jit())
                          select EncodedOp.Define(concrete.Identify(), concrete, address);
            
            var direct = from m in host.DeclaredMethods.NonGeneric()
                          where m.Attributed<OpAttribute>() && !m.AcceptsImmediate()
                          let address =  MemoryAddress.Define(m.Jit())
                          select EncodedOp.Define(m.Identify(), m, address);
                          
            return generic.Union(direct).OrderBy(x => x.Location);
        }            
    }
}
