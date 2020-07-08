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

    public readonly struct ApiClosures
    {
        public static IEnumerable<Type> numeric(MethodInfo m)
            => from c in ClosureKinds.numeric(m)
               let t = c.SystemType()
               where t != typeof(void)
               select t;
    }
    
    public readonly struct ClosureKinds
    {
        public static NumericKind[] numeric(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Numeric
                let spec = (NumericKind)tag.Spec
                select spec.DistinctKinds().ToArray()).ValueOrElse(() => Arrays.empty<NumericKind>());     

        public static Type[] natural(MethodInfo m)
            => (from tag in m.Tag<ClosuresAttribute>()
                where tag.Kind == TypeClosureKind.Natural
                let spec = (NatClosureKind)tag.Spec
                select NativeNaturals.FindTypes(spec).ToArray()).ValueOrElse(() => Arrays.empty<Type>());   
    }

    public readonly struct ApiCollection
    {
        public static IEnumerable<DirectApiGroup> direct(Assembly src)
            => ApiReflected.Service.Hosts(src).SelectMany(direct);

        public static IEnumerable<DirectApiGroup> direct(IApiHost src)        
            => from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new DirectApiGroup(Identify.Op(d.Key), src, d);

        public static IEnumerable<GenericApiMethod> generic(Assembly src)
            => ApiReflected.Service.Hosts(src).SelectMany(generic);

        public static IEnumerable<GenericApiMethod> generic(IApiHost src)
             => from m in Tagged(src).OpenGeneric()
                let closures = ClosureKinds.numeric(m)
                where closures.Length != 0
                select new GenericApiMethod(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static IEnumerable<MethodInfo> Tagged(IApiHost src)
            => src.HostedMethods.Tagged<OpAttribute>();

        static IMultiDiviner Diviner 
            => MultiDiviner.Service;

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static IEnumerable<DirectApiMethod> DirectOpSpecs(IApiHost src)
            => from m in Tagged(src).NonGeneric()
                select new DirectApiMethod(src, Diviner.Identify(m), m);
    }

    public readonly struct ApiImmCollection
    {
        public static IEnumerable<DirectApiGroup> direct(IApiHost host, ImmRefinementKind refinment)
            => from g in ApiCollection.direct(host)
                let immg = ImmGroup(host, g, refinment)
                where !immg.IsEmpty
                select g;

        public static IEnumerable<GenericApiMethod> generic(IApiHost host, ImmRefinementKind refinment) 
            => ApiCollection.generic(host).Where(op => op.Method.AcceptsImmediate(refinment));

        static DirectApiGroup ImmGroup(IApiHost host, DirectApiGroup g, ImmRefinementKind refinment)
            => new DirectApiGroup(g.GroupId, host, 
                g.Members.Where(m => m.Method.AcceptsImmediate(refinment) && m.Method.ReturnsVector()));        
    }

    public readonly struct ApiCollector : IApiCollector
    {        
        public static ApiCollector Service 
            => default;

        public IEnumerable<DirectApiGroup> ImmDirect(IApiHost host, ImmRefinementKind refinment)
            => ApiImmCollection.direct(host,refinment);

        public IEnumerable<GenericApiMethod> ImmGeneric(IApiHost host, ImmRefinementKind refinment) 
            => ApiImmCollection.generic(host,refinment);

        public IEnumerable<DirectApiGroup> CollectDirect(Assembly src)
            => ApiCollection.direct(src);

        public IEnumerable<GenericApiMethod> CollectGeneric(Assembly src)
            => ApiCollection.generic(src);

        public IEnumerable<DirectApiGroup> CollectDirect(IApiHost src)        
            => ApiCollection.direct(src);
                        
        public IEnumerable<GenericApiMethod> CollectGeneric(IApiHost src)
            => ApiCollection.generic(src);
    }
}