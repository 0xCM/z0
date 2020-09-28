//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using static Konst;
    using static z;

    [ApiHost("api")]
    public readonly partial struct Tooling
    {
        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolId<T> identify<T>()
            => default;

        /// <summary>
        /// Creates a predicated tool identifier
        /// </summary>
        [MethodImpl(Inline)]
        public static ToolId identify(Type t)
            => new ToolId(t);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(ToolId<T> src)
            =>  src.Name;

        public static async Task<int> start(ToolExecSpec spec, WfStatusRelay dst)
        {
            var info = new ProcessStartInfo
            {
                FileName = spec.ToolPath.Name,
                Arguments = spec.Args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            var process = new Process {StartInfo = info};

            if (!spec.WorkingDir.IsNonEmpty)
                process.StartInfo.WorkingDirectory = spec.WorkingDir.Name;

            iter(spec.Vars.Storage, v => process.StartInfo.Environment.Add(v.Name, v.Value));

            process.OutputDataReceived += (s,d) => dst.OnInfo(d.Data ?? EmptyString);
            process.ErrorDataReceived += (s,d) => dst.OnError(d.Data ?? EmptyString);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            return await wait(process);
        }

        static async Task<int> wait(Process process)
        {
            return await Task.Run(() => {
                process.WaitForExit();
                return Task.FromResult(process.ExitCode);
            });
        }

        /// <summary>
        /// Creates a tool process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        public static ToolProcess process(string commandLine, ToolProcessOptions options = null)
            => ToolProcess.create(commandLine, options ?? new ToolProcessOptions());

        [Op]
        public static ToolStatus status(ToolProcess runner)
            => runner.Status();

        [Op]
        public static ref ToolStatus status(ToolProcess runner, ref ToolStatus dst)
            => ref runner.Status(ref dst);

        internal static FolderPath ToolSourceDir
            => FolderPath.Define("J:/assets/tools");

        [MethodImpl(Inline)]
        public static string name<E>(E @enum)
            where E : unmanaged, Enum
        {
            return @enum.ToString();
        }

        [MethodImpl(Inline)]
        public static ToolOption option<E>(E kind, string value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value);

        [MethodImpl(Inline), Op]
        public static ToolOption option(string name, string value)
            => new ToolOption(name, value);

        [MethodImpl(Inline)]
        public static ToolOption value<E,V>(E kind, V value)
            where E : unmanaged, Enum
                => new ToolOption(kind.ToString(), value.ToString());

        [MethodImpl(Inline), Op]
        public static ToolFlag flag(string name)
            => name;

        [MethodImpl(Inline), Op]
        public static ToolSpec specify(string tool, ToolFlag[] flags, ToolOption[] options)
            => new ToolSpec(tool,flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T>(ToolFlag[] flags, ToolOption[] options)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T,F>(F[] flags, ToolOption[] options, T tool = default)
            where T : unmanaged
            where F : unmanaged, Enum
                => new ToolSpec(typeof(T).Name, flags.Map(f => flag(f.ToString())), options);
    }
}