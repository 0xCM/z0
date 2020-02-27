//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Root;

    public static class HexLineX
    {
        /// <summary>
        /// Formats the source data with optional line length/numbering
        /// </summary>
        /// <param name="data">The source data</param>
        /// <param name="fmt">The format options</param>
        public static IReadOnlyList<string> FormatHexLines(this ReadOnlySpan<byte> data, HexLineFormat? fmt = null)
        {
            var builder = factory<string>().Builder();
            var configured = fmt ?? HexLineFormat.Default;  
            var lines = new List<string>();
            var line = factory<string>().Builder();
            for(ushort i=0; i< data.Length; i++)
            {                
                if(i % configured.BytesPerLine == 0)
                {
                    if(i != 0)
                    {                        
                        builder.AppendLine();
                        
                        line.AppendLine();
                        lines.Add(line.ToString());
                        line.Clear();
                    }

                    if(configured.LineLabels)
                    {
                        builder.Append(i.FormatHex(true,false,false,true));
                        builder.Append(AsciLower.h);
                        builder.Append(AsciSym.Space);

                        line.Append(i.FormatHex(true,false,false,true));
                        line.Append(AsciLower.h);
                        line.Append(AsciSym.Space);
                    }
                }

                builder.Append(data[i].FormatHex(true, true, false, true));
                builder.Append(AsciSym.Space);

                line.Append(data[i].FormatHex(true, true, false, true));
                line.Append(AsciSym.Space);
            }
            var last = line.ToString();
            if(last.IsNotBlank())
                lines.Add(last);   

            builder.AppendLine();
            return lines;           
        } 

        public static IReadOnlyList<string> FormatHexLines(this byte[] data, HexLineFormat? fmt = null)
            => data.ToReadOnlySpan().FormatHexLines(fmt);


    }
}