//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct ApiImmediates
    {
        public static DirectApiGroup[] direct(ApiHost host, ImmRefinementKind refinment)
            => from g in ApiCollection.direct(host)
                let immg = ImmGroup(host, g, refinment)
                where !immg.IsEmpty
                select g;

        public static GenericApiMethod[] generic(ApiHost host, ImmRefinementKind refinment) 
            => ApiCollection.generic(host).Where(op => op.Method.AcceptsImmediate(refinment));

        static DirectApiGroup ImmGroup(IApiHost host, DirectApiGroup g, ImmRefinementKind refinment)
            => new DirectApiGroup(g.GroupId, host, 
                g.Members.Where(m => m.Method.AcceptsImmediate(refinment) && m.Method.ReturnsVector()));        
    }

}