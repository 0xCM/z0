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

    partial struct Flow
    {
        public static IWfShell shell(WfConfig config, IWfEventSink sink)
            => new WfShell(config, sink);

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        public static IWfShell shell(Assembly control, params string[] args)
        {
            var id = control.Id();
            var modules = ApiQuery.modules(control, args);
            var context = Flow.context(control, modules, args);
            var config = new WfConfig(context, args, modules);
            return new WfShell(config, termlog(log(config), correlate(id)));
        }

        public static IWfShell shell(params string[] args)
            => shell(Assembly.GetEntryAssembly(), args);

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        public static IWfShell shell(Assembly control, ModuleArchive modules, params string[] args)
        {
            var id = control.Id();
            var context = Flow.context(control, modules, args);
            var config = new WfConfig(context, args, modules);
            return new WfShell(config, termlog(log(config), correlate(id)));
        }
    }
}