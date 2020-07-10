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

        // [MethodImpl(Inline)]
        // IApiMemberQuery QueryHosted(IApiHost host)
        //     => ApiMemberQuery.Create(ApiLocator.Hosted(host));

        // [MethodImpl(Inline)]
        // IApiMemberQuery JitMembers(IApiHost host)
        //     => ApiMemberQuery.Create(ApiLocator.Jit(host));

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers JitHosted(IApiHost host)
            => ApiMemberJit.jit(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers JitApi(IApiSet api, ApiHostUri host)
            => api.FindHost(host).MapRequired(host => JitHosted(host));        

        [MethodImpl(Inline)]
        IMemberExtractReader ExtractReader(IApiSet api)
            => MemberExtractReader.Create(api);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers HostedMembers(IApiHost host)
            => ApiLocator.Locate(host);

        /// <summary>
        /// Retrieves the members defined by an api host
        /// </summary>
        /// <param name="host">The host uri</param>
        [MethodImpl(Inline)]
        ApiMembers HostedMembers(IApiSet api, ApiHostUri host)
            => api.FindHost(host).MapRequired(host => HostedMembers(host));
    }
}