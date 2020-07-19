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

    public readonly struct ApiCollection
    {
        public static DirectApiGroup[] direct(Assembly src)
            => ApiReflected.Service.Hosts(src).SelectMany(direct);

        public static DirectApiGroup[] direct(ApiHost src)        
            => (from d in DirectOpSpecs(src).GroupBy(op => op.Method.Name)
                select new DirectApiGroup(OpIdentityParser.parse(d.Key), src, d)).Array();

        public static DirectApiGroup[] direct(ApiDataType src)        
            => (from m in src.HostedMethods
                  let id = Diviner.Identify(m)
                  let name = m.Name
                  select(m, id, name)).GroupBy(g => g.name)
                    .Select(x => new DirectApiGroup(OpIdentityParser.parse(x.Key), src, 
                        from g in x
                        select new DirectApiMethod(src, g.id, g.m))).Array();
            
        public static GenericApiMethod[] generic(Assembly src)
            => ApiReflected.Service.Hosts(src).SelectMany(generic);

        public static GenericApiMethod[] generic(ApiHost src)
             => from m in Tagged(src).OpenGeneric()
                let closures = ClosureKinds.numeric(m)
                where closures.Length != 0
                select new GenericApiMethod(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        public static GenericApiMethod[] generic(ApiDataType src)
             => from m in src.HostedMethods
                let closures = ClosureKinds.numeric(src.HostType)
                where closures.Length != 0
                select new GenericApiMethod(src, Diviner.GenericIdentity(m), GenericDefintion(m), closures);

        static MethodInfo[] Tagged(IApiHost src)
            => src.HostedMethodArray.Tagged<OpAttribute>();

        static IMultiDiviner Diviner 
            => MultiDiviner.Service;

        static MethodInfo GenericDefintion(MethodInfo src)
            => src.IsGenericMethodDefinition ? src : src.GetGenericMethodDefinition();

        static IEnumerable<DirectApiMethod> DirectOpSpecs(IApiHost src)
            => from m in Tagged(src).NonGeneric()
                select new DirectApiMethod(src, Diviner.Identify(m), m);
    }
}