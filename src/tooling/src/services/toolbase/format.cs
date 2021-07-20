//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class ToolBase
    {
        [Op]
        public static string format(in ToolConfig src)
        {
            var formatter = Tables.formatter<ToolConfig>();
            return formatter.Format(src, RecordFormatKind.KeyValuePairs);
        }
    }
}