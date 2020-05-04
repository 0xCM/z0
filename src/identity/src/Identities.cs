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

    public readonly struct Identities : IIdentities
    {
        public static IIdentities Services => default(Identities);
    }

    public interface IIdentities : IStatelessFactory<Identities>
    {
        IMultiDiviner Diviner => MultiDiviner.Service;

        IApiCollector ApiCollector => Svc.ApiCollector.Service;

        IMemberLocator ApiLocator => Svc.MemberLocator.Service;

        [MethodImpl(Inline)]
        IApiMemberQuery QueryHosted(IApiHost host)
            => ApiMemberQuery.Create(ApiLocator.Hosted(host));

        [MethodImpl(Inline)]
        IApiMemberQuery QueryLocated(IApiHost host)
            => ApiMemberQuery.Create(ApiLocator.Located(host));

        [MethodImpl(Inline)]
        IMemberExtractReader ExtractReader(IApiSet api)
            => MemberExtractReader.Create(api);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers HostedMembers(IApiHost host)
            => ApiLocator.Hosted(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers LocatedMembers(IApiHost host)
            => ApiLocator.Located(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers HostedMembers(IApiSet api, ApiHostUri host)
            => api.FindHost(host).MapRequired(host => HostedMembers(host));

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers LocatedMembers(IApiSet api, ApiHostUri host)
            => api.FindHost(host).MapRequired(host => LocatedMembers(host));        
    }
}