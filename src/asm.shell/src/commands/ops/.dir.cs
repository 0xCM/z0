//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".dir")]
        Outcome Dir(CmdArgs args)
        {
            var location = FS.dir(arg(args,0));
            var spec = string.Empty;
            if(args.Length > 1)
                spec = string.Format("dir {0}\\{1} /s/b", location.Format(PathSeparator.BS), arg(args,1));
            else
                spec = string.Format("dir {0} /s/b", location.Format(PathSeparator.BS));
            var cmd = WinCmd.cmd(spec);
            var runner = Wf.CmdLineRunner();
            var response = runner.Run(cmd);
            var count = response.Length;
            var paths = alloc<FS.FilePath>(count);
            for(var i=0; i<count; i++)
                seek(paths,i) = FS.path(skip(response,i).Content);

            Files(paths);
            return true;
        }
    }
}