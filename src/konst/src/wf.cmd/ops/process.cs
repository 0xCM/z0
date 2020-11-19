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

    partial struct Cmd
    {
        /// <summary>
        /// Creates a command process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [MethodImpl(Inline), Op]
        public static CmdProcess process(IWfShell wf, CmdLine command, CmdProcessOptions config)
            => new CmdProcess(wf, command, config);

        [MethodImpl(Inline), Op]
        public static CmdProcess process(IWfShell wf,  CmdLine commandLine)
            => new CmdProcess(wf, commandLine, new CmdProcessOptions());
    }
}