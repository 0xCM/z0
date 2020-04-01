//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;
    
    partial class XTend
    {
        public static void AppendLines(this StringBuilder dst, IEnumerable<string> src)
        {
            foreach(var line in src)
                dst.AppendLine(line);            
        }
    }
}