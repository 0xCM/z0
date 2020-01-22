//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class NativeFormatX
    {
		public static string FormatHexLines(this AsmCode src, NativeFormatConfig? fmt = null)
		{
			var dst = text();
			dst.AppendLine($"; label   : {src.Label}");
			dst.AppendLine($"; location: {src.Origin.Format()}, length: {src.Origin.Length} bytes");
            dst.Append(src.Encoded.FormatHexLines(fmt));
			return dst.ToString();;
		}

        public static string FormatHexLines(this byte[] data, NativeFormatConfig? fmt = null)
        {
            var dst = text();
            var configured = fmt ?? NativeFormatConfig.Default;            
            for(ushort i=0; i< data.Length; i++)
            {
                if(i % configured.BytesPerLine == 0)
                {
                    if(i != 0)
                        dst.AppendLine();

                    if(configured.LineLabels)
                    {
                        dst.Append(i.FormatHex(true,false));
                        dst.Append(AsciLower.h);
                        dst.Append(AsciSym.Space);
                    }
                }
                dst.Append(data[i].FormatHex(true, true));
                dst.Append(AsciSym.Space);
            }
            dst.AppendLine();
            return dst.ToString();

        }

        public static string Format(this NativeMemberCapture data, NativeFormatConfig? fmt = null)
        {
            if(data.IsEmpty)
                return "<no_data>";
            
            var dst = text();
            var range = bracket(concat(data.StartAddress.FormatHex(false,true), AsciSym.Comma, data.EndAddress.FormatHex(false,true)));
            var bytes = data.Code.Encoded;
            dst.AppendLine($"; label   : {data.Method.Signature().Format()}");
            dst.AppendLine($"; location: {range}, length: {data.Length} bytes");
            dst.Append(bytes.FormatHexLines(fmt));
            dst.AppendLine(MethodSep);
            return dst.ToString();
        }         
 
        public static string Format(this PrimalKind k)
            => $"{k.BitWidth()}{k.Indicator()}";

        public static string FormatParam(this Pair<ParameterInfo,int> src)
        {
            var t = src.A.ParameterType;
            if(Classified.segmented(t))
            {
                var typewidth = (int)Classified.width(t);
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

            var dst = text();
            for(var i=0; i<pairs.Length; i++)
            {
                var pair = pairs[i];
                dst.Append(pairs[i].FormatParam());
                if(i != pairs.Length - 1)
                {
                    dst.Append(AsciSym.Comma);
                    dst.Append(AsciSym.Space);
                }
            }
            return parenthetical(dst.ToString());            
        }

        static string MethodSep => new string('_',80);
   }
}