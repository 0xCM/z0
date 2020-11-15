//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    sealed class CheckBitMasksReactor : CmdReactor<CheckBitMasksReactor,CheckBitMasksCmd,Outcome>
    {
        protected override Outcome Run(CheckBitMasksCmd cmd)
        {
            var log = text.build();
            using var step = new BitMaskChecker(Wf, Host, Wf.PolySource, log);
            step.Run();
            return true;
        }
    }
}