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

    partial struct WfShell
    {
        [Op]
        public static IWfShell create(params string[] args)
            => create(Assembly.GetEntryAssembly(), args);

        [Op]
        public static IWfShell create(IWfPaths paths, params string[] args)
        {
            var control = Assembly.GetEntryAssembly();
            var parts = WfShell.parts(control, args);
            var ctx = context(control, parts, args,  paths);
            var init = new WfInit(ctx, parts);
            return create(init);
        }

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        [Op]
        static IWfShell create(Assembly control, ApiPartSet modules, params string[] args)
            => create(new WfInit(context(control, modules, args), modules));

        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        [Op]
        static IWfShell create(Assembly control, params string[] args)
            => create(control, parts(control, args), args);

        [Op]
        static IWfShell create(WfInit init)
            => new WfShell(init);
    }
}