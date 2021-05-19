//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost]
    public partial class Cells
    {
        const NumericKind Closure = UnsignedInts;
    }

    partial class XTend
    {
        [Op]
        public static string FormatHexData(this Cell128 src, byte? count = null)
        {
            var c = count ?? 16;
            if(c <= 16)
            {
                var data = slice(bytes(src), 0, c);
                return HexFormat.format(data, HexFormatSpecs.HexData);
            }
            return "!!FormatError!!";
        }
    }
}