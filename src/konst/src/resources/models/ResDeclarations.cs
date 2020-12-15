//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResDeclarations : IConstSpan<ResDeclarations,ApiMemberRes>
    {
        public readonly Type DeclaringType;

        public readonly ApiMemberRes[] Accessors;

        [MethodImpl(Inline)]
        public ResDeclarations(Type declaring, ApiMemberRes[] accessors)
        {
            DeclaringType = declaring;
            Accessors = accessors;
        }

        public ReadOnlySpan<ApiMemberRes> Data
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }
    }
}