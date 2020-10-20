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


        readonly IWfShell Wf;

        readonly ToolPaths Paths;

        [MethodImpl(Inline)]
        public Tooling(IWfShell wf, in ToolPaths paths)
        {
            Wf = wf;
            Paths = paths;
        }

        [MethodImpl(Inline)]
        public static ToolEmission<T,F> file<T,F>(F kind, FS.FilePath path)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => new ToolEmission<T,F>(kind, path);

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

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(ToolId<T> src)
            =>  src.Name;

        [MethodImpl(Inline), Op]
        public static string format(ToolCommand src)
            => src.Format();

        [MethodImpl(Inline), Op]
        public static ToolStatus status(ToolProcess runner)
            => runner.Status();

        [MethodImpl(Inline), Op]
        public static ref ToolStatus status(ToolProcess runner, ref ToolStatus dst)
            => ref runner.Status(ref dst);
    }
}