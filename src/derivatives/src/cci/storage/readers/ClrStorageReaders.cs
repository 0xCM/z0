//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using Derivatives.SRM;
    using static Part;

    static class ClrStorageX
    {
        public static void FastAppend(this StringBuilder sb, int val)
        {
            if ((val >= 0) && (val < 10))
            {
                sb.Append((char)('0' + val));
            }
            else
            {
                sb.Append(val);
            }
        }
    }
}