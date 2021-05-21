//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    public class ApiExtractWorkflow : AppService<ApiExtractWorkflow>
    {
        int MemberDecodedCount;

        int MemberParsedCount;

        int HostResolvedCount;

        ApiExtractReceipt Receivers;

        public ApiExtractWorkflow()
        {
            MemberDecodedCount = 0;
            MemberParsedCount = 0;
            Receivers = new();
            Receivers.PartResolved += (source, e) => OnEvent(e);
            Receivers.HostResolved += (source, e) => OnEvent(e);
            Receivers.MemberParsed += (source, e) => OnEvent(e);
            Receivers.MemberDecoded += (source, e) => OnEvent(e);
            Receivers.ExtractError += (source, e) => OnEvent(e);
        }

        void OnEvent(PartResolvedEvent e)
        {

        }

        void OnEvent(HostResolvedEvent e)
        {
            root.atomic(ref HostResolvedCount);
        }

        void OnEvent(MemberParsedEvent e)
        {
            root.atomic(ref MemberParsedCount);
        }

        void OnEvent(MemberDecodedEvent e)
        {
            root.atomic(ref MemberDecodedCount);
        }

        void OnEvent(ExtractErrorEvent e)
        {

        }

        public void Run()
        {
            var flow = Wf.Running();
            Wf.ApiExtractor().Run(Receivers, Db.AppLogDir() + FS.folder("extract-wf"));
            Wf.Ran(flow, string.Format("Decoded:{0}", MemberDecodedCount));
        }

    }
}