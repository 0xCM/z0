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

    partial struct Cmd
    {
        /// <summary>
        /// Creates a command process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [MethodImpl(Inline), Op]
        public static CmdProcess run(IWfShell wf, CmdLine command, CmdProcessOptions config)
            => new CmdProcess(wf, command, config);

        [MethodImpl(Inline), Op]
        public static CmdProcess run(IWfShell wf,  CmdLine command)
            => new CmdProcess(wf, command, new CmdProcessOptions());

        [MethodImpl(Inline), Op]
        public static CmdProcess run(IWfShell wf,  CmdLine command, TextWriter output)
            => new CmdProcess(wf, command, new CmdProcessOptions(output));
    }
}