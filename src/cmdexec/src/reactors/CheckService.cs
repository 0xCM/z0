//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    sealed class CheckService : CmdReactor<CheckServiceCmd>
    {
        protected override CmdResult Run(CheckServiceCmd cmd)
        {
            Wf.Status(cmd.Format());
            CheckBitMasks();
            return Cmd.ok(cmd);
        }

        void CheckBitMasks()
        {
            var asmWf = AsmServices.workflow(Wf);
            var methods = typeof(BitMaskChecker).Methods().WithNameStartingWith("CheckLoMask");
            var dst = Db.AppDataFile(FS.file("bitmasks", FS.Extensions.Asm));
            var routines = asmWf.Decode(methods, dst);
            Wf.CmdBuilder().CheckBitmasks().RunTask(Wf);
        }

        void Run59()
        {
            {
                new CheckResources().Run(Wf);
            }


            {
                CheckCredits.create(Wf).Run();
            }


            {
                var flow = Wf.Running();
                using var kernel = NativeModules.kernel32();
                Wf.Row(kernel);

                var f = NativeModules.func<OS.Delegates.GetProcAddress>(kernel, nameof(OS.Delegates.GetProcAddress));
                Wf.Row(f);

                var a = (MemoryAddress)f.Invoke(kernel, "CreateDirectoryA");
                Wf.Row(a);

                Wf.Ran(flow);
            }
        }
    }
}