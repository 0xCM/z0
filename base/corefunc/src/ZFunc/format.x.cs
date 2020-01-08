//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class OpFormatX
    {
        public static string Format(this PrimalKind k)
            => $"{k.BitWidth()}{k.Indicator()}";

        public static string FormatParam(this Pair<ParameterInfo,int> src)
        {
            var t = src.A.ParameterType;
            if(ZFunc.segmented(t))
            {
                var typewidth = ZFunc.bitwidth(t);
                var segkind = ZFunc.segtype(t).Require().Kind();
                var segwidth = segkind.BitWidth();
                var indicator = segkind.Indicator();
                return $"{typewidth}x{segwidth}{indicator}".PadLeft(7);
            }
            else
                return $"{src.B}{t.Kind().Indicator()}";
        }

        public static string FormatParams(this IEnumerable<Pair<ParameterInfo,int>> src)
        {
            var pairs = src.ToArray();
            if(pairs.Length == 1)
                return pairs[0].FormatParam();

            var fmt = text();
            for(var i=0; i<pairs.Length; i++)
            {
                var pair = pairs[i];
                fmt.Append(pairs[i].FormatParam());
                if(i != pairs.Length - 1)
                {
                    fmt.Append(AsciSym.Comma);
                    fmt.Append(AsciSym.Space);
                }
            }
            return parenthetical(fmt.ToString());            
        }
    }

}