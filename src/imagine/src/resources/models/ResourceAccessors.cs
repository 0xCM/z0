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

    public readonly struct ResourceAccessors : IConstSpan<ResourceAccessors,ResourceAccessor>
    {
        public readonly ResourceAccessor[] Accessors;

        [MethodImpl(Inline)]
        public static implicit operator ResourceAccessors(ResourceAccessor[] src)
            => new ResourceAccessors(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<ResourceAccessor>(ResourceAccessors src)
            => src.Accessors;

        [MethodImpl(Inline)]
        public ResourceAccessors(ResourceAccessor[] accessors)
        {
            Accessors = accessors;
        }

        public ReadOnlySpan<ResourceAccessor> Data
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }        
    }    
}