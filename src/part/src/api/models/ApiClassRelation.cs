//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiClassRelation : IApiClassRelation
    {
        readonly IApiClassRelation R;

        [MethodImpl(Inline)]
        public ApiClassRelation(IApiClassRelation r)
        {
            R = r;
        }

        public RelationKind Kind

            => R.Kind;

        public ulong RelationId => R.RelationId;

        public ReadOnlySpan<IApiClass> Members => R.Members;
    }


    public readonly struct ApiClassRelation<R> : IApiClassRelation<R>
        where R : unmanaged, IApiClass
    {

    }

    public readonly struct ApiClassRelation<R0,R1> : IApiClassRelation<R0,R1>
        where R0 : unmanaged, IApiClass
        where R1 : unmanaged, IApiClass
    {

    }
}