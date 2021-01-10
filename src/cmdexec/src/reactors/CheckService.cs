//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public sealed class CheckService : CmdReactor<CheckServiceCmd>
    {
        protected override CmdResult Run(CheckServiceCmd cmd)
        {
            Wf.Status(cmd.Format());

            return Cmd.ok(cmd);
        }


        void CheckBitMasks()
        {
            var asmWf = AsmWorkflows.create(Wf);
            var methods = typeof(BitMaskChecker).Methods().WithNameStartingWith("CheckLoMask");
            var dst = Wf.AppData + FS.file("bitmasks", FileExtensions.Asm);
            var routines = asmWf.Decode(methods, dst);
            Wf.Router.Dispatch(CheckBitMasksReactor.Spec());
        }

        void Run59()
        {
            {
                new CheckResources().Run(Wf);
            }


            {
                using var step = new CheckCredits(Wf, new CheckCreditsHost());
                step.Run();
            }


            {
                var flow = Wf.Running(Host);

                using var kernel = NativeModules.kernel32();
                Wf.Row(kernel);

                var f = NativeModules.func<OS.Delegates.GetProcAddress>(kernel, nameof(OS.Delegates.GetProcAddress));
                Wf.Row(f);

                var a = (MemoryAddress)f.Invoke(kernel, "CreateDirectoryA");
                Wf.Row(a);

                Wf.Ran(flow, Host);
            }
        }

    }

}