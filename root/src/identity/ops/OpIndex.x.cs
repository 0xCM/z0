//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
        
    public static class OpIndexX
    {
        public static OpIndex<HostedMember> ToOpIndex(this IEnumerable<HostedMember> src)
            => OpIndex.From(src.Select(h => (h.Id, h)));

        public static OpIndex<HostedMember> ToOpIndex(this ReadOnlySpan<HostedMember> src)
            => OpIndex.From(src.ArrayMap(h => (h.Id, h)));
            
        public static OpIndex<HostedMember> ToOpIndex(this Span<HostedMember> src)
            => src.ReadOnly().ToOpIndex();

        public static OpIndex<LocatedMember> ToOpIndex(this IEnumerable<LocatedMember> src)
            => OpIndex.From(src.Select(h => (h.Id, h)));

        public static OpIndex<LocatedMember> ToOpIndex(this ReadOnlySpan<LocatedMember> src)
            => OpIndex.From(src.ArrayMap(h => (h.Id, h)));
            
        public static OpIndex<LocatedMember> ToOpIndex(this Span<LocatedMember> src)
            => src.ReadOnly().ToOpIndex();
    }        
}