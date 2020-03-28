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

    using static Root;
    
    readonly struct ApiOpCollector : IApiCollector
    {
        public IContext Context {get;}

        [MethodImpl(Inline)]
        public static IApiCollector Create(IContext context)
            => new ApiOpCollector(context);
    
        [MethodImpl(Inline)]
        internal ApiOpCollector(IContext context)
        {
            this.Context = context;
        }

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

        static NumericKind[] NumericClosures(MethodInfo m)
            => m.Tag<NumericClosuresAttribute>()
              .MapValueOrElse(a => a.NumericPrimitive.DistinctKinds(), 
                () => items<NumericKind>()).ToArray();

    }
}