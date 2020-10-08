//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines a view over a <see cref='ApiMember'/> collection
    /// </summary>
    [ApiHost]
    public readonly struct ApiMemberQuery : IApiView<ApiMemberQuery,ApiMembers>
    {
        public ApiMembers Source {get;}

        public static HostedMethod[] DirectMethods(IApiHost host)
            => host.HostType.DeclaredMethods().NonGeneric().Where(ApiMemberQuery.IsDirectApiMember).Select(m => new HostedMethod(host.Uri, m));

        public static HostedMethod[] GenericMethods(IApiHost host)
            => host.HostType.DeclaredMethods().OpenGeneric(1).Where(ApiMemberQuery.IsGenericApiMember).Select(m => new HostedMethod(host.Uri, m));

        public static bool IsDirectApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && !src.AcceptsImmediate();

        public static bool IsGenericApiMember(MethodInfo src)
            => src.Tagged<OpAttribute>() && src.Tagged<ClosuresAttribute>() && !src.AcceptsImmediate();

        public static MethodInfo[] GenericMethods<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in src.HostType.DeclaredMethods().OpenGeneric(1)
                where m.Tagged<OpAttribute>()
                && m.Tagged<ClosuresAttribute>()
                && !m.AcceptsImmediate()
                && m.KindId().ToString() == kind.ToString()
                select m;

        public static MethodInfo[] DirectMethods<K>(IApiHost src, K kind)
            where K : unmanaged, Enum
                => from m in src.HostType.DeclaredMethods().NonGeneric()
                where m.Tagged<OpAttribute>()
                && !m.AcceptsImmediate()
                && m.KindId().ToString() == kind.ToString()
                select m;

        public ApiMembers Located
        {
            [MethodImpl(Inline), Op]
            get => Source.Where(m => m.Address.IsNonEmpty);
        }

        [MethodImpl(Inline), Op]
        public ApiMembers Unary(GenericState g = default)
            => Source.Where(m => m.Method.IsMemberOf(g) && m.Method.IsUnaryOperator());

        [MethodImpl(Inline), Op]
        public ApiMembers Binary(GenericState g = default)
            => Source.Where(m => m.Method.IsMemberOf(g) && m.Method.IsBinaryOperator());

        [MethodImpl(Inline), Op]
        public ApiMembers Ternary(GenericState g = default)
            => Source.Where(m => m.Method.IsMemberOf(g) && m.Method.IsTernaryOperator());

        [MethodImpl(Inline), Op]
        public ApiMembers Vectorized(W128 w, GenericState g = default)
            => Source.Where(m => m.Method.IsVectorized(w,g));

        [MethodImpl(Inline), Op]
        public ApiMembers Vectorized(W256 w, GenericState g = default)
            => Source.Where(m => m.Method.IsVectorized(w,g));

        [MethodImpl(Inline), Op]
        public ApiMembers Vectorized(W512 w, GenericState g = default)
            => Source.Where(m => m.Method.IsVectorized(w,g));

        [MethodImpl(Inline), Op]
        public ApiMembers Vectorized(W128 w, string name, GenericState g = default)
            => Source.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        [MethodImpl(Inline), Op]
        public ApiMembers Vectorized(W256 w, string name, GenericState g = default)
            => Source.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        [MethodImpl(Inline), Op]
        public ApiMembers Vectorized(W512 w, string name, GenericState g = default)
            => Source.Where(m => m.Method.IsVectorized(w,g) && text.equals(m.Method.Name, name));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ApiMembers Vectorized<T>(W128 w)
            where T : unmanaged
                => Source.Where(m => m.Method.IsVectorized(w,typeof(T)));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ApiMembers Vectorized<T>(W256 w)
            where T : unmanaged
                => Source.Where(m => m.Method.IsVectorized(w,typeof(T)));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ApiMembers Vectorized<T>(W512 w)
            where T : unmanaged
                => Source.Where(m => m.Method.IsVectorized(w,typeof(T)));

        [MethodImpl(Inline)]
        public ApiMembers OfKind<K>(K kind)
            where K : unmanaged, Enum
                => Source.Where(m =>  text.equals(m.KindId.ToString(),kind.ToString()));

        [MethodImpl(Inline)]
        public ApiMembers Kind<K>(W128 w, K k, GenericState g = default)
            where K : unmanaged, Enum
                => kind(Source, k, g).Where(m => m.Method.IsVectorized(w, g));

        [MethodImpl(Inline)]
        public ApiMembers Kind<K>(W256 w, K k, GenericState g = default)
            where K : unmanaged, Enum
                => kind(Source, k, g).Where(m => m.Method.IsVectorized(w, g));

        [MethodImpl(Inline)]
        public ApiMembers Kind<K>(W512 w, K k, GenericState g = default)
            where K : unmanaged, Enum
                => kind(Source, k, g).Where(m => m.Method.IsVectorized(w, g));

        [MethodImpl(Inline)]
        static ApiMembers kind<K>(in ApiMembers src, K k, GenericState g = default)
            where K : unmanaged, Enum
                => kind(src, k).Where(m => m.Method.IsMemberOf(g));
    }
}