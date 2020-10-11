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
        /// <summary>
        /// Creates a <see cref='IShellContext'/> predicated on the entry <see cref='Assembly'/>, a <see cref='ApiPartSet'/> derived
        /// from the entry assembly location and zero or more arguments taken from the environment context
        /// </summary>
        [Op]
        public static IShellContext context()
        {
            var control = Assembly.GetEntryAssembly();
            var args = Environment.GetCommandLineArgs();
            return context(control, parts(control, args), args);
        }

        [MethodImpl(Inline), Op]
        static IShellContext context(Assembly control, ApiPartSet modules, params string[] args)
            => new ShellContext(control, args, modules);
    }
}