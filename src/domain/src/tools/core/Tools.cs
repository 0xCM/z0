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

    [ApiHost("tooling", true)]
    public partial struct Tooling
    {
        const NumericKind Closure = UnsignedInts;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public static ToolId toolid<T>()
            where T : struct, IToolCmd<T>
                => type<T>().Tag<ToolCmdAttribute>().MapValueOrElse(a => new ToolId(a.ToolName), () => ToolId.Empty);

        [MethodImpl(Inline)]
        public static CmdTarget<T,F> target<T,F>(F kind, FS.FilePath path)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => new CmdTarget<T,F>(kind, path);

        [MethodImpl(Inline), Op]
        public static CmdParser parser()
            => CmdParser.create();

        /// <summary>
        /// Creates a tool process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [Op]
        public static ToolProcess process(IWfShell context, string command, ToolProcessOptions config)
            => ToolProcess.create(command, config);

        [MethodImpl(Inline)]
        public static ToolOption value<E,V>(E kind, V value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value.ToString());

        [MethodImpl(Inline), Op]
        public static ToolFlag flag(string name)
            => name;

        [MethodImpl(Inline)]
        public static string name<E>(E @enum)
            where E : unmanaged, Enum
                => @enum.ToString();

        [MethodImpl(Inline), Op]
        public static CmdExecStatus status(ToolProcess runner)
            => runner.Status();

        [MethodImpl(Inline), Op]
        public static ref CmdExecStatus status(ToolProcess runner, ref CmdExecStatus dst)
            => ref runner.Status(ref dst);
    }
}