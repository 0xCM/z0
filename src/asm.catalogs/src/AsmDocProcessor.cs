//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using System;

    using static core;
    using static Root;
    using static IntelSdm;

    public class IntelSdmProcessor : AppService<IntelSdmProcessor>
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

        string VolumeMarker(byte vol)
            => string.Format("Vol. {0}", vol);

        Strings VolumeMarkers(byte min, byte max)
        {
            var dst = Strings.create();
            for(var i=min; i<=max; i++)
                dst.Add(VolumeMarker(i));
            return dst;
        }

        public SortedReadOnlySpan<Paired<Hex16,char>> FindUnmappedChars(FS.FilePath src)
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
            var description = string.Format("Unmapped:{0}", text.embrace(delimited));
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

        static bool IsSectionNumber(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            if(count == 0)
                return false;

            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);

                if(SymbolicQuery.digit(base10,c))
                    continue;

                if(c == Chars.Dot)
                    continue;

                return false;
            }
            return true;
        }

        static Outcome parse(ReadOnlySpan<char> src, out SectionNumber dst)
        {
            dst = SectionNumber.Empty;
            if(!IsSectionNumber(src))
                return false;

            var digits = text.split(src.ToString(), Chars.Dot).View;
            var count = digits.Length;
            if(count == 0)
                return false;
            switch(count)
            {
                case 1:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    break;

                case 2:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    ushort.TryParse(skip(digits, 1), out dst.B);
                break;

                case 3:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    ushort.TryParse(skip(digits, 1), out dst.B);
                    ushort.TryParse(skip(digits, 2), out dst.C);
                break;

                case 4:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    ushort.TryParse(skip(digits, 1), out dst.B);
                    ushort.TryParse(skip(digits, 2), out dst.C);
                    ushort.TryParse(skip(digits, 3), out dst.D);
                break;

                default:
                    return false;

            }
            return true;
        }

        static Outcome parse(ReadOnlySpan<char> src, out TableNumber dst)
        {
            const string Marker = "Table ";
            const byte MarkerLength = 6;
            const char DigitSep = Chars.Dash;
            const char NumberEnd = Chars.Dot;
            dst = TableNumber.Empty;

            var i = TableNumber.MarkerIndex(src);
            if(i != NotFound)
            {
                dst = table(slice(src, i + MarkerLength));
                return true;
            }
            return false;
        }


        void ProcessCombinedToc()
        {
            var vols = VolumeMarkers(1,4);
            var src = CombinedTocPath();
            using var reader = src.LineReader();
            var buffer = TextTools.buffer();
            while(reader.Next(out var line))
            {
                if(vols.CoversAny(line.Content))
                {
                    continue;

                }

                if(parse(line.Content, out SectionNumber section))
                {

                    render(section, buffer);

                    Wf.Row(string.Format("{0}:{1}", line.LineNumber, buffer.Emit()));

                    continue;
                }

                if(parse(line.Content, out TableNumber number))
                {
                    Wf.Row(string.Format("{0}:{1}", line.LineNumber, number));
                    continue;
                }
            }

        }

        public void Run()
        {
            ProcessCombinedToc();
        }

        public void CreateCombinedToc()
        {
            var specs = LoadSplitSpecs();
            var count = specs.Length;
            var paths = span<FS.FilePath>(count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specs,i);
                if(spec.Unit.Contains("TOC"))
                    seek(paths, counter++) = DocExtractPath(spec.Unit, FS.Txt);
            }

            var src = slice(paths,0,counter);
            var dst = CombinedTocPath();
            iter(src, x => Wf.Row(x));
            var flow = Wf.Running(string.Format("Creating combined toc from {0} source files", src.Length));
            DocServices.CombineDocs(src, dst);
            Wf.Ran(flow);
        }

        public bool CreateLinedSdm()
        {
            var src = SdmRefPath();
            var dst = LinedSdmPath();
            var result = DocServices.CreateLinedDoc(src, dst);
            if(!result)
                return false;

            var verified = DocServices.VerifyLinedDoc(dst);
            if(verified.Fail)
                Wf.Error(verified.Message);

            return verified;
        }

        FS.FilePath SdmSplitSpecs()
            => Archive.Root + FS.file("splits", FS.Csv);

        FS.FilePath SdmRefPath()
            => RefDocPath("sdm");

        FS.FilePath LinedSdmPath()
            => DocExtractPath("sdm-lined", FS.Txt);

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