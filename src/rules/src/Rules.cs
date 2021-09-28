//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Rules
    {
        const Z0.NumericKind Closure = UnsignedInts;

         public static string FormatPattern(VarContextKind vck)
            => VarContextKinds.FormatPattern(vck);

        [Op]
        public static bool parse(string src, Bounded<int> bounds, out int dst, out Outcome outcome)
        {
            outcome = NumericParser.parse(src, out dst);
            if(!outcome)
                return false;

            if(!eval(bounds,dst))
            {
                outcome = (false, $"The parsed value {dst} is not with the required range {bounds}");
                return false;
            }
            return true;
        }
    }

    [ApiHost]
    public static partial class XRules
    {
    }
}