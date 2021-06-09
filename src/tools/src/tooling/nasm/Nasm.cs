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


        public NasmOutputFile OutFile(FS.FilePath path, NasmOutFileKind kind = NasmOutFileKind.bin)
            => new NasmOutputFile(path, kind);

        public CmdLine CmdLine(FS.FilePath src, NasmOutputFile dst)
        {
            const string Pattern = "{0} -f {1} {2} -o {3}";
            return new CmdLine(string.Format(Pattern, Id, dst.Kind, src.Format(PathSeparator.BS), dst.Path.Format(PathSeparator.BS)));
        }
   }
}