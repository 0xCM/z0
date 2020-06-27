//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static As;

    [ApiHost]
    public readonly struct LiteralFieldRefs
    {
        // [MethodImpl(Inline), Op]
        // public static unsafe MemoryAddress address(Type src)
        //     => src.TypeHandle.Value.ToPointer();

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(Type src)
        {

            // var tref = __makeref(src);
            // var pTref = TypedReference.TargetTypeToken(tref).Value.ToPointer();
            // return pTref;

            return src.TypeHandle.Value.ToPointer();
        }

        [Op]
        public static FieldRef[] search(params Type[] src)
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
                        offset += (uint)segment.Size;
                    }
                }
            }
            return dst.ToArray();
        }

        [Op]
        public static FieldRef[] strings(params Type[] types)
        {
            var dst = list<FieldRef>();
            for(var i=0; i<types.Length; i++)
            {
                var fields = LiteralFields.strings(types[i]);
                var @base = address(types[i]);
                MemoryAddress offset = 0;
                for(var j=0; j<fields.Length; j++)
                {
                    var segment = from(@base, offset, fields[j]);
                    if(segment.IsNonEmpty)
                    {
                        dst.Add(segment);
                        offset += (uint)segment.Size;
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
                var content = span(s);
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
            {
                var segment = memref(@base + offset, 2);
                return new FieldRef(src, segment);
            }
            else if(type.IsDecimal())
            {
                var segment = memref(@base + offset, 16);
                return new FieldRef(src, segment);                
            }
            return FieldRef.Empty;
        }
    }
}