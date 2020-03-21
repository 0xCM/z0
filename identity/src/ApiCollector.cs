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
        public IAppContext Context {get;}


        [MethodImpl(Inline)]
        public static IApiCollector Create(IAppContext context)
            => new ApiOpCollector(context);
    
        [MethodImpl(Inline)]
        internal ApiOpCollector(IAppContext context)
        {
            this.Context = context;
        }

        public IEnumerable<DirectOpGroup> CollectDirect(Assembly src)
            => src.ApiHosts().SelectMany(CollectDirect);

        public IEnumerable<GenericOp> CollectGeneric(Assembly src)
            => src.ApiHosts().SelectMany(CollectGeneric);

        public IEnumerable<DirectOpGroup> CollectDirect(ApiHost src)        
            => from d in DirectOpSpecs(src).GroupBy(op => op.ConcreteMethod.Name)
                select DirectOpGroup.Define(src, OpIdentity.Define(d.Key), d);
                        
        public IEnumerable<GenericOp> CollectGeneric(ApiHost src)
             => from m in Tagged(src).OpenGeneric()
                let closures = NumericClosures(m)
                where closures.Length != 0
                select GenericOp.Define(src, Identity.generic(m), m.GetGenericMethodDefinition(), closures);

        static IEnumerable<DirectOp> DirectOpSpecs(ApiHost src)
            => from m in Tagged(src).NonGeneric()
                select DirectOp.Define(src, Identity.identify(m), m);

        static IEnumerable<MethodInfo> Tagged(ApiHost src)
            => src.DeclaredMethods.Tagged<OpAttribute>();

        static NumericKind[] NumericClosures(MethodInfo m)
            => m.Tag<NumericClosuresAttribute>()
              .MapValueOrElse(a => a.NumericPrimitive.DistinctKinds(), 
                () => items<NumericKind>()).ToArray();

    }
}