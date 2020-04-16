//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Formats the source data with optional line length/numbering
        /// </summary>
        /// <param name="data">The source data</param>
        /// <param name="fmt">The format options</param>
        public static IReadOnlyList<string> FormatHexLines(this ReadOnlySpan<byte> data, HexLineConfig? fmt = null)
        {
            var builder = string.Empty.Build();
            var configured = fmt ?? HexLineConfig.Default;  
            var lines = new List<string>();
            var line = string.Empty.Build();
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
                        builder.Append('h');
                        builder.Append(Chars.Space);

                        line.Append(i.FormatHex(true,false,false,true));
                        line.Append('h');
                        line.Append(Chars.Space);
                    }
                }

                builder.Append(data[i].FormatHex(true, true, false, true));
                builder.Append(Chars.Space);

                line.Append(data[i].FormatHex(true, true, false, true));
                line.Append(Chars.Space);
            }
            var last = line.ToString();
            if(!string.IsNullOrWhiteSpace(last))
                lines.Add(last);   

            builder.AppendLine();
            return lines;           
        } 

        /// <summary>
        /// Formats the source data with optional line length/numbering
        /// </summary>
        /// <param name="data">The source data</param>
        /// <param name="fmt">The format options</param>
        public static IReadOnlyList<string> FormatHexLines(this byte[] data, HexLineConfig? fmt = null)
            => data.ToReadOnlySpan().FormatHexLines(fmt);    
    }
}