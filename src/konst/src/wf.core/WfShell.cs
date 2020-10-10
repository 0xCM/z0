//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public struct WfShell : IWfShell
    {
        [MethodImpl(Inline), Op]
        public static PartId[] parts(string[] args, PartId[] fallback)
            => ApiPartIdParser.parse(args,fallback);

        [Op]
        public static WfSettings settings(IShellContext context)
        {
            FilePath configPath()
            {
                var assname = Assembly.GetEntryAssembly().GetSimpleName();
                var filename = FileName.define(assname, FileExtensions.Json);
                var src = context.Paths.ConfigRoot + filename;
                return src;
            }

            var dst = z.dict<string,string>();
            JsonSettings.absorb(configPath(),dst);
            return new WfSettings(dst);
        }

        [Op]
        public static WfSettings settings(IShellPaths paths)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.define(assname, FileExtensions.Json);
            var src = paths.ConfigRoot + filename;
            var dst = z.dict<string,string>();
            JsonSettings.absorb(src,dst);
            return new WfSettings(dst);
        }

        [Op]
        public static IWfShell shell(WfInit init)
            => new WfShell(init);

        [Op]
        public static ApiPartSet modules(Assembly control, string[] args)
        {
            var parts = ApiPartIdParser.parse(args);
            if(parts.Length != 0)
               return new ApiPartSet(control, parts);
            else
                return new ApiPartSet(control);
        }

        [Op]
        public static ApiPartSet modules(Assembly control)
            => modules(control, Environment.GetCommandLineArgs());

        /// <summary>
        /// Reifies a <see cref='IShellContet'/> predicated on the entry <see cref='Assembly'/>, a <see cref='ApiPartSet'/> derived
        /// from the entry assembly location and zero or more arguments taken from the environment context
        /// </summary>
        [Op]
        public static IShellContext context()
        {
            var control = Assembly.GetEntryAssembly();
            var args = Environment.GetCommandLineArgs();
            return context(control, modules(control, args), args);
        }

        /// <summary>
        /// Reifies a <see cref='IShellContet'/> predicated on a controlling <see cref='Assembly'/>, a source <see cref='ApiPartSet'/> and
        /// zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="modules">The source module archive</param>
        /// <param name="args">The shell args</param>
        [MethodImpl(Inline), Op]
        public static IShellContext context(Assembly control, ApiPartSet modules, params string[] args)
            => new ShellContext(control, args, modules);

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        public static IWfShell shell(Assembly control, ApiPartSet modules, params string[] args)
            => shell(new WfInit(context(control, modules, args), modules));

        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        public static IWfShell shell(Assembly control, params string[] args)
            => shell(control, modules(control, args), args);

        public static IWfShell shell(params string[] args)
            => shell(Assembly.GetEntryAssembly(), args);

        public PartId Id {get;}

        public IShellContext Shell {get;}

        public IWfInit Init {get;}

        public ApiPartSet Modules {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public Assembly[] Components {get;}

        public string[] Args {get;}

        public IShellPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public SystemApiCatalog Api {get;}

        public string ShellName {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly Control {get;}

        public IPolyrand Random {get; private set;}

        public ApiContext ApiContext {get;}

        public WfHost Host {get; private set;}

        [MethodImpl(Inline)]
        public WfShell(WfInit config)
        {
            Init = config;
            Id = config.ControlId;
            Ct = correlate(Id);
            WfSink = WfLogs.events(config.Logs);
            Shell = insist(Init.Shell);
            Modules = Init.Modules;
            Api = Modules.Api;
            Parts = Api.Storage;
            Components = Api.Components;
            Paths = Shell.Paths;
            Args = Shell.Args;
            Control = Assembly.GetEntryAssembly();
            ShellName = Control.GetSimpleName();
            Paths = Paths;
            PartIdentities = Parts.Select(x => x.Id);
            Settings = JsonSettings.Load(Paths.AppConfigPath);
            Random = default;
            Broker = new WfBroker(WfSink, Ct);
            ApiContext = new ApiContext(new ApiContextState(Modules));
            Host = new WfHost(typeof(WfShell), typeof(WfShell), Launch);
        }

        static void Launch(IWfShell wf)
            => throw no<WfShell>();

        [MethodImpl(Inline)]
        public IWfShell WithSource(IPolyrand random)
        {
            Random = random;
            return this;
        }

        [MethodImpl(Inline)]
        public IWfShell WithHost(WfHost host)
        {
            Host = host;
            return this;
        }

        [MethodImpl(Inline)]
        public WfShell<S> WithState<S>(S src)
            => new WfShell<S>(this, src);

        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => ShellName;
   }
}