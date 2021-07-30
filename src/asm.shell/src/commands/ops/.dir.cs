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
            var result = Outcome.Success;

            var spec = string.Empty;
            if(args.Length == 0)
                spec = string.Format("dir {0} /s/b", State.CurrentDir().Format(PathSeparator.BS));
            else
                spec = string.Format("dir {0}\\{1} /s/b", State.CurrentDir().Format(PathSeparator.BS), FS.dir(arg(args,0)).Format(PathSeparator.BS));

            Write(spec);

            result = RunWinCmd(spec, out var response);
            if(result.Fail)
                return result;

            var count = response.Length;
            var paths = alloc<FS.FilePath>(count);
            for(var i=0; i<count; i++)
                seek(paths,i) = FS.path(skip(response,i).Content);

            Files(paths);
            return result;
        }

        // [CmdOp(".dir-proj-out")]
        // Outcome DirProjOut(CmdArgs args)
        // {
        //     var result = Outcome.Success;
        //     var outdir = Projects().Out(arg(args,0).Value);
        //     var spec = string.Empty;
        //     if(args.Length == 2)
        //         spec = string.Format("dir {0}\\{1} /s/b", outdir.Format(PathSeparator.BS), FS.dir(arg(args,1)).Format(PathSeparator.BS));
        //     else
        //         spec = dir(outdir);

        //     Write(spec);

        //     result = RunWinCmd(spec, out var response);
        //     if(result.Fail)
        //         return result;

        //     var count = response.Length;
        //     var paths = alloc<FS.FilePath>(count);
        //     for(var i=0; i<count; i++)
        //         seek(paths,i) = FS.path(skip(response,i).Content);

        //     Files(paths);

        //     return result;
        // }

        // static string dir(FS.FolderPath src)
        //     => string.Format("dir {0} /s/b", src.Format(PathSeparator.BS));
    }
}