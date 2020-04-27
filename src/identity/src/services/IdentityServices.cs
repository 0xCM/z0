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

    public readonly struct StatelessIdentity : IStatelessIdentity
    {
        public static IStatelessIdentity Factory => default(StatelessIdentity);
    }

    public interface IStatelessIdentity : IStatelessFactory<StatelessIdentity>
    {
        IMultiDiviner Diviner => default(MultiDiviner);

        [MethodImpl(Inline)]
        IMemberLocator MemberLocator(IMultiDiviner diviner = null)
            => Svc.MemberLocator.Create(diviner ?? Diviner);

        [MethodImpl(Inline)]
        IApiCollector ApiCollector(IMultiDiviner diviner = null)
            => Svc.ApiCollector.Create(diviner ?? Diviner);

        [MethodImpl(Inline)]
        IApiMemberQuery QueryHosted(IApiHost host)
            => ApiMemberQuery.Create(MemberLocator().Hosted(host));

        [MethodImpl(Inline)]
        IApiMemberQuery QueryLocated(IApiHost host)
            => ApiMemberQuery.Create(MemberLocator().Located(host));

        [MethodImpl(Inline)]
        IMemberExtractReader ExtractReader(IApiSet api)
            => MemberExtractReader.Create(MemberLocator(), api);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers HostedMembers(IApiHost host)
            => MemberLocator().Hosted(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers LocatedMembers(IApiHost host)
            => MemberLocator().Located(host);

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