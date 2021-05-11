// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class ApiExtractWorkflow : AppService<ApiExtractWorkflow>
    {
        int MemberDecodedCount;

        int MemberParsedCount;

        int HostResolvedCount;

        ApiExtractReceivers Receivers;

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
            Wf.ApiExtracor().Run(Receivers);
            Wf.Ran(flow, string.Format("Decoded:{0}", MemberDecodedCount));
        }
    }
}