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

    using static Root;

    public static partial class AsmExtend
    {
        public static IEnumerable<EncodedOp> EncodedOps(this ApiHost host)
        {
            var generic = from m in host.DeclaredMethods.OpenGeneric()                
                          where 
                               m.Tagged<OpAttribute>() 
                            && m.Tagged<NumericClosuresAttribute>() 
                            && !m.AcceptsImmediate()
                          let c = m.Tag<NumericClosuresAttribute>().MapValueOrDefault(a => a.NumericPrimitive, NumericKind.None)
                          where c != NumericKind.None
                          from t in c.DistinctKinds().Select(x => x.ToClrType())
                          where t.IsSome()
                          let concrete = m.MakeGenericMethod(t.Value)
                          let address =  MemoryAddress.Define(concrete.Jit())
                          select EncodedOp.Define(concrete.Identify(), concrete, address);
            
            var direct = from m in host.DeclaredMethods.NonGeneric()
                          where m.Tagged<OpAttribute>() && !m.AcceptsImmediate()
                          let address =  MemoryAddress.Define(m.Jit())
                          select EncodedOp.Define(m.Identify(), m, address);
                          
            return generic.Union(direct).OrderBy(x => x.Address);
        }            

        public static CapturedMember[] Capture(this ICaptureOps ops, in CaptureExchange exchange, MethodInfo[] methods)
        {
            var targets = new CapturedMember[methods.Length];
            for(var i = 0; i<methods.Length; i++)
            {
                var m = methods[i];
                targets[i] = ops.Capture(in exchange, m.Identify(), m);
            }
            return targets;
        }

        public static CapturedMember Capture(this ICaptureOps ops, in CaptureExchange exchange, MethodInfo src, params Type[] args)
        {
            if(src.IsOpenGeneric())
            {
                var target = src.Reify(args);
                return ops.Capture(in exchange, target.Identify(), target);
            }
            else
                return ops.Capture(in exchange, src.Identify(), src);                
        }

    }
}