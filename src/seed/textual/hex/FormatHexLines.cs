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

    public readonly struct HexLineFormatter : IHexLineFormatter
    {
        public static IHexLineFormatter Service => default(HexLineFormatter);
            
        public string[] FormatHexLines(byte[] data, HexLineConfig lineConfig)
        {
            var labelConfig = HexFormatConfig.Define(zpad:true, specifier: true, uppercase: false, prespec:false);
            var dataConfig = HexFormatConfig.HexData;
            var lines = new List<string>();
            var line = string.Empty.Build();            

            for(ushort i=0; i< data.Length; i++)
            {                
                if(i % lineConfig.BytesPerLine == 0)
                {
                    if(i != 0)
                    {                                                
                        lines.Add(line.ToString());
                        line.Clear();
                    }

                    if(lineConfig.LineLabels)
                    {
                        line.Append(i.FormatHex(labelConfig));
                        line.Append(Chars.Space);
                    }
                }

                line.Append(data[i].FormatHex(dataConfig));
                line.Append(Chars.Space);
            }

            var last = line.ToString();
            if(!string.IsNullOrWhiteSpace(last))
                lines.Add(last);   

            return lines.ToArray();           
        }         
    }
}