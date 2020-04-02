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
        public IContext Context {get;}
        
        readonly IMultiDiviner Diviner;

        [MethodImpl(Inline)]
        public static IApiCollector Create(IContext context, IMultiDiviner diviner)
            => new ApiCollector(context,diviner);
        
        [MethodImpl(Inline)]
        ApiCollector(IContext context, IMultiDiviner diviner)
        {
            this.Context = context;
            this.Diviner = diviner;
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
                let closures = MemberLocator.NumericClosures(m)
                where closures.Length != 0
                select GenericApiOp.Define(src, Diviner.GenericIdentity(m), m.GenericDefintion(), closures);

        IEnumerable<DirectApiOp> DirectOpSpecs(ApiHost src)
            => from m in Tagged(src).NonGeneric()
                select DirectApiOp.Define(src, Diviner.Identify(m), m);

        IEnumerable<MethodInfo> Tagged(ApiHost src)
            => src.DeclaredMethods.Tagged<OpAttribute>();
    }
}