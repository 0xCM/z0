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

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct ToolCmd
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static ref CmdRuleInfo rule(IEnvPaths paths, ref CmdRuleInfo data)
        {
            data.CmdRoot = paths.ToolExeRoot() +  data.CmdRootName;
            data.CmdName = FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", data.CmdHost, data.CmdArgName), FS.Log);
            data.CmdOutDir = paths.ToolOutDir(data.CmdHost);
            data.CmdOutPath = data.CmdOutDir + FS.file(data.CmdHost);
            data.ToolArgs = string.Format("{0}{0}", data.ArgPrefix, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.ToolArgs);
            return ref data;
        }

        [Op]
        public static ref CmdRuleInfo rule(IEnvPaths paths, ref CmdRuleInfo data,
            string root = null, string name = null, string arg = null, ArgPrefix? prefix = null, string type = null)
        {
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.CmdArgName = arg == null ? data.CmdArgName : (Name)arg;
            data.ArgPrefix = prefix != null ? prefix.Value: data.ArgPrefix;
            data.ScriptType = type == null ? data.ScriptType : FS.ext(type);
            rule(paths, ref data);
            return ref data;
        }

        [Op, Closures(UInt64k)]
        public static ToolExecSpec untype<T>(in T spec)
            where T : struct
        {
            var t = typeof(T);
            var fields = Clr.fields(t);
            var count = fields.Length;
            var reflected = alloc<FieldValue>(count);
            Tables.values(spec, fields, reflected);
            var buffer = alloc<ToolCmdArg>(count);
            var target = span(buffer);
            var source = @readonly(reflected);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(source,i);
                seek(target,i) = new ToolCmdArg(fv.Field.Name, fv.Value?.ToString() ?? EmptyString);
            }
            return new ToolExecSpec(CmdId.from(t), buffer);
        }

        /// <summary>
        /// Populates a <see cref='ToolCmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdArg untype<T>(in ToolCmdArg<T> src)
        {
            var dst = new ToolCmdArg();
            untype(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='ToolCmdArg'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ToolCmdArg untype<T>(in ToolCmdArg<T> src, ref ToolCmdArg dst)
        {
            dst = new ToolCmdArg(src.Name, src.Value.ToString());
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static CmdJob<T> job<T>(string name, T spec)
            where T : struct, ITextual
                => new CmdJob<T>(name, spec);

        public static FS.FilePath enqueue<T>(CmdJob<T> job, IWfDb db)
            where T : struct, ITextual
        {
            var dst = db.JobQueue() + FS.file(job.Name.Format(), FS.Cmd);
            dst.Overwrite(job.Format());
            return dst;
        }

        /// <summary>
        /// Creates a <see cref='ToolCmdArgs'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static ScriptPattern pattern(string id, string spec)
            => new ScriptPattern(id, spec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ScriptPattern<K> pattern<K>(K id, string content)
            where K : unmanaged
                => new ScriptPattern<K>(id,content);

        public static async Task<int> start(ToolCmdSpec spec, Action<string> status, Action<string> error)
        {
            var info = new ProcessStartInfo
            {
                FileName = spec.ToolPath.Name,
                Arguments = spec.Args.Format(),
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            var process = new Process {StartInfo = info};

            if (!spec.WorkingDir.IsNonEmpty)
                process.StartInfo.WorkingDirectory = spec.WorkingDir.Name;

            root.iter(spec.EnvVars.Storage, v => process.StartInfo.Environment.Add(v.Name, v.Value));
            process.OutputDataReceived += (s,d) => status(d.Data ?? EmptyString);
            process.ErrorDataReceived += (s,d) => error(d.Data ?? EmptyString);
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

        [MethodImpl(Inline), Op]
        public static CmdExecStatus status(ScriptProcess process)
            => process.Status();

        [MethodImpl(Inline), Op]
        public static ref CmdExecStatus status(ScriptProcess process, ref CmdExecStatus dst)
            => ref process.Status(ref dst);


        [Op]
        public static ToolCmdSpec specify(FS.FilePath path, params ToolCmdArg[] args)
        {
            var dst = new ToolCmdSpec();
            dst.ToolPath = path;
            dst.Args = args.Select(x => x.Format());
            dst.EnvVars = NamedValues.empty<string>();
            dst.WorkingDir = FS.dir(Environment.CurrentDirectory);
            return dst;
        }
    }
}