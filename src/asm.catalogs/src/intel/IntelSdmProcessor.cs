//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static IntelSdm;

    [ApiHost]
    public partial class IntelSdmProcessor : AppService<IntelSdmProcessor>
    {
        DocServices DocServices;

        AsmWorkspace Workspace;

        DocProcessArchive Archive;

        protected override void OnInit()
        {
            DocServices = Wf.DocServices();
            Workspace = Wf.AsmWorkspace();
            Archive = new DocProcessArchive(Workspace.DocRoot());
        }

        public void SplitSdm()
        {
            DocServices.Split(SdmSplitSpecs());
        }

        void LogUnmappedSdmChars()
        {
            LogUnmappedChars(SdmRefPath());
        }

        public static SortedReadOnlySpan<Paired<Hex16,char>> FindUnmappedChars(FS.FilePath src)
        {
            var charmap = CharMaps.editor(TextEncodings.Utf16).Seal();
            var unmapped = hashset<char>();
            using var reader = src.LineReader();
            while(reader.Next(out var line))
                CharMaps.unmapped(charmap, line.Data, unmapped);
            var pairs = unmapped.Map(x => paired((Hex16)x,x)).OrderBy(x => x.Left);
            return Spans.sorted(@readonly(pairs));
        }

        public void LogUnmappedChars(FS.FilePath src)
        {
            var unmapped = FindUnmappedChars(src);
            var pairs = unmapped.View.Map(CharMaps.format);
            var delimited = pairs.Delimit(Chars.Comma).Format();
            var description = string.Format("Unmapped:{0}", RP.embrace(delimited));
            Wf.Row(description);
        }

        public void EmitDefaultCharMap()
        {
            var charmap = CharMaps.editor(TextEncodings.Utf16).Seal();
            var dst = Archive.DocPath("charmap", FS.Config);
            var emitting = Wf.EmittingFile(dst);
            var mapcount = CharMaps.emit(charmap, dst);
            Wf.EmittedFile(emitting, mapcount);
        }

        public ReadOnlySpan<DocSplitSpec> LoadSplitSpecs()
        {
            var src = SdmSplitSpecs();
            return DocServices.LoadSplitSpecs(src);
        }


        public void Run()
        {
            ProcessToc();
        }
    }
}