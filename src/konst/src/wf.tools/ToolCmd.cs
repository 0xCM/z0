//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using static Part;
    using static memory;
    using static root;

    using ACC = AsciCharCode;

    [ApiHost]
    public readonly struct ToolCmd
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolCmdLogger logger<T>(IDbPaths paths,  T id)
            where T : unmanaged
                => logger(paths, id.ToString());

        [MethodImpl(Inline), Op]
        public static ToolCmdLogger logger(IDbPaths paths, string name)
            => new ToolCmdLogger(paths.CmdLogRoot() + FS.file(name, FS.Extensions.StatusLog));

        [MethodImpl(Inline)]
        public static CmdJob<T> job<T>(string name, T spec)
            where T : struct, ITextual
                => new CmdJob<T>(name, spec);

        public static FS.FilePath enqueue<T>(CmdJob<T> job, IWfDb db)
            where T : struct, ITextual
        {
            var dst = db.JobQueue() + FS.file(job.Name.Format(), FS.Extensions.Cmd);
            dst.Overwrite(job.Format());
            return dst;
        }

        /// <summary>
        /// Creates a <see cref='CmdArgs'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static CmdPattern pattern(string id, string spec)
            => new CmdPattern(id, spec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdPattern<K> pattern<K>(K id, string content)
            where K : unmanaged
                => new CmdPattern<K>(id,content);

        public static async Task<int> start(ToolCmdSpec spec, WfStatusRelay dst)
        {
            var info = new ProcessStartInfo
            {
                FileName = spec.CmdPath.Name,
                Arguments = spec.Args.Format(),
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true
            };

            var process = new Process {StartInfo = info};

            if (!spec.WorkingDir.IsNonEmpty)
                process.StartInfo.WorkingDirectory = spec.WorkingDir.Name;

            root.iter(spec.Vars.Storage, v => process.StartInfo.Environment.Add(v.Name, v.Value));

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

        [MethodImpl(Inline), Op]
        public static CmdExecStatus status(CmdProcess process)
            => process.Status();

        [MethodImpl(Inline), Op]
        public static ref CmdExecStatus status(CmdProcess process, ref CmdExecStatus dst)
            => ref process.Status(ref dst);

        /// <summary>
        /// Creates an option without purpose
        /// </summary>
        /// <param name="name">The option name</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name)
            => new CmdOptionSpec(name);

        /// <summary>
        /// Creates a meaningful option
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name, string purpose)
            => new CmdOptionSpec(name, purpose);

        /// <summary>
        /// Creates a meaningful option with non-default protocol
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        /// <param name="purpose">The invocation protocol</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name, string purpose, ArgPrefix prefix)
            => new CmdOptionSpec(name, purpose, prefix);

        /// <summary>
        /// Creates a meaningful option with non-default protocol
        /// </summary>
        /// <param name="name">The option name</param>
        /// <param name="purpose">The option's significance</param>
        /// <param name="purpose">The invocation protocol</param>
        [MethodImpl(Inline), Factory]
        public static CmdOptionSpec option(string name, string purpose, ArgProtocol protocol)
            => new CmdOptionSpec(name, purpose, protocol);

        [Op]
        public static ParseResult<CmdExecSpec> parse(string src, string delimiter = EmptyString, char qualifier = ' ')
        {
            var fail = unparsed<CmdExecSpec>(src);
            var parts = text.split(src, delimiter).View;
            var count = parts.Length;
            ushort pos = 0;
            if(count != 0)
            {
                ref readonly var part = ref first(parts);
                var id = Cmd.id(part);
                var options = list<CmdArg>();
                for(var i=1; i<count; i++)
                {
                    ref readonly var next = ref skip(parts,i);
                    if(!text.blank(next))
                    {
                        var option = arg(pos++,next, qualifier);
                        if(option)
                            options.Add(option.Value);
                        else
                            return fail.WithReason(InvalidOption);
                    }
                }
                return parsed(src, new CmdExecSpec(id, options.ToArray()));
            }

            return fail;
        }

        [Op]
        static ParseResult<CmdArg> arg(ushort pos, string src, char qualifier = ' ')
        {
            try
            {
                var i = src.IndexOf(qualifier);
                if(i == NotFound)
                    return parsed(src, new CmdArg(pos, src));
                else
                    return parsed(src, new CmdArg(pos, src.LeftOfIndex(i), src.RightOfIndex(i)));
            }
            catch(Exception e)
            {
                return unparsed<CmdArg>(src,e);
            }
        }

        internal const string InvalidOption = "Option text invalid";

        [MethodImpl(Inline), Factory]
        public ArgQualifier qualifier(AsciCharCode src)
            => new ArgQualifier(src);

        [MethodImpl(Inline), Factory]
        public ArgProtocol protocol(ArgPrefix prefix, AsciCharCode? qualifier = null)
            => new ArgProtocol(prefix, qualifier ?? AsciCharCode.Space);

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from a specified character
        /// </summary>
        /// <param name="c0">The delimiter</param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(char c0)
            => new ArgPrefix((ACC)c0);

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from two specified characters
        /// </summary>
        /// <param name="c0">The first part of the delimiter</param>
        /// <param name="c1">The second part of the delimiter</param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(char c0, char c1)
            => new ArgPrefix((ACC)c0, (ACC)c1);

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from the leading source element(s)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(string src)
            => prefix(memory.chars(src));

        /// <summary>
        /// Creates a <see cref='ArgPrefix'/> from the leading source element(s)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static ArgPrefix prefix(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            if(count == 0)
                return ArgPrefix.Empty;
            else if(count == 1)
                return new ArgPrefix((ACC)memory.skip(src, 0));
            else
                return new ArgPrefix((ACC)memory.skip(src, 0), (ACC)memory.skip(src, 1));
        }

        [Op]
        public static string format(in CmdScript src)
        {
            var dst = Buffers.text();
            render(src, dst);
            return dst.Emit();
        }

        [Op]
        public static void render(CmdScript src, ITextBuffer dst)
        {
            var count = src.Length;
            var parts = src.View;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(parts,i).Format());
        }

        [Op]
        public static void render(CmdArgs src, ITextBuffer dst)
        {
            var count = src.Count;
            for(var i=0u; i<count; i++)
            {
                dst.Append(Cmd.format(src[i]));
                if(i != count - 1)
                    dst.Append(Space);
            }
        }


        [Op]
        public static string format(in CmdScriptExpr src)
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static string format<K>(in CmdScriptExpr<K> src)
            where K : unmanaged
            => format(src.Pattern, src.Variables.Storage);

        [Op]
        public static CmdScriptExpr format(in CmdPattern pattern, params CmdVar[] args)
            => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern<K> pattern, params CmdVar[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op, Closures(Closure)]
        public static CmdScriptExpr format<K>(in CmdPattern pattern, params CmdVar<K>[] args)
            where K : unmanaged
                => string.Format(pattern.Content, args.Select(a => a.Format()));

        [Op]
        public static string format(in CmdFlagSpec src)
            => src.Name.IsEmpty ? src.Index.ToString() : string.Format("{0}:{1}", src.Name, src.Index);

        [Formatter]
        public static string format(ArgPrefix src)
        {
            var len = src.Length;
            if(len == 0)
                return EmptyString;
            else if(len == 1)
            {
                Span<char> content = stackalloc char[1]{(char)src.C0};
                return new string(content);
            }
            else
            {
                Span<char> content = stackalloc char[2]{(char)src.C0, (char)src.C1};
                return new string(content);
            }
        }


        [MethodImpl(Inline), Op]
        public static CmdArg<T> arg<T>(string name, T value)
            => new CmdArg<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, T value)
            => new CmdArg<T>(pos, value);

        [MethodImpl(Inline), Op]
        public static CmdArg<T> arg<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new CmdArg<T>(pos, name, value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, string name, T value, ArgPrefix prefix, ArgQualifier qualifier)
            => new CmdArg<T>(pos, name, value, (prefix, qualifier));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, string name, T value, ArgProtocol protocol)
            => new CmdArg<T>(pos, name, value, protocol);

        [MethodImpl(Inline)]
        public static CmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new CmdArg<K,T>(kind,value);

        [MethodImpl(Inline), Op]
        public static CmdFlagArg<T> flag<T>(string name, T value, ArgPrefix prefix)
            => new CmdFlagArg<T>(name, value, prefix);

        [MethodImpl(Inline), Op]
        public static CmdFlagArg<T> flag<T>(ushort pos, T value, ArgPrefix prefix)
            => new CmdFlagArg<T>(pos, value.ToString(), value, prefix);

        [MethodImpl(Inline), Op]
        public static CmdFlagArg<T> flag<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new CmdFlagArg<T>(pos, name, value, prefix);

        [MethodImpl(Inline), Op]
        public static ToolCmdArg arg(string content)
            => new ToolCmdArg(content);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(CmdPattern pattern)
            => new CmdScriptExpr(pattern);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(in Paired<CmdPattern,CmdVarIndex> src)
            => new CmdScriptExpr(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(CmdPattern pattern, CmdVarIndex vars)
            => new CmdScriptExpr(pattern, vars);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdScriptExpr<K> expr<K>(CmdPattern pattern, CmdVarIndex<K> content)
            where K : unmanaged
                => new CmdScriptExpr<K>(pattern, content);

        [MethodImpl(Inline)]
        public static CmdScriptExpr<K,T> expr<K,T>(K id, T content)
            where K : unmanaged
                => new CmdScriptExpr<K,T>(id,content);
        [Op]
        public static ref CmdRuleInfo rules(IWfDb db, ref CmdRuleInfo data)
        {
            data.CmdRoot = db.ToolExeRoot() +  data.CmdRootName;
            data.CmdName = FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", data.CmdHost, data.CmdArgName), db.Log);
            data.CmdOutDir = db.Output(data.CmdHost);
            data.CmdOutPath = data.CmdOutDir + FS.file(data.CmdHost);
            data.ToolArgs = string.Format("{0}{0}", data.ArgPrefix, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.ToolArgs);
            return ref data;
        }

        [Op]
        public static ref CmdRuleInfo update(IWfDb db, ref CmdRuleInfo data,
            string root = null, string name = null, string arg = null, ArgPrefix? prefix = null, string type = null)
        {
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgPrefix = prefix != null ? prefix.Value: data.ArgPrefix;
            data.ScriptType = type == null ? data.ScriptType : FS.ext(type);
            rules(db, ref data);
            return ref data;
        }

        /// <summary>
        /// Creates a command process
        /// </summary>
        /// <param variable="commandLine">The command line to run as a subprocess</param>
        /// <param variable="options">Options for the process</param>
        [MethodImpl(Inline), Op]
        public static CmdProcess run(CmdLine command, CmdProcessOptions config)
            => new CmdProcess(command, config);

        [MethodImpl(Inline), Op]
        public static CmdProcess run(CmdLine command)
            => new CmdProcess(command, new CmdProcessOptions());

        [MethodImpl(Inline), Op]
        public static CmdProcess run(CmdLine command, TextWriter output)
            => new CmdProcess(command, new CmdProcessOptions(output));

        /// <summary>
        /// Creates an identifiable <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="id">The identifier to assign</param>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(string id, params CmdScriptExpr[] src)
            => new CmdScript(id, src);

        /// <summary>
        /// Allocates a <see cref='CmdScript'/> of specified length
        /// </summary>
        /// <param name="length">The script length</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(string id, int length)
            => new CmdScript(id, sys.alloc<CmdScriptExpr>(length));

        /// <summary>
        /// Creates an anonymous <see cref='CmdScript'/> from a <see cref='CmdScriptExpr'/> sequence
        /// </summary>
        /// <param name="src">The source expressions</param>
        [MethodImpl(Inline), Op]
        public static CmdScript script(params CmdScriptExpr[] src)
            => new CmdScript(src);

        [Op]
        public static ToolCmdSpec specify(FS.FilePath path, params ToolCmdArg[] args)
        {
            var dst = new ToolCmdSpec();
            dst.CmdPath = path;
            dst.Args = args;
            dst.Vars = NamedValues.empty<string>();
            dst.WorkingDir = FS.dir(Environment.CurrentDirectory);
            return dst;
        }

        [Op]
        public static ToolCmdSpec specify(FS.FilePath path, params CmdArg[] args)
        {
            var dst = new ToolCmdSpec();
            dst.CmdPath = path;
            dst.Args = args.Select(x => x.Format());
            dst.Vars = NamedValues.empty<string>();
            dst.WorkingDir = FS.dir(Environment.CurrentDirectory);
            return dst;
        }

        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline)]
        public static ToolId toolid<T>()
            => new ToolId(typeof(T).Name);

        [MethodImpl(Inline), Op]
        public static ToolId toolid(Type src)
            => new ToolId(src.Name);

        [MethodImpl(Inline), Op]
        public static ToolId toolid(string src)
            => new ToolId(src);

        /// <summary>
        /// Creates a <see cref='ToolSpec'/>
        /// </summary>
        /// <param name="tool">The tool identifier</param>
        /// <param name="verbs"></param>
        [MethodImpl(Inline), Op]
        public static ToolSpec define(ToolId tool, CmdFlagSpec[] flags, CmdOptionSpec[] options, ToolUsage syntax)
            => new ToolSpec(tool, flags, options, syntax);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolSpec define<T>(CmdFlagSpec[] flags, CmdOptionSpec[] options, ToolUsage syntax)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags, options, syntax);

        public static ToolInfo info<T>()
            where T : struct, ICmdToolModel<T>
                => describe(typeof(T));

        [MethodImpl(Inline), Op]
        public static ToolHelp toolhelp(ToolId tool, string src)
            => new ToolHelp(tool, src);

        [Op]
        static ref CmdOptionSpec extract(MemberInfo src, out CmdOptionSpec dst)
        {
            var tag = src.RequiredTag<SlotAttribute>();
            var purpose = src.Tag<MeaningAttribute>().MapValueOrElse(t => (string)t.Content, () => EmptyString);
            dst = ToolCmd.option(text.ifempty(tag.Name, src.Name), purpose);
            return ref dst;
        }

        /// <summary>
        /// Derives a <see cref='ToolInfo'/> from a specifying record
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static ToolInfo describe(Type src)
        {
            var dst = new ToolInfo();
            var tag = src.Tag<ToolAttribute>();
            dst.ToolId = toolid(src);
            if(!tag)
            {
                dst.ToolName = src.Name;
                dst.Syntax = EmptyString;
            }
            else
            {
                var attrib = tag.Value;
                dst.ToolName = attrib.ToolName;
                dst.Syntax = attrib.UsageSyntax;
            }

            var fields = @readonly(src.InstanceFields().Tagged<SlotAttribute>());
            var kFields = fields.Length;
            var buffer = alloc<CmdOptionSpec>(kFields);

            dst.Options = buffer;

            var options = span(buffer);
            for(ushort i=0; i<kFields; i++)
                extract(skip(fields,i), out seek(options,i));

            return dst;
        }
    }
}