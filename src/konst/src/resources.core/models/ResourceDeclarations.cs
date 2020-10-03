//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResourceDeclarations : IConstSpan<ResourceDeclarations,ApiResource>
    {
        public readonly Type DeclaringType;

        public readonly ApiResource[] Accessors;

        [MethodImpl(Inline)]
        public ResourceDeclarations(Type declaring, ApiResource[] accessors)
        {
            DeclaringType = declaring;
            Accessors = accessors;
        }

        public ReadOnlySpan<ApiResource> Data
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }
    }
}