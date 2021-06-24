//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiExtractSettings :  ISettingsSet<ApiExtractSettings>
    {
        public Setting<FS.FolderPath> ExtractRoot;

        public Setting<bool> EmitContext;

        public Setting<bool> Analyze;

        public Setting<bool> EmitStatements;

        public Timestamp Timestamp;

        public static ApiExtractSettings init(FS.FolderPath root, Timestamp ts)
        {
            var dst = new ApiExtractSettings();
            dst.Timestamp = ts;
            dst.Analyze = true;
            dst.EmitContext = true;
            dst.EmitStatements = true;
            dst.ExtractRoot = ts == null ? root : root + FS.folder(dst.Timestamp.Format());
            return dst;
        }

        public static ApiExtractSettings init(FS.FolderPath root)
        {
            var dst = new ApiExtractSettings();
            dst.Timestamp = core.now();
            dst.Analyze = true;
            dst.EmitContext = true;
            dst.EmitStatements = true;
            dst.ExtractRoot =  root + FS.folder(dst.Timestamp.Format());
            return dst;
        }
    }
}