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
        public Setting<bool> EmitContext;

        public Setting<bool> Analyze;

        public Setting<bool> EmitStatements;

        public static ApiExtractSettings Default()
        {
            var dst = new ApiExtractSettings();
            dst.Analyze = true;
            dst.EmitContext = true;
            dst.EmitStatements = true;
            return dst;
        }
    }
}