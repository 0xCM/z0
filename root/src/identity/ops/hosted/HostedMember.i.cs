//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
        
    public interface IHostedMember
    {
        ApiHostUri Host {get;}

        OpIdentity Id {get;}

        MethodInfo Method {get;}

        OpUri Uri
            => OpUri.Hex(Host, Method.Name, Id);        
    }        

    public interface IHostedMember<T> : IHostedMember, IEquatable<T>, IFormattable<T>
        where T : IHostedMember
    {
        string ICustomFormattable.Format()
            => Uri.Format();    
    }

    public static class HostedMemberOps
    {
        public static OpIndex<M> CreateIndex<M>(this IEnumerable<M> members)
            where M : struct, IHostedMember
                => members.Select(m => (m.Id, m)).ToOpIndex();
    }
}