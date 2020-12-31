//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    [Cmd(CmdName)]
    public struct RunStepCmd : ICmdSpec<RunStepCmd>
    {
        public const string CmdName ="run-step";

        public string StepName;
    }

    partial class XCmd
    {
        [Op]
        public static RunStepCmd RunStep(this CmdBuilder builder, string name)
        {
            var dst = new RunStepCmd();
            dst.StepName = name;
            return dst;
        }
    }
}