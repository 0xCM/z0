//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static Root;
    using static As;

    using PK = PrimalKindId;    
    partial class XTend
    {
        public static string Format<E>(this E src)
            where E : unmanaged, Enum
                => $"{src}";
    }

    [ApiHost]
    public readonly struct FieldCapture
    {

        [MethodImpl(Inline)]
        static string format<T>(T src)
            where T : unmanaged
                => src.ToString();

        [MethodImpl(Inline)]
        static string hex<T>(T src)
            where T : unmanaged
                => HexFormat.scalar(src, false, false);

        [MethodImpl(Inline)]
        static unsafe string format(ReadOnlySpan<char> src)
        {
            if(src.Contains((char)0))
                return string.Empty;
                
            var dst = new string(gptr(first(src)));
            return dst;
        }
        
        public static void emit(FieldRef[] fields, FilePath path)
        {            
            const string Sep = "| ";

            var src = span(fields);            
            var dst = list<string>();
            
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var datatype = field.KindId;
                var declarer = field.Metadata.DeclaringType;                

                var data = field.Reference.Load();
                var content = datatype switch {
                    PK.String => format(span16c(field.Reference.Load())),
                    PK.C16 => format(data.AsChar()),
                    PK.I8 => hex(first(data.AsInt8())),
                    PK.U8 => hex(first(data)),
                    PK.I16 => hex(first(data.AsInt16())),
                    PK.U16 => hex(first(data.AsUInt16())),
                    PK.I32 => hex(first(data.AsInt32())),
                    PK.U32 => hex(first(data.AsUInt32())),
                    PK.I64 => hex(first(data.AsInt64())),
                    PK.U64 => hex(first(data.AsUInt64())),
                    PK.F32 => hex(first(data.AsFloat32())),
                    PK.F64 => hex(first(data.AsFloat64())),
                    PK.F128 => hex(first(data.AsFloat128())),
                    PK.U1 => format(first(data.AsBool())),
                    _ =>  data.FormatHex()
                };

                var dtName = declarer.IsEnum 
                    ? text.concat(declarer.Name, Chars.Colon, datatype.Format()) 
                    : datatype.Format();


                var line = text.concat(
                    field.Address.Format().PadRight(16), Sep, 
                    field.Width.Count.ToString().PadRight(16), Sep,
                    declarer.Name.PadRight(36), Sep, 
                    field.Metadata.Name.PadRight(36), Sep,
                    content.PadRight(48), Sep
                    );
                
                dst.Add(line);                
            }
        
            if(dst.Count != 0)
            {
                using var writer = path.Writer();
                var header = text.concat(
                        "Field Addresss".PadRight(16), Sep,
                        "Field Width".PadRight(16), Sep,
                        "Declaring Type".PadRight(36), Sep, 
                        "Field Name".PadRight(36), Sep, 
                        "Value".PadRight(48), Sep);
                writer.WriteLine(header);
                iter(dst,line => writer.WriteLine(line));
            }
        }
    }
}