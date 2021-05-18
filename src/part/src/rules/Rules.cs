//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using VCK = VarContextKind;

    [ApiHost]
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;

         public static string FormatPattern(VarContextKind vck)
            => vck switch
            {
                VCK.CmdScript => "%{0}%",
                VCK.PsScript => "${0}",
                VCK.BashScript => "${0}",
                VCK.MsBuild => "$({0})",
                _ => "{0}"
            };

        [Op]
        public static bool parse(string src, Bounded<int> bounds, out int dst, out Outcome outcome)
        {
            outcome = Numeric.parse(src, out dst);
            if(!outcome)
                return false;

            if(!satisfied(bounds,dst))
            {
                outcome = (false, $"The parsed value {dst} is not with the required range {bounds}");
                return false;
            }
            return true;
        }
    }
}