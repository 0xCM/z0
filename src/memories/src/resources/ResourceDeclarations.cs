//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResourceDeclarations : IConstSpan<ResourceDeclarations,ResourceAccessor>
    {
        public readonly Type DeclaringType;

        public readonly ResourceAccessor[] Accessors;

        [MethodImpl(Inline)]
        public ResourceDeclarations(Type declaring, ResourceAccessor[] accessors)
        {
            DeclaringType = declaring;
            Accessors = accessors;
        }

        public ReadOnlySpan<ResourceAccessor> Data
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }        
    }    
}