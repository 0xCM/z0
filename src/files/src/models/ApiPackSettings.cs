//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiPackSettings :  ISettingsSet<ApiPackSettings>
    {
        public Setting<FS.FolderPath> ExtractRoot;

        public Setting<bool> EmitContext;

        public Setting<bool> Analyze;

        public Setting<bool> EmitStatements;

        public static ApiPackSettings init(FS.FolderPath root, Timestamp? ts = null)
        {
            var dst = new ApiPackSettings();
            dst.Analyze = true;
            dst.EmitContext = true;
            dst.EmitStatements = true;
            dst.ExtractRoot = ts == null ? root : root + FS.folder(ts.Value.Format());
            return dst;
        }
    }
}