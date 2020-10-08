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

    partial struct WfCore
    {
        public static IWfShell shell(WfInit init)
            => new WfShell(init);

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        public static IWfShell shell(Assembly control, ApiPartSet modules, params string[] args)
            => shell(new WfInit(context(control, modules, args), args, modules));

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        public static IWfShell shell(Assembly control, params string[] args)
            => shell(control, modules(control, args), args);

        public static IWfShell shell(params string[] args)
            => shell(Assembly.GetEntryAssembly(), args);
    }
}