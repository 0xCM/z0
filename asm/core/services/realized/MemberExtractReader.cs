//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    using Record = MemberExtractRecord;

    readonly struct MemberExtractReader : IMemberExtractReader
    {
        readonly IContext Context;
        
        readonly IApiSet ApiSet;

        [MethodImpl(Inline)]
        public static IMemberExtractReader Create(IContext context, IApiSet api)
            => new MemberExtractReader(context,api);

        [MethodImpl(Inline)]
        MemberExtractReader(IContext context, IApiSet api)
        {
            this.Context = context;
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

        public MemberExtract[] ReadExtracts(FilePath src)
        {
            var report = MemberExtractReport.Load(src);
            
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
            =>  ApiIndex.From(Context.MemberLocator().Hosted(host));

        MemberExtract[] MemberExtracts(IApiHost host, MemberExtractRecord[] records)
        {
            var data = new MemberExtract[records.Length];
            var index = MemberIndex(host);
            Span<MemberExtract> extracts = data;
            for(var i = 0; i<records.Length; i++)
            {
                ref readonly var record = ref skip(extracts,i);
                ref readonly var encoded = ref record.EncodedData;
                var member = index.Lookup(record.Id);
                seek(extracts,i) = member ? MemberExtract.Define(member.Value, encoded) : MemberExtract.Empty;
            }
            return data;
        }

    }
}