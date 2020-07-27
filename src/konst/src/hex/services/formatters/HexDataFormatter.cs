//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct HexDataFormatter
    {            
        public readonly HexLineConfig LineConfig;

        public readonly HexFormatConfig LabelConfig;

        readonly HexFormatConfig DataConfig;

        [MethodImpl(Inline)]
        public HexDataFormatter(HexLineConfig config)
        {
            LineConfig = config;
            LabelConfig = HexFormat.configure(zpad:true, specifier: true, uppercase: false, prespec:false);
            DataConfig = HexFormatConfig.HexData;
        }

        public string FormatLine(ReadOnlySpan<byte> data, uint offset)
        {
            var line = string.Empty.Build();            
            var count = data.Length;

            if(LineConfig.LineLabels)
            {
                line.Append(offset.FormatHex(LabelConfig));
                line.Append(Chars.Space);
            }

            for(var i=0u; i<count; i++)
            {
                line.Append(skip(data, i).FormatHex(DataConfig));
                if(i != count - 1)
                    line.Append(Space);
            }


            return line.ToString();                  
        }         

        public ReadOnlySpan<string> FormatLines(ReadOnlySpan<byte> data)
        {
            var lines = list<string>();
            var line = string.Empty.Build();            
            var count = data.Length;

            for(ushort i=0; i<count; i++)
            {                
                if(i % LineConfig.BytesPerLine == 0)
                {
                    if(i != 0)
                    {                                                
                        lines.Add(line.ToString());
                        line.Clear();
                    }

                    if(LineConfig.LineLabels)
                    {
                        line.Append(i.FormatHex(LabelConfig));
                        line.Append(Chars.Space);
                    }
                }

                line.Append(data[i].FormatHex(DataConfig));
                line.Append(Chars.Space);
            }

            var last = line.ToString();
            if(!string.IsNullOrWhiteSpace(last))
                lines.Add(last);   

            return lines.ToArray();           
        }         
    }
}