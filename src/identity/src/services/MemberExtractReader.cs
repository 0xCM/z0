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

    using Record = ApiExtractRecord;

    public readonly struct MemberExtractReader : IMemberExtractReader
    {
        readonly IMemberLocator Locator;
        
        readonly IApiSet ApiSet;

        [MethodImpl(Inline)]
        public static IMemberExtractReader Create(IMemberLocator locator, IApiSet api)
            => new MemberExtractReader(locator,api);

        [MethodImpl(Inline)]
        MemberExtractReader(IMemberLocator locatorr, IApiSet api)
        {
            Locator = locatorr;
            this.ApiSet = api;
        }

        /// <summary>
        /// Reads extract records from a saved report
        /// </summary>
        /// <param name="src">The report path</param>
        IEnumerable<Record> ExtractRecords(FilePath src)
        {
            var count = 0;
            foreach(var line in src.ReadLines())
            {
                if(count++ != 0)
                    yield return Record.Parse(line);
            }
        }        

        public ApiMemberExtract[] ReadExtracts(FilePath src)
        {
            var report = ApiExtractReport.Load(src);
            
            if(report.IsNonEmpty)     
            {                               
                var host = Host(report[0].Uri.HostPath);                
                return host ? MemberExtracts(host.Value, report.Records) : default;
            }            
            else
                return default;
        }

        Option<IApiHost> Host(ApiHostUri uri)
            => ApiSet.FindHost(uri).TryMap(x => x as IApiHost);        

        ApiIndex MemberIndex(IApiHost host)
            =>  ApiIndex.Create(Locator.Hosted(host));

        ApiMemberExtract[] MemberExtracts(IApiHost host, ApiExtractRecord[] records)
        {
            var data = new ApiMemberExtract[records.Length];
            var index = MemberIndex(host);
            Span<ApiMemberExtract> extracts = data;
            for(var i = 0; i<records.Length; i++)
            {
                ref readonly var record = ref skip(extracts,i);
                ref readonly var encoded = ref record.EncodedData;
                var member = index.Lookup(record.Id);
                seek(extracts,i) = member ? ApiMemberExtract.Define(member.Value, encoded) : ApiMemberExtract.Empty;
            }
            return data;
        }
    }
}