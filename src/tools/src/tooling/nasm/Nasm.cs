//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using Z0.Asm;

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

        public NasmOutputFile OutFile(FS.FilePath path, AsmBinKind kind = AsmBinKind.bin)
            => new NasmOutputFile(path, kind);

        public CmdLine cmd(FS.FilePath src, NasmOutputFile dst)
        {
            const string Pattern = "{0} -f {1} {2} -o {3}";
            return new CmdLine(string.Format(Pattern, Id, dst.Kind,
                src.Format(Sep), dst.Path.Format(Sep)));
        }

        public CmdLine cmd(FS.FilePath src, NasmOutputFile dst, NasmListFile list)
        {
            const string Pattern = "{0} -f {1} {2} -o {3} -l {4}";
            return new CmdLine(string.Format(Pattern, Id, dst.Kind,
                src.Format(Sep), dst.Path.Format(Sep), list.Path.Format(Sep)));
        }
   }
}