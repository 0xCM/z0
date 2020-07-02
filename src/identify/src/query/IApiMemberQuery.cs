//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiMemberQuery;

    public interface IApiMemberQuery
    {
        ApiMembers Members {get;}

        ApiMembers Located 
            => located(Members);

        ApiMembers OfKind<K>(K k)
            where K : unmanaged, Enum
                => kind(Members, k);

        ApiMembers OfKind<K>(K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => kind(Members, k, g);
        
        ApiMembers OfKind<K>(W128 w, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => kind(Members, w, k, g);

        ApiMembers OfKind<K>(W256 w, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => kind(Members, w, k, g);

        ApiMembers OfKind<K>(W512 w, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => kind(Members, w, k, g);

        ApiMembers UnaryOps(GenericPartition g = default)
            => unary(Members, g);

        ApiMembers BinaryOps(GenericPartition g = default)
            => binary(Members, g);

        ApiMembers TernaryOps(GenericPartition g = default)
            => ternary(Members, g);

        ApiMembers Vectorized(W128 w, GenericPartition g = default)
            => vectorized(Members, w, g);

        ApiMembers Vectorized(W256 w, GenericPartition g = default)
            => vectorized(Members, w, g);

        ApiMembers Vectorized(W512 w, GenericPartition g = default)
            => vectorized(Members, w, g);

        ApiMembers Vectorized(W128 w, string name, GenericPartition g = default)
            => vectorized(Members, w, name, g);

        ApiMembers Vectorized(W256 w, string name, GenericPartition g = default)
            => vectorized(Members, w, name, g);

        ApiMembers Vectorized(W512 w, string name, GenericPartition g = default)
            => vectorized(Members, w, name, g);

        ApiMembers Vectorized<T>(W128 w)
            where T : unmanaged
                => vectorized<T>(Members, w);

        ApiMembers Vectorized<T>(W256 w)
            where T : unmanaged
                => vectorized<T>(Members, w);

        ApiMembers Vectorized<T>(W512 w)
            where T : unmanaged
                => vectorized<T>(Members, w);
    }
}