//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static Root;
    using static As;

    using PK = PrimalKindId;    

    [ApiHost]
    public readonly struct LiteralFields
    {       
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(Type src)
            => sys.handle(src).ToPointer();

        [Op]
        public static FieldRef[] refs(params Type[] src)
        {
            var dst = list<FieldRef>();
            for(var i=0; i<src.Length; i++)
            {
                var type = src[i];
                var fields = LiteralFields.search(type);
                var @base = address(type);
                MemoryAddress offset = 0;
                for(var j=0; j<fields.Length; j++)
                {
                    var segment = from(@base, offset, fields[j]);                    
                    if(segment.IsNonEmpty)
                    {
                        dst.Add(segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return dst.ToArray();
        }

        [Op]
        unsafe static FieldRef from(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
        {
            var data = LiteralFieldValues.value(src);
            var type = src.FieldType;

            var datatype = type.PrimalKind();
            if(data is string s)
            {                                
                var content = As.span(s);
                var size = s.Length*2;
                var segment = memref(pvoid(first(content)), size);
                return new FieldRef(src, segment);
            }
            else if(type.IsEnum)
            {
                var nk = type.GetEnumUnderlyingType().NumericKind();
                var size = nk.Width()/8;
                var segment = memref(@base + offset, size);
                return new FieldRef(src, segment);
            }
            else if(type.IsPrimalNumeric())
            {
                var nk = type.NumericKind();
                var size = nk.Width()/8;
                var segment = memref(@base + offset, size);
                return new FieldRef(src, segment);
            }
            else if(type.IsChar())
                return new FieldRef(src, memref(@base + offset, 2));
            else if(type.IsDecimal())
                return new FieldRef(src, memref(@base + offset, 16));                
            return FieldRef.Empty;
        }

        [Op]
        public static FieldRef[] stringrefs(params Type[] types)
        {
            var dst = sys.list<FieldRef>();
            for(var i=0; i<types.Length; i++)
            {
                var fields = strings(types[i]);
                var @base = address(types[i]);
                MemoryAddress offset = 0;
                for(var j=0; j<fields.Length; j++)
                {
                    var segment = from(@base, offset, fields[j]);
                    if(segment.IsNonEmpty)
                    {
                        dst.Add(segment);
                        offset += segment.DataSize;
                    }

                }
            }
            return sys.array(dst);
        }

        [Op]
        public static string format(in FieldRef src)
        {       
            var datatype = src.KindId;
            var data = src.Reference.Load();
            return datatype switch {
                PK.String => sys.@string(span16c(src.Reference.Load())),
                PK.C16 => sys.@string(data.AsChar()),
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
                PK.U1 => first(data.AsBool()).ToString(),
                _ =>  data.FormatHex()
            };
        }

        [Op]
        public static FieldInfo[] strings(Type src)
            => search(src).Where(f => f.IsLiteral && f.FieldType == typeof(string));        
        
        [Op]
        public static FieldInfo[] search(Type src)
            => src.LiteralFields();
        
        [Op]
        public static FieldInfo[] search(Type src, Type match)
            => search(src);

        [Op, Closures(AllNumeric)]
        public static FieldInfo[] search<T>(Type match)
            => search(match).Where(f => f.IsLiteral && f.FieldType == typeof(T));

        [MethodImpl(Inline)]
        static string hex<T>(T src)
            where T : unmanaged
                => HexFormat.scalar(src, false, false);

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
                var content = LiteralFields.format(field);

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