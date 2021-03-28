//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct RunPartCmd : ICmd<RunPartCmd>
    {
        public const string CmdName = "run-part";

        /// <summary>
        /// Identifies the part for which the executor, if it exists, will be executed
        /// </summary>
        public PartId PartId;
    }

    partial class XCmd
    {

        [MethodImpl(Inline), Op]
        public static RunPartCmd RunPart(this WfCmdBuilder builder, PartId id)
        {
            var cmd = new RunPartCmd();
            cmd.PartId = id;
            return cmd;
        }
    }
}
