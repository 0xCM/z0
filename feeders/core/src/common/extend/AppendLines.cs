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
    
    using static Components;

    partial class XTend
    {
        public static void AppendLines(this StringBuilder src, IEnumerable<string> lines)
            => Streams.iter(lines, line => src.AppendLine(line));            
    }
}