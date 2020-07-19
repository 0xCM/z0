//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Svc = Z0;

    public readonly struct Identities : IIdentities
    {
        public static IIdentities Services => default(Identities);
    }

    public interface IIdentities
    {
        IMultiDiviner Diviner 
            => MultiDiviner.Service;

        ApiCollector ApiCollector 
            => Svc.ApiCollector.Service;

        MemberLocator ApiLocator 
            => Svc.MemberLocator.Service;

        ApiMembers JitHosted(IApiHost host)
            => ApiMemberJit.jit(host);

        ApiMembers JitHosted(IApiHost[] hosts, IEventBroker broker)
            => ApiMemberJit.jit(hosts, broker);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        ApiMembers JitApi(IApiSet api, ApiHostUri host)
            => api.FindHost(host).MapRequired(host => JitHosted(host));        

        IMemberExtractReader ExtractReader(IApiSet api)
            => MemberExtractReader.Create(api);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        ApiMembers HostedMembers(IApiHost host)
            => ApiLocator.Locate(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        ApiMembers HostedMembers(IApiSet api, ApiHostUri host)
            => api.FindHost(host).MapRequired(host => HostedMembers(host));
    }
}