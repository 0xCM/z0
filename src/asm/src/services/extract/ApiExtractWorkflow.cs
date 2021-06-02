//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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

        public ApiCollection Run(IApiPack dst)
        {
            var flow = Wf.Running();
            var collected = Wf.ApiExtractor().Run(EventChannel, dst);
            Wf.Ran(flow);
            return collected;
        }

        public static Outcome<Timestamp> timestamp(FS.FolderPath src)
        {
            if(src.IsEmpty)
                return Timestamp.Zero;

            var fmt = src.Format(PathSeparator.FS);
            var idx = fmt.LastIndexOf(Chars.FSlash);
            if(idx == NotFound)
                return Timestamp.Zero;

            var outcome = Time.parse(fmt.RightOfIndex(idx), out var ts);
            if(outcome)
                return ts;
            else
                return(false,outcome.Message);
        }

        public Index<LineCount> CountLines()
        {
            var service = Wf.ApiPacks();
            var pack = service.Latest();
            var files = pack.Files(FS.Csv).Yield();
            var counting = Wf.Running(string.Format("Counting lines in {0} files from {1}", files.Length, pack.Root));
            var counts = LineCounts.count(files);
            root.iter(counts, c => Wf.Row(c.Format()));
            Wf.Ran(counting, string.Format("Counted lines in {0} files", files.Length));
            return counts;
        }
    }
}