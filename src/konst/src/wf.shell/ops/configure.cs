//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class WfShell
    {
        [Op]
        public static ref WfConfig configure(ref WfConfig dst)
        {
            var dbroot = Env.create().Db.Value;
            var paths = WfShell.paths(dbroot);
            var control = controller();
            var runroot = FS.path(control.CodeBase).FolderPath;
            dst.Controller = control.GetSimpleName();
            dst.DbRoot = dbroot;
            dst.ConfigPath = paths.AppConfigPath;
            dst.RuntimeRoot = runroot;
            dst.Components = parts(control, runroot).PartComponents.Select(ClrAssemblyNames.from);
            return ref dst;
        }
    }
}