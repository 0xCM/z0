//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;

    [ApiHost]
    public readonly struct ApiIndex
    {
        public static IApiHexIndex service(IWfShell wf)
            => ApiHexIndex.create(wf);

        [Op]
        public static ApiIndexMetrics metrics(ApiCodeBlocks src)
        {
            var stats = default(ApiIndexMetrics);
            stats.PartCount = src.Parts.Count;
            stats.HostCount = src.Hosts.Count;
            stats.AddressCount = src.Addresses.Count;
            stats.FunctionCount = src.Blocks.Count;
            stats.IdentityCount = src.Identities.Count;
            stats.ByteCount = src.Blocks.Storage.Sum(x => x.Length);
            return stats;
        }
    }
}