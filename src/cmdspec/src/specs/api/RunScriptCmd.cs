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
    public struct RunScriptCmd : ICmd<RunScriptCmd>
    {
        public const string CmdName = "run-script";

        /// <summary>
        /// The script path
        /// </summary>
        public FS.FilePath ScriptPath;
   }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static RunScriptCmd RunScript(this WfCmdBuilder builder, FS.FilePath path)
        {
            var cmd = new RunScriptCmd();
            cmd.ScriptPath = path;
            return cmd;
        }
    }
}