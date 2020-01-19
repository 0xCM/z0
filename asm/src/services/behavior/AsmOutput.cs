//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
	using Iced.Intel;
    using System.IO;

    using static zfunc;

       class AsmOutput : FormatterOutput
        {
            TextWriter Writer {get;}
            
            ulong BaseAddress {get;}

            public AsmOutput(TextWriter writer, ulong BaseAddress)
            {
                this.Writer = writer;
                this.BaseAddress = BaseAddress;
            }
            
            public override void Write(string text, FormatterOutputTextKind kind)
            {
                switch(kind)
                {
                    case FormatterOutputTextKind.LabelAddress:
                        var x = text.EndsWith(AsciLower.h) ? text.Substring(0, text.Length - 1)  : text;
                        if(ulong.TryParse(x, System.Globalization.NumberStyles.HexNumber,null, out var address))
                        {
                            var ra = (address - BaseAddress).ToString("x4");
                            var label = $"{ra}h";
                            Writer.Write(label);
                        }
                        else
                        {
                            Writer.Write($"{text}{AsciSym.Question}");
                        }
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }
}