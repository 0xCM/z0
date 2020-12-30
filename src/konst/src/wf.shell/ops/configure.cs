//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class WfShell
    {
        [Op]
        public static ref WfConfig configure(string[] args, ref WfConfig dst)
        {
            IWfAppPaths paths = new WfPaths(WfEnv.dbRoot());
            var control = controller();
            var runroot = FS.path(control.CodeBase).FolderPath;
            dst.Controller = control.GetSimpleName();
            dst.DbRoot = paths.DbRoot;
            dst.Args = mapi(args, (i,arg) => new CmdArg((ushort)i, arg));
            dst.ConfigPath = paths.AppConfigPath;
            dst.RuntimeRoot = runroot;
            dst.Components = parts(runroot).Components.Select(x => new Name(x.GetSimpleName()));
            return ref dst;
        }

        [Op]
        public static WfConfig configure(string[] args)
        {
            var dst = new WfConfig();
            configure(args, ref dst);
            return dst;
        }
    }
}