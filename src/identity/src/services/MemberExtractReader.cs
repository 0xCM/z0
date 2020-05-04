//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    public readonly struct MemberExtractReader : IMemberExtractReader
    {
        readonly IApiSet ApiSet;


        [MethodImpl(Inline)]
        public static IMemberExtractReader Create(IApiSet api)
            => new MemberExtractReader(api);

        [MethodImpl(Inline)]
        internal MemberExtractReader(IApiSet api)
        {
            ApiSet = api;
        }

        public ExtractedMember[] Read(FilePath src)
        {
            var report = ExtractReport.Load(src);    
            if(report.IsNonEmpty)     
            {                               
                var uri = report[0].Uri.HostPath;
                var host = ApiSet.FindHost(uri).TryMap(x => x as IApiHost);
                if(host)
                    CreateExtracts(host.Value, report.Records);
                else
                    term.error($"Coult not find host {uri} in api set");
            }
            else
                term.warn($"No data in extract report {src}");            

            return default;
        }

        ExtractedMember[] CreateExtracts(IApiHost host, ExtractRecord[] records)
        {
            var data = new ExtractedMember[records.Length];
            var index = ApiIndex.Create(MemberLocator.Service.Hosted(host));
            Span<ExtractedMember> extracts = data;
            for(var i = 0; i<records.Length; i++)
            {
                ref readonly var record = ref skip(extracts,i);
                var member = index.Lookup(record.Id);
                seek(extracts,i) = member ? ExtractedMember.Define(member.Value, record.Encoded) : ExtractedMember.Empty;
            }
            return data;
        }
    }
}