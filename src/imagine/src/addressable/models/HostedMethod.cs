//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct HostedMethod : IComparable<HostedMethod>
    {
        public readonly ApiHostUri Host;

        public readonly MethodInfo Method;

        public readonly MemoryAddress Location;
        
        public HostedMethod(ApiHostUri host, MethodInfo method, MemoryAddress location = default)
        {
            Host = host;
            Method = method;
            Location = location;
        }

        public HostedMethod WithLocation(MemoryAddress location)
            => new HostedMethod(Host, Method, location);

       [MethodImpl(Inline)]
        public int CompareTo(HostedMethod src)
            => Location.CompareTo(src.Location);            
    }
}