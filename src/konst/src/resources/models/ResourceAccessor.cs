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

    public readonly struct ResourceAccessor
    {
        public readonly ApiHostUri Host;
        
        public readonly MethodInfo Member;

        public readonly ResourceFormat Format;
        
        [MethodImpl(Inline)]
        public ResourceAccessor(ApiHostUri host, MethodInfo member, ResourceFormat format)
        {
            Host = host;
            Member = member;
            Format = format;;
        }       

        public Type DeclaringType
        {
            [MethodImpl(Inline)]
            get => Member?.DeclaringType ?? EmptyVessels.EmptyType;
        }
 
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Member == null || EmptyVessels.IsEmpty(Member) || Host.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
        
        public static ResourceAccessor Empty
            => new ResourceAccessor(ApiHostUri.Empty, EmptyVessels.EmptyMethod, 0);
    }
}