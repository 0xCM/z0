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

    [ApiHost]
    public partial struct Tools : IDisposable
    {
        [MethodImpl(Inline)]
        public static ToolFile<T,F> file<T,F>(F kind, FS.FilePath path)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => new ToolFile<T,F>(kind, path);

        [Op]
        public static ToolLogger logger<T>(IWfShell context, T id)
            where T : unmanaged, Enum
                => logger(context, id.ToString());

        [Op]
        public static ToolLogger logger(IWfShell wf, string name)
        {
            var dst = wf.Paths.AppDataRoot + FileName.define(name, FileExtensions.StatusLog);
            return new ToolLogger(wf,dst);
        }

        [Op]
        public static ToolProcess runner(IWfShell context, string command, ToolProcessOptions config)
            => new ToolProcess(command, config);

        [MethodImpl(Inline), Op]
        public static ToolConfig config(ToolId tool,FolderPath src, FolderPath dst)
            => new ToolConfig(tool,src,dst);

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
        public static ToolSpec specify(string tool, ToolFlag[] flags, ToolOption[] options)
            => new ToolSpec(tool,flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T>(ToolFlag[] flags, ToolOption[] options)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags,options);

        [MethodImpl(Inline), Op]
        public static ToolFlag flag(string name)
            => name;

        [MethodImpl(Inline)]
        public static string name<E>(E @enum)
            where E : unmanaged, Enum
        {
            return @enum.ToString();
        }


        [MethodImpl(Inline)]
        public static ToolSpec specify<T,F>(F[] flags, ToolOption[] options, T tool = default)
            where T : unmanaged
            where F : unmanaged, Enum
                => new ToolSpec(typeof(T).Name, flags.Map(f => flag(f.ToString())), options);

        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolId<T> identify<T>()
            => default;

        /// <summary>
        /// Creates a type-predicated tool identifier
        /// </summary>
        [MethodImpl(Inline)]
        public static ToolId identify(Type t)
            => new ToolId(t);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(ToolId<T> src)
            =>  src.Name;

        [MethodImpl(Inline), Op]
        public static string format(ToolCommand src)
            => src.Format();

        /// <summary>
        /// Creates a tool process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [Op]
        public static ToolProcess process(string commandLine, ToolProcessOptions options = null)
            => ToolProcess.create(commandLine, options ?? new ToolProcessOptions());

        [Op]
        public static ToolStatus status(ToolProcess runner)
            => runner.Status();

        [Op]
        public static ref ToolStatus status(ToolProcess runner, ref ToolStatus dst)
            => ref runner.Status(ref dst);

        [Op]
        public static ToolPaths paths(KeyedValues<ToolId,FS.FilePath> src)
        {
            var count = (uint)src.Count;
            var tools = alloc<ToolId>(count);
            var paths = alloc<FS.FilePath>(count);
            ref var tid = ref tools[0];
            ref var pid = ref paths[0];
            ref readonly var kv = ref src.First;
            for(var i=0u; i<count; i++)
            {
                ref readonly var pair = ref skip(kv,i);
                seek(tid,i) = pair.Key;
                seek(pid,i) = pair.Value;
            }
            return new ToolPaths(tools,paths);
        }

        readonly IWfShell Wf;

        readonly ToolPaths Paths;

        [MethodImpl(Inline)]
        public Tools(IWfShell wf, in ToolPaths paths)
        {
            Wf = wf;
            Paths = paths;
        }

        // public ProcessResult Run(ToolCommand src)
        // {
        //     var result = ProcessHelper.Run(src.ToolPath.Name, src.Args.Format());
        //     Wf.Status(StepId,result.Output);
        //     return result;
        // }

        public void Dispose()
        {

        }
    }
}