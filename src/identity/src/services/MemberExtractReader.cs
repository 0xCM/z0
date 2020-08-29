//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct MemberExtractReader : IMemberExtractReader
    {
        readonly IApiSet ApiSet;

        [MethodImpl(Inline)]
        public MemberExtractReader(IApiSet api)
            => ApiSet = api;

        static ApiIndex IndexApi(ApiMembers src)
        {
            var pairs = src.Storage.Select(h => (h.Id, h));
            var ops = Identify.index(pairs,true);
            return new ApiIndex(ops.HashTable, ops.Duplicates);
        }

        public X86MemberExtract[] Read(FilePath src)
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

        X86MemberExtract[] CreateExtracts(IApiHost host, ExtractRecord[] records)
        {
            var data = new X86MemberExtract[records.Length];
            var index = IndexApi(MemberLocator.locate(host));
            Span<X86MemberExtract> extracts = data;
            for(var i = 0; i<records.Length; i++)
            {
                ref readonly var record = ref skip(extracts,i);
                var member = index.Lookup(record.Id);
                seek(extracts,i) = member ? new X86MemberExtract(member.Value, record.Encoded) : X86MemberExtract.Empty;
            }
            return data;
        }
    }
}