//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    [ApiHost]
    public sealed partial class Nasm : ToolService<Nasm>
    {
        readonly BitFormatter<byte> BitFormat;

        public Nasm()
            : base(Toolsets.nasm)
        {
            BitFormat = BitRender.formatter<byte>(4);
        }

        const PathSeparator Sep = PathSeparator.BS;

        public NasmOutputFile OutFile(FS.FilePath path, ObjFileKind kind = ObjFileKind.bin)
            => new NasmOutputFile(path, kind);

        public CmdLine Command(FS.FilePath src, NasmOutputFile dst)
        {
            const string Pattern = "{0} -f {1} {2} -o {3}";
            return new CmdLine(string.Format(Pattern, Id, dst.Kind,
                src.Format(Sep), dst.Path.Format(Sep)));
        }

        public CmdLine Command(FS.FilePath src, NasmOutputFile dst, NasmListFile list)
        {
            const string Pattern = "{0} -f {1} {2} -o {3} -l {4}";
            return new CmdLine(string.Format(Pattern, Id, dst.Kind,
                src.Format(Sep), dst.Path.Format(Sep), list.Path.Format(Sep)));
        }

        public static MsgPattern<Count> ParsingNasmListEntries => "Parsing list entries from {0} lines";

        public static MsgPattern<Count> ParsedNasmListEntries => "Parsing {0} list entries";

        public static MsgPattern<FS.FileUri> ReadingNasmListing => "Reading nasm listing from {0}";

        public static MsgPattern<Count,FS.FileUri> ReadNasmListing => "Read {0} nasm list lines from {1}";
   }
}