//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial class WfShell
    {
        [Op]
        public static ref WfConfig configure(ref WfConfig dst)
        {
            var paths = WfShell.paths(WfEnv.dbRoot());
            var control = controller();
            var runroot = FS.path(control.CodeBase).FolderPath;
            dst.Controller = control.GetSimpleName();
            dst.DbRoot = paths.DbRoot;
            dst.ConfigPath = paths.AppConfigPath;
            dst.RuntimeRoot = runroot;
            dst.Components = parts(control, runroot).Components.Select(ClrAssemblyNames.from);
            return ref dst;
        }

        [Op]
        public static WfConfig configure(string[] args)
        {
            var dst = new WfConfig();
            dst.Args = mapi(args, (i,arg) => new CmdArg((ushort)i, arg));
            configure(ref dst);
            return dst;
        }
    }
}