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
        /// Reifies a <see cref='IShellContet'/> predicated on the entry <see cref='Assembly'/>, a <see cref='ModuleArchive'/> derived
        /// from the entry assembly location and zero or more arguments taken from the environment context
        /// </summary>
        [Op]
        public static IShellContext context()
        {
            var control = Assembly.GetEntryAssembly();
            var args = Environment.GetCommandLineArgs();
            var modules = ApiQuery.modules(control, args);
            return context(control, modules, args);
        }

        /// <summary>
        /// Reifies a <see cref='IShellContet'/> predicated on a controlling <see cref='Assembly'/>, a source <see cref='ModuleArchive'/> and
        /// zero or more arguments
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="modules">The source module archive</param>
        /// <param name="args">The shell args</param>
        [MethodImpl(Inline), Op]
        public static IShellContext context(Assembly control, ModuleArchive modules, params string[] args)
            => new ShellContext(control, args, modules);
    }
}