//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    partial struct ToolCmd
    {
        /// <summary>
        /// Creates a command process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command, ScriptProcessOptions config)
            => new ScriptProcess(command, config);

        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command)
            => new ScriptProcess(command, new ScriptProcessOptions());

        [MethodImpl(Inline), Op]
        public static ScriptProcess run(CmdLine command, TextWriter output)
            => new ScriptProcess(command, new ScriptProcessOptions(output));
    }
}