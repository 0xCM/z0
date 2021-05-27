//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct ApiExtractSettings : IRecord<ApiExtractSettings>
    {
        public const string TableId = "settings.apiextract";

        public Setting<bool> EmitContext;

        public Setting<bool> Analyze;

        public Setting<bool> EmitStatements;

        public static ApiExtractSettings Default()
        {
            var dst = new ApiExtractSettings();
            dst.Analyze = false;
            dst.EmitContext = false;
            dst.EmitStatements = true;
            return dst;
        }
    }
}