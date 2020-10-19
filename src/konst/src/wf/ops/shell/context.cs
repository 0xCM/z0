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
            return context(control, parts, args);
        }

        [MethodImpl(Inline), Op]
        public static IWfContext context(Assembly control, IApiParts parts, string[] args, IWfPaths paths)
            => new WfContext(control, args, parts, paths);

        [MethodImpl(Inline), Op]
        public static IWfContext context(Assembly control, IApiParts parts, string[] args)
            => new WfContext(control, args, parts);
    }
}