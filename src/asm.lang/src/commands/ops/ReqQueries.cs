//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Root;
    using static core;
    using static AsmCodes;

    partial class AsmCmdService
    {
        // void OnJobComplete()
        // {
        //     ref readonly var context = ref first(recover<Amd64Context>(_NativeBuffer.Edit));
        //     Wf.Row(EmptyString);
        //     Wf.Row(string.Format("RIP:{0:x}", context.Rip));
        //     Wf.Row(string.Format("LastBranchFromRip:{0:x}", context.LastBranchFromRip));
        //     Wf.Row(string.Format("RAX:{0:x}", context.Rax));
        //     Wf.Row(string.Format("RCX:{0:x}", context.Rcx));
        //     Wf.Row(string.Format("RDX:{0:x}", context.Rdx));
        //     Wf.Row(string.Format("RBX:{0:x}", context.Rbx));
        //     Wf.Row(string.Format("EFlags:{0:x}", context.EFlags.FormatBits()));
        // }

        void SubmitJob(Action job)
        {
            //Arbiter.Enque(job, OnJobComplete);
        }

        static uint CountA;

        static uint CountB;

        [CmdOp(".regs")]
        unsafe Outcome ShowRegVals(CmdArgs args)
        {
            static void calc()
            {
                var ts = (ulong)Timestamp.now();
                if(ts % 2 == 0)
                    CountB++;
                else
                    CountA++;
            }

            SubmitJob(calc);
            return true;
        }

        [CmdOp(".regnames")]
        Outcome ShowRegs(CmdArgs args)
        {
            var regs = AsmRegs.list(GP);
            iter(regs, reg => Wf.Row(reg));
            return true;
        }
    }
}