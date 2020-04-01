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
    using System.Runtime.CompilerServices;

    using static Core;
    
    readonly struct ApiCollector : IApiCollector
    {
        public IEnumerable<DirectApiGroup> CollectDirect(Assembly src)
            => src.ApiHosts().SelectMany(CollectDirect);

        public IEnumerable<GenericApiOp> CollectGeneric(Assembly src)
            => src.ApiHosts().SelectMany(CollectGeneric);

        public IEnumerable<DirectApiGroup> CollectDirect(ApiHost src)        
            => from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select DirectApiGroup.Define(src, Identify.Op(d.Key), d);
                        
        public IEnumerable<GenericApiOp> CollectGeneric(ApiHost src)
             => from m in Tagged(src).OpenGeneric()
                let closures = NumericClosures(m)
                where closures.Length != 0
                select GenericApiOp.Define(src, Identity.generic(m), m.GenericDefintion(), closures);

        static IEnumerable<DirectApiOp> DirectOpSpecs(ApiHost src)
            => from m in Tagged(src).NonGeneric()
                select DirectApiOp.Define(src, Identity.identify(m), m);

        static IEnumerable<MethodInfo> Tagged(ApiHost src)
            => src.DeclaredMethods.Tagged<OpAttribute>();

        // static NumericKind[] NumericClosures(MethodInfo m)
        //     => m.Tag<NumericClosuresAttribute>()
        //       .MapValueOrElse(a => a.NumericPrimitive.DistinctKinds(), () => seq<NumericKind>()).ToArray();

        public static NumericKind[] NumericClosures(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => Arrays.empty<NumericKind>());
              

    }
}