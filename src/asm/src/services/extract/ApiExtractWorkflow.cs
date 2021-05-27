//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

        ApiExtractChannel EventChannel;

        public ApiExtractWorkflow()
        {
            MemberDecodedCount = 0;
            MemberParsedCount = 0;
            EventChannel = new();
            EventChannel.Enlist(this);
        }

        internal void Deposit(PartResolvedEvent e)
        {

        }

        internal void Deposit(HostResolvedEvent e)
        {
            root.atomic(ref HostResolvedCount);
        }

        internal void Deposit(MemberParsedEvent e)
        {
            root.atomic(ref MemberParsedCount);
        }

        internal void Deposit(MemberDecodedEvent e)
        {
            root.atomic(ref MemberDecodedCount);
        }

        internal void Deposit(ExtractErrorEvent e)
        {

        }

        public ApiCollection Run()
        {
            var dst = Db.AppLogDir() + FS.folder("extract-wf");
            return Run(dst);
        }

        public ApiCollection Run(FS.FolderPath root)
        {
            var flow = Wf.Running();
            var collected = Wf.ApiExtractor().Run(EventChannel, root);
            Wf.Ran(flow, string.Format("Decoded:{0}", MemberDecodedCount));
            return collected;

        }

        public ApiCollection Run(IApiPack dst)
        {
            var flow = Wf.Running();
            var collected = Wf.ApiExtractor().Run(EventChannel, dst);
            Wf.Ran(flow);
            return collected;
        }
    }
}