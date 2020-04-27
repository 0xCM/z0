//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    public interface IApiMemberQuery : IService
    {
        ApiMembers Members {get;}

        IEnumerable<Member> Located => Members.Where(m => m.Address.NonZero);

        ApiMembers OfKind<K>(K kind)
            where K : unmanaged, Enum
                => Members.Where(m =>  text.equals(m.KindId.ToString(),kind.ToString()));

        ApiMembers OfKind<K>(K kind, GenericPartition g = default)
            where K : unmanaged, Enum
                => OfKind(kind).Where(m => m.Method.IsMemberOf(g));
        
        ApiMembers OfKind<K>(W128 w, K kind, GenericPartition g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).Where(m => m.Method.IsVectorized(w,g));

        ApiMembers OfKind<K>(W256 w, K kind, GenericPartition g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).Where(m => m.Method.IsVectorized(w,g));

        ApiMembers OfKind<K>(W512 w, K kind, GenericPartition g = default)
            where K : unmanaged, Enum
                => OfKind(kind,g).Where(m => m.Method.IsVectorized(w,g));

        ApiMembers UnaryOps(GenericPartition g = default)
            => Members.Where(m => m.Method.IsMemberOf(g) && m.Method.IsUnaryOperator());

        ApiMembers BinaryOps(GenericPartition g = default)
            => Members.Where(m => m.Method.IsMemberOf(g) && m.Method.IsBinaryOperator());

        ApiMembers TernaryOps(GenericPartition g = default)
            => Members.Where(m => m.Method.IsMemberOf(g) && m.Method.IsTernaryOperator());

        ApiMembers Vectorized(W128 w, GenericPartition g = default)
            => Members.Where(m => m.Method.IsVectorized(w,g));

        ApiMembers Vectorized(W256 w, GenericPartition g = default)
            => Members.Where(m => m.Method.IsVectorized(w,g));

        ApiMembers Vectorized(W512 w, GenericPartition g = default)
            => Members.Where(m => m.Method.IsVectorized(w,g));

        ApiMembers Vectorized(W128 w, string name, GenericPartition g = default)
            => Members.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        ApiMembers Vectorized(W256 w, string name, GenericPartition g = default)
            => Members.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        ApiMembers Vectorized(W512 w, string name, GenericPartition g = default)
            => Members.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        ApiMembers Vectorized<T>(W128 w)
            where T : unmanaged
                => Members.Where(m => m.Method.IsVectorized(w,typeof(T)));

        ApiMembers Vectorized<T>(W256 w)
            where T : unmanaged
                => Members.Where(m => m.Method.IsVectorized(w,typeof(T)));

        ApiMembers Vectorized<T>(W512 w)
            where T : unmanaged
                => Members.Where(m => m.Method.IsVectorized(w,typeof(T)));
    }
}