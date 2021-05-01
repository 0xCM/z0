//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    partial struct Grids
    {
        [ParseFunction]
        public static bool Parse(string s, out GridDim dst)
        {
            var parts = @readonly(s.Split('x'));
            var parser = Numeric.parser<uint>();
            dst = default;
            if(parts.Length == 2)
            {
                if(parser.Parse(skip(parts,0), out var m) && parser.Parse(skip(parts,1), out var n))
                {
                    dst = new GridDim(m, n);
                    return true;
                }
            }
            return false;
        }
    }
}