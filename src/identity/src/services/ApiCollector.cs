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

    using static Seed;

    class ApiCollector : IApiCollector
    {        
        public static IApiCollector Service => new ApiCollector();

        IMultiDiviner Diviner => MultiDiviner.Service;

        DirectApiGroup ImmGroup(IApiHost host, DirectApiGroup g, ImmRefinementKind refinment)
            => DirectApiGroup.Define(host, g.GroupId, 
                g.Members.Where(m => m.Method.AcceptsImmediate(refinment) && m.Method.ReturnsVector()));

        public IEnumerable<DirectApiGroup> ImmDirect(IApiHost host, ImmRefinementKind refinment)
            => from g in CollectDirect(host)
                let immg = ImmGroup(host, g, refinment)
                where !immg.IsEmpty
                select g;

        public IEnumerable<GenericApiOp> ImmGeneric(IApiHost host, ImmRefinementKind refinment) 
            => CollectGeneric(host).Where(op => op.Method.AcceptsImmediate(refinment));

        public static NumericKind[] NumericClosureKinds(MethodInfo m)
                => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => Arrays.empty<NumericKind>());              

        public static IEnumerable<Type> NumericClosures(MethodInfo m)
                  => from c in NumericClosureKinds(m)
                  let t = c.SystemType()
                  where t != typeof(void)
                  select t;

        public static Type[] NaturalClosures(MethodInfo m)
                => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Natural
                let spec = (NatClosureKind)tag.Spec
                select NativeNaturals.FindTypes(spec).ToArray()).ValueOrElse(() => Arrays.empty<Type>());   


        public IEnumerable<DirectApiGroup> CollectDirect(Assembly src)
            => ApiReflected.Service.ApiHosts(src).SelectMany(CollectDirect);

        public IEnumerable<GenericApiOp> CollectGeneric(Assembly src)
            => ApiReflected.Service.ApiHosts(src).SelectMany(CollectGeneric);

        public IEnumerable<DirectApiGroup> CollectDirect(IApiHost src)        
            => from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select DirectApiGroup.Define(src, Identify.Op(d.Key), d);
                        
        public IEnumerable<GenericApiOp> CollectGeneric(IApiHost src)
             => from m in Tagged(src).OpenGeneric()
                let closures = NumericClosureKinds(m)
                where closures.Length != 0
                select GenericApiOp.Define(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        IEnumerable<DirectApiOp> DirectOpSpecs(IApiHost src)
            => from m in Tagged(src).NonGeneric()
                select DirectApiOp.Define(src, Diviner.Identify(m), m);

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static IEnumerable<MethodInfo> Tagged(IApiHost src)
            => src.HostedMethods.Tagged<OpAttribute>();
    }
}