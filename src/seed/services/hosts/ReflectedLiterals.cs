//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static Root;

    using NBI = NumericBaseIndicator;

    public readonly struct ReflectedLiterals
    {
        public static void emit(Type src, TAppPaths paths)
        {
            var literals = span(find(src));
            var formatter = NumericLiteralFormatter.Service;
            var appdata = paths.AppDataRoot;
            var dst = appdata + FileName.Define($"{src.Name}.Literals", FileExtensions.Csv);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.HeaderText);
            for(var i=0; i <literals.Length; i++)
            {
                ref readonly var literal = ref skip(literals,i);
                writer.WriteLine(formatter.Format(literal));                
            }            
        }

        public static NumericLiteral[] find(Type src)
        {
            var fields = span(src.LiteralFields());
            var dst = new List<NumericLiteral>();
            for(var i = 0; i<fields.Length; i++)
            {
                ref readonly var field = ref skip(fields,i);
                var tc = Type.GetTypeCode(field.FieldType);
                var vRaw = field.GetRawConstantValue();
                if(LiteralAttributes.HasMultiLiteral(field))
                    dst.AddRange(numeric(LiteralAttributes.MultiLiteral(field), vRaw));
                else if(LiteralAttributes.HasBinaryLiteral(field))
                    dst.Add(LiteralAttributes.BinaryLiteral(field,vRaw));
                else
                    dst.Add(NumericLiteral.Base2(field.Name, vRaw, BitFormatter.format(vRaw, tc)));
            }
            return dst.ToArray();            
        }

        public static NumericLiteral[] numeric(LiteralInfo src, object value)
        {
            if(src.MultiLiteral)
            {
                var content = text.unbracket(src.Text);
                if(!text.empty(content))
                {
                    var components = content.SplitClean(Chars.Pipe);
                    var count = components.Length;
                    var dst = sys.alloc<NumericLiteral>(count);
                    for(var i=0; i<components.Length; i++)
                    {
                        var component = components[i];
                        var length = component.Length;
                        if(length > 0)
                        {
                            var indicator = NumericBases.indicator(component[0]);

                            if(indicator != 0)
                                dst[i] = NumericLiteral.Define(src.Name, value, component.Substring(1), NumericBases.kind(indicator));
                            else
                            {
                                indicator = NumericBases.indicator(component[length - 1]);
                                indicator = indicator != 0 ? indicator : NBI.Base2;
                                dst[i] = NumericLiteral.Define(
                                    src.Name,
                                    value,
                                    component.Substring(0, length - 1),
                                    NumericBases.kind(indicator)                                    
                                    );
                            }                            
                        }
                        else
                            dst[i] = NumericLiteral.Empty;
                    }
                }
            }   
            return Array.Empty<NumericLiteral>();
        }        
    }
}