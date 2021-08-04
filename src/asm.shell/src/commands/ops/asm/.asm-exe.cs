//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Diagnostics;

    partial class AsmCmdService
    {
        [CmdOp(".asm-exe")]
        Outcome AsmExe(CmdArgs args)
        {
            const string LinkPattern = @"j:\source\llvm\llvm-project\build\bin\clang-cl.exe  /MT {0} /link /entry:main /subsystem:console kernel32.lib /out:{1}";

            var result = Outcome.Success;
            var id = arg(args,0).Value;

            var asm = AsmWs.AppPath(id);
            var obj = AsmWs.ObjPath(id);
            var exe = AsmWs.ExePath(id);

            result = BuildAsmObj(id, AsmWs.AsmAppSrc(), AsmWs.ObjOut());
            if(result.Fail)
                return result;

            Write(FS.flow(asm,obj));

            var cmd2 = string.Format(LinkPattern, obj, exe);
            result = RunWinCmd(cmd2, out _);

            if(result.Fail)
                return result;

            Write(FS.flow(obj,exe));

            var clock = Time.counter(true);
            var process = Process.Start(exe.Format());
            process.WaitForExit();
            var duration = clock.Elapsed();
            Write(string.Format("runtime:{0}", duration));
            return result;
        }
    }
}
