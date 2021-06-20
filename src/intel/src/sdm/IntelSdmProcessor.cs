//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public partial class IntelSdmProcessor : AppService<IntelSdmProcessor>
    {
        DocServices DocServices;

        AsmWorkspace Workspace;

        DocProcessArchive Archive;

        protected override void OnInit()
        {
            Workspace = Wf.AsmWorkspace();
            var root = Workspace.DocRoot();
            DocServices = Wf.DocServices(new DocProcessArchive(root));
            Archive = new DocProcessArchive(root);
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
            var charmap = CharMaps.editor(Utf16Encoding).Seal();
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
            var charmap = CharMaps.editor(Utf16Encoding).Seal();
            var dst = Archive.DocPath("charmap", FS.Config);
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var mapcount = CharMaps.emit(charmap, writer);
            Wf.EmittedFile(emitting, mapcount);
        }

        public ReadOnlySpan<DocSplitSpec> LoadSplitSpecs()
        {
            var src = SdmSplitSpecs();
            return DocServices.LoadSplitSpecs(src);
        }

        public void Run()
        {
            FindInstructions();
        }

       FS.FilePath SdmSplitSpecs()
            => Archive.Root + FS.file("splits", FS.Csv);

        FS.FilePath SdmRefPath()
            => RefDocPath("sdm");

        FS.FolderPath ProcessLogs()
            => Archive.Root + FS.folder("logs");

        FS.FilePath ProcessLog(string name)
            => ProcessLogs() + FS.file(name,FS.Log);

        FS.FilePath LinedSdmPath()
            => DocExtractPath("lined", FS.Txt);

        FS.FilePath RefDocPath(string id)
            => Archive.RefDoc(id, FS.Txt);

        FS.FolderPath SdmExtractRoot()
            => Archive.DocExtractDir("sdm");

        FS.FilePath DocExtractPath(string id, FS.FileExt ext)
            => SdmExtractRoot() + FS.file(string.Format("sdm.{0}", id), ext);

        FS.FilePath CombinedTocPath()
            => DocExtractPath("TOC",FS.Txt);
    }
}