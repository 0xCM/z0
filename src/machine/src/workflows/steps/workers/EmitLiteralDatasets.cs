//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static z;
    using static Konst;
    using static EmitFieldLiteralsStep;

    using PK = PrimalKindId;    
    
    public readonly ref struct EmitFieldLiterals
    {        
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        FolderPath Target 
            => Wf.ResourceRoot + FolderName.Define("fields");

        KnownParts Parts
            => KnownParts.Service;

        public EmitFieldLiterals(IWfContext context, CorrelationToken ct)
        {
            Ct = ct;
            Wf = context;
            Wf.Created(StepName, Ct);
        }

        void Emit(PartTypes src)
        {
            var fields = refs(src.Types);
            if(fields.Length != 0)
                Emit(fields, Target + FileName.Define(src.Part.Format(), FileExtensions.Csv));
        }
        
        public void Run()
        {
            Target.Clear();            
            var parts = span(Parts.Known.Map(part => PartTypes.from(part)));
            foreach(var part in parts)
            {
                try
                {
                    Emit(part);
                }
                catch(Exception e)
                {
                    term.error(e);
                }
            }
        }

        public void Dispose()
        {
            Wf.Finished(nameof(EmitFieldLiterals), Ct);
        }
        
        const string Sep = "| ";

        [Op]
        public static string[] strings(Type src)
        {
            var fields = Literals.stringlits(src);
            var @base = address(src);
            var count = fields.Length;
            var offset = MemoryAddress.Empty;  
            var buffer = sys.alloc<string>(count);  
            var dst = span(buffer);

            for(var j=0u; j<count; j++)
            {
                ref readonly var field = ref fields[j];
                var content = Literals.@string(field) ?? EmptyString;
                seek(dst,j) = content;
                if(!text.blank(content))
                    offset += from(@base, offset, field).DataSize;
            }
            return buffer;
        }

        [Op]
        unsafe static FieldRef from(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
        {
            var data = Literals.value(src);
            var type = src.FieldType;

            var datatype = Primitive.kind(type);
            if(data is string s)
            {                                
                var content = z.span(s);
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
        public static FieldRef[] refs(params Type[] src)
        {
            var dst = list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = src[i];
                var fields = Literals.search(type);
                var @base = address(type);
                var offset = MemoryAddress.Empty;
                for(var j=0u; j<fields.Length; j++)
                {
                    var field = fields[j];
                    var segment = from(@base, offset, field);
                    if(segment.IsNonEmpty)
                    {
                        z.append(dst,segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return dst.Array();
        }

        static string format(in FieldRef src)
        {       
            var datatype = src.KindId;
            var data = src.Field.GetRawConstantValue();            
            if(src.Field.FieldType.IsEnum)
                return data.ToString();

            return datatype switch {
                PK.String => cast<string>(data),
                PK.C16 => cast<char>(data).ToString(),
                PK.I8 => hex(cast<sbyte>(data)),
                PK.U8 => hex(cast<byte>(data)),
                PK.I16 => hex(cast<short>(data)),
                PK.U16 => hex(cast<ushort>(data)),
                PK.I32 => hex(cast<int>(data)),
                PK.U32 => hex(cast<uint>(data)),
                PK.I64 => hex(cast<long>(data)),
                PK.U64 => hex(cast<ulong>(data)),
                PK.F32 => hex(cast<float>(data)),
                PK.F64 => hex(cast<double>(data)),
                PK.F128 => hex(cast<decimal>(data)),
                PK.U1 => cast<bool>(data).ToString(),
                _ =>  $"{datatype} unrecognized"
            };
        }

        [MethodImpl(Inline)]
        static string hex<T>(T src)
            where T : unmanaged
                => Render.hex(src, false, false);        

        static string FormatHeader()
            => text.concat(
                "FieldAddress".PadRight(16), Sep,
                "FieldWidth".PadRight(16), Sep,
                "DeclaringType".PadRight(36), Sep, 
                "FieldName".PadRight(36), Sep, 
                "Value".PadRight(48), Sep
                );

        static string FormatLine(FieldRef src)
        {
            var content = format(src).PadRight(48);
            var address = src.Address.Format().PadRight(16);
            var width = src.Width.Count.ToString().PadRight(16);
            var type = src.Field.DeclaringType.Name.PadRight(36);
            var field = src.Field.Name.PadRight(36);
            var line = text.concat(address, Sep, width, Sep,type, Sep, field, Sep, content, Sep);
            return line;
        }

        void Emit(FieldRef[] src, FilePath dst)
        {            
            Wf.Running(nameof(EmitFieldLiterals), dst.Name, Ct);           
            var input = span(src);            
            var count = input.Length;

            using var writer = dst.Writer();            
            writer.WriteLine(FormatHeader());

            for(var i=0u; i<count; i++)
            { 
                ref readonly var field = ref skip(input,i);
                writer.WriteLine(FormatLine(field));
            }        

            Wf.Ran(nameof(EmitFieldLiterals), dst.Name, Ct);           
        }
    }
}