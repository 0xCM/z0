//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Svc = Z0;

    public static class ServiceFactory
    {
        [MethodImpl(Inline)]
        public static IMultiDiviner MultiDiviner(this IContext context)
            => default(MultiDiviner);

        [MethodImpl(Inline)]
        public static IMemberLocator MemberLocator(this IContext context, IMultiDiviner diviner = null)
            => Svc.MemberLocator.Create(context, diviner ?? context.MultiDiviner());

        [MethodImpl(Inline)]
        public static IApiCollector ApiCollector(this IContext context, IMultiDiviner diviner = null)
            => Svc.ApiCollector.Create(context, diviner ?? context.MultiDiviner());

        [MethodImpl(Inline)]
        public static IApiMemberQuery QueryHosted(this IContext context, IApiHost host)
            => ApiMemberQuery.Create(context.MemberLocator().Hosted(host));

        [MethodImpl(Inline)]
        public static IApiMemberQuery QueryLocated(this IContext context, IApiHost host)
            => ApiMemberQuery.Create(context.MemberLocator().Located(host));

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public static ApiMembers HostedMembers(this IContext context, IApiHost host)
            => context.MemberLocator().Hosted(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public static ApiMembers LocatedMembers(this IContext context, IApiHost host)
            => context.MemberLocator().Located(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public static ApiMembers HostedMembers(this IContext context, IApiSet api, in ApiHostUri host)
            => api.FindHost(host).MapRequired(host => context.HostedMembers(host));

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        public static ApiMembers LocatedMembers(this IContext context, IApiSet api, in ApiHostUri host)
            => api.FindHost(host).MapRequired(host => context.LocatedMembers(host));

        public static ApiCodeIndex ApiCodeIndex(this IContext context, IApiSet api, in ApiHostUri host, FolderPath root)
        {
            var indexer = context.CodeIndexer(api, context.MemberLocator());
            var apiIndex = ApiIndex.From(context.HostedMembers(api,host));
            var codeIndex = context.HostCodeIndex(host, root);
            return indexer.CreateIndex(apiIndex, codeIndex);            
        }
    }
}