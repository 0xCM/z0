//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TIdentities
    {
        IMultiDiviner Diviner 
            => MultiDiviner.Service;

        ApiCollector Collector 
            => ApiCollector.Service;

        MemberLocator Locator 
            => MemberLocator.Service;

        // ApiMembers JitHosted(IApiHost host)
        //     => ApiMemberJit.jit(host);

        // ApiMembers JitHosted(IApiHost[] hosts, IEventBroker broker)
        //     => ApiMemberJit.jit(hosts, broker);

        // /// <summary>
        // /// Retrieves the members defined by an api host
        // /// </summary>
        // /// <param name="host">The host uri</param>
        // ApiMembers JitApi(IApiSet api, ApiHostUri host)
        //     => api.FindHost(host).MapRequired(host => JitHosted(host));        

        // IMemberExtractReader ExtractReader(IApiSet api)
        //     => MemberExtractReader.create(api);

        // ApiMembers HostedMembers(IApiHost host)
        //     => ApiLocator.Locate(host);

        // ApiMembers HostedMembers(IApiSet api, ApiHostUri host)
        //     => api.FindHost(host).MapRequired(host => HostedMembers(host));
    }
}