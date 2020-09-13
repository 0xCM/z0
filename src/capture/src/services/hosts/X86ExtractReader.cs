//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct X86ExtractReader
    {
        readonly ApiParts ApiSet;

        [MethodImpl(Inline)]
        public X86ExtractReader(ApiParts api)
            => ApiSet = api;

        static ApiMemberIndex IndexApi(ApiMembers src)
        {
            var pairs = src.Storage.Select(h => (h.Id, h));
            var ops = Identify.index(pairs,true);
            return new ApiMemberIndex(ops.HashTable, ops.Duplicates);
        }

        public X86ApiExtract[] Read(FilePath src)
        {
            var report = ExtractReport.Load(src);
            if(report.IsNonEmpty)
            {
                var uri = report[0].Uri.Host;
                var host = ApiSet.FindHost(uri).TryMap(x => x as IApiHost);
                if(host)
                    CreateExtracts(host.Value, report.Records);
                else
                    term.error($"Could not find host {uri} in api set");
            }
            else
                term.warn($"No data in extract report {src}");

            return default;
        }

        X86ApiExtract[] CreateExtracts(IApiHost host, ExtractRecord[] records)
        {
            var data = new X86ApiExtract[records.Length];
            var index = IndexApi(MemberLocator.locate(host));
            Span<X86ApiExtract> extracts = data;
            for(var i=0u; i<records.Length; i++)
            {
                ref readonly var record = ref skip(extracts,i);
                var member = index.Lookup(record.Id);
                seek(extracts,i) = member ? new X86ApiExtract(member.Value, record.Encoded) : X86ApiExtract.Empty;
            }
            return data;
        }
    }
}