//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llc-obj", "llc -> obj")]
        public Outcome LlcObj(CmdArgs args)
        {
            var outcome = Outcome.Success;
            var iset = args.Length != 0 ? arg(args,0).Value : "+avx512f";
            var input = Files().View;
            var output = list<FS.FilePath>();

            foreach(var file in input)
            {
                var vars = Cmd.vars(
                    ("SrcFile", file.FileName.Format()),
                    ("iset", iset),
                    ("SrcDir", file.FolderPath.Format(PathSeparator.BS))
                    );

                var cmd = Cmd.cmdline(ToolBase().Script(Toolspace.llvm_llc, "emit-obj").Format(PathSeparator.BS));
                var response = ScriptRunner.RunCmd(cmd, vars);
                var outfile = Lines.prop(response,"DstPath");
                if(text.nonempty(outfile))
                {
                    var outpath = FS.path(outfile);
                    Status(string.Format("Emitted {0}", outpath.Format()));
                    output.Add(outpath);
                }
            }

            Files(output.ToArray(), false);

            return outcome;
        }
    }
}