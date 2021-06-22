//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiClassRelation : ITextual
    {
        RelationKind Kind {get;}

        ulong RelationId {get;}

        ReadOnlySpan<IApiClass> Members {get;}

        string ITextual.Format()
            => TextTools.join(" | ", Members.Map(x => x.Format()).ReadOnly());
    }

    [Free]
    public interface IUnaryApiClassRelation : IApiClassRelation
    {
        IApiClass Member {get;}

        ReadOnlySpan<IApiClass> IApiClassRelation.Members
            => new IApiClass[]{Member};

        ulong IApiClassRelation.RelationId
            => (ulong)Member.ClassId;

        RelationKind IApiClassRelation.Kind
            => RelationKind.Unary;
    }

    [Free]
    public interface IBinaryClassRelation : IApiClassRelation
    {
        IApiClass Member0 {get;}

        IApiClass Member1 {get;}

        ReadOnlySpan<IApiClass> IApiClassRelation.Members
            => new IApiClass[]{Member0,Member1};

        ulong IApiClassRelation.RelationId
            => (ulong)Member0.ClassId | ((ulong)Member1.ClassId << 16);

        RelationKind IApiClassRelation.Kind
            => RelationKind.Binary;
    }

    [Free]
    public interface IApiClassRelation<R0> : IUnaryApiClassRelation
        where R0 : unmanaged, IApiClass
    {
        new R0 Member => new R0();

        IApiClass IUnaryApiClassRelation.Member
            => new R0();
    }

    [Free]
    public interface IApiClassRelation<R0,R1> : IBinaryClassRelation
        where R0 : unmanaged, IApiClass
        where R1 : unmanaged, IApiClass
    {
        new R0 Member0 => new R0();

        new R1 Member1 => new R1();

        IApiClass IBinaryClassRelation.Member0
            => new R0();

        IApiClass IBinaryClassRelation.Member1
            => new R1();
    }
}