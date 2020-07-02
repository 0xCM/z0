//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct ApiMemberQuery : IApiMemberQuery
    {
        public ApiMembers Members {get;}        

        [MethodImpl(Inline)]
        public static IApiMemberQuery Create(ApiMembers members)
            => new ApiMemberQuery(members);

        [MethodImpl(Inline)]
        public ApiMemberQuery(in ApiMembers members)
            => Members = members;         

        public static ApiMembers located(in ApiMembers src) 
            => src.Where(m => m.Address.IsNonEmpty);

        public static ApiMembers OfKind<K>(in ApiMembers src, K kind)
            where K : unmanaged, Enum
                => src.Where(m =>  text.equals(m.KindId.ToString(),kind.ToString()));

        public static ApiMembers kind<K>(in ApiMembers src, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => kind(src, k).Where(m => m.Method.IsMemberOf(g));
        
        public static ApiMembers kind<K>(in ApiMembers src, W128 w, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => ApiMemberQuery.kind(src, k, g).Where(m => m.Method.IsVectorized(w, g));

        public static ApiMembers kind<K>(in ApiMembers src, W256 w, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => ApiMemberQuery.kind(src, k, g).Where(m => m.Method.IsVectorized(w, g));

        public static ApiMembers kind<K>(in ApiMembers src, W512 w, K k, GenericPartition g = default)
            where K : unmanaged, Enum
                => ApiMemberQuery.kind(src, k, g).Where(m => m.Method.IsVectorized(w, g));

        public static ApiMembers unary(in ApiMembers src, GenericPartition g = default)
            => src.Where(m => m.Method.IsMemberOf(g) && m.Method.IsUnaryOperator());

        public static ApiMembers binary(in ApiMembers src, GenericPartition g = default)
            => src.Where(m => m.Method.IsMemberOf(g) && m.Method.IsBinaryOperator());

        public static ApiMembers ternary(in ApiMembers src, GenericPartition g = default)
            => src.Where(m => m.Method.IsMemberOf(g) && m.Method.IsTernaryOperator());

        public static ApiMembers vectorized(in ApiMembers src, W128 w, GenericPartition g = default)
            => src.Where(m => m.Method.IsVectorized(w,g));

        public static ApiMembers vectorized(in ApiMembers src, W256 w, GenericPartition g = default)
            => src.Where(m => m.Method.IsVectorized(w,g));

        public static ApiMembers vectorized(in ApiMembers src, W512 w, GenericPartition g = default)
            => src.Where(m => m.Method.IsVectorized(w,g));

        public static ApiMembers vectorized(in ApiMembers src, W128 w, string name, GenericPartition g = default)
            => src.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        public static ApiMembers vectorized(in ApiMembers src, W256 w, string name, GenericPartition g = default)
            => src.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        public static ApiMembers vectorized(in ApiMembers src, W512 w, string name, GenericPartition g = default)
            => src.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        public static ApiMembers vectorized<T>(in ApiMembers src, W128 w)
            where T : unmanaged
                => src.Where(m => m.Method.IsVectorized(w,typeof(T)));

        public static ApiMembers vectorized<T>(in ApiMembers src, W256 w)
            where T : unmanaged
                => src.Where(m => m.Method.IsVectorized(w,typeof(T)));

        public static ApiMembers vectorized<T>(in ApiMembers src, W512 w)
            where T : unmanaged
                => src.Where(m => m.Method.IsVectorized(w,typeof(T)));               
    }
}