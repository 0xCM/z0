//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Grids
    {
        [ParseFunction]
        public static bool Parse(string s, out GridDim dst)
        {
            var parts = s.Split('x');
            var parser = NumericParser.create<uint>();
            dst = default;
            var succeeded = false;
            if(parts.Length == 2)
            {
                var m = parser.Parse(parts[0]);
                var n = parser.Parse(parts[1]);
                succeeded = m.Succeeded && n.Succeeded;
                if(succeeded)
                    dst = new GridDim(m.Value, n.Value);
            }
            return succeeded;
        }
    }
}