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
        /// <summary>
        /// Reifies a <see cref='IShellContet'/> predicated on the entry <see cref='Assembly'/>, a <see cref='ApiModules'/> derived
        /// from the entry assembly location and zero or more arguments taken from the environment context
        /// </summary>
        [Op]
        public static IShellContext context()
        {
            var control = Assembly.GetEntryAssembly();
            var args = Environment.GetCommandLineArgs();
            return context(control, Flow.modules(control, args), args);
        }

        /// <summary>
        /// Reifies a <see cref='IShellContet'/> predicated on a controlling <see cref='Assembly'/>, a source <see cref='ApiModules'/> and
        /// zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="modules">The source module archive</param>
        /// <param name="args">The shell args</param>
        [MethodImpl(Inline), Op]
        public static IShellContext context(Assembly control, ApiModules modules, params string[] args)
            => new ShellContext(control, args, modules);
    }
}