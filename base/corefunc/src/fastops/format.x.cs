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
            if(Classified.segmented(t))
            {
                var typewidth = Classified.width(t);
                var segkind = Classified.segtype(t).Require().Kind();
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

        static string MethodSep => new string('_',80);

        public static string Format<T>(this T data, int linebytes = 8, bool linelabels = true)
            where T : INativeMemberData
        {
            if(data.IsEmpty)
                return "<no_data>";

            var format = text();
            var range = bracket(concat(data.StartAddress.FormatHex(false,true), AsciSym.Comma, data.EndAddress.FormatHex(false,true)));
            format.AppendLine($"; function: {data.Method.Signature().Format()}");
            format.AppendLine($"; location: {range}, code length: {data.Length} bytes");

            for(ushort i=0; i< data.Length; i++)
            {
                if(i % linebytes == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    if(linelabels)
                    {
                        format.Append(i.FormatHex(true,false));
                        format.Append(AsciLower.h);
                        format.Append(AsciSym.Space);
                    }
                }
                format.Append(data.Code[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.AppendLine(MethodSep);
            return format.ToString();
        }         
    }
}