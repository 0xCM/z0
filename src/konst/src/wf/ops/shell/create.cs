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

    partial class WfShell
    {
        /// <summary>
        /// Creates a <see cref='IWfContext'/> predicated on the entry <see cref='Assembly'/>, a <see cref='ApiPartSet'/> derived
        /// from the entry assembly location and zero or more arguments taken from the environment context
        /// </summary>
        [Op]
        public static IWfContext context()
        {
            var control = WfShell.control();
            var args = WfShell.args();
            var parts = WfShell.parts(control, args);
            return new WfContext();
        }

        [Op]
        public static IWfShell create(params string[] args)
            => create(Assembly.GetEntryAssembly(), args);

        /// <summary>
        /// Reifies a <see cref='IWfShell'/> predicated on a controlling assembly and zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="args">The shell args</param>
        [Op]
        static IWfShell create(Assembly control, ApiPartSet modules, params string[] args)
            => create(new WfInit(context(), modules));

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