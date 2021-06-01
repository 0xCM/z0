//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;
    using static ReflectionFlags;

    [ApiHost]
    public readonly struct ClrFields
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the declared instance fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> instance(Type src, bool declared = true)
            => ClrModels.adapt(src.GetFields(declared ? BF_DeclaredInstance : BF_All));

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> all(Type src)
            => ClrModels.fields(src);

        [Op]
        public unsafe static FieldRef fieldref(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
        {
            var data = sys.constant(src);
            var type = src.FieldType;
            var datatype = ClrPrimitives.kind(type);
            if(data is string s)
            {
                var content = span(s);
                var size = s.Length*2;
                var seg = MemorySegs.define(pvoid(first(content)), size);
                return new FieldRef(src, seg);
            }
            else if(type.IsEnum)
            {
                var nk = type.GetEnumUnderlyingType().NumericKind();
                var size = nk.Width()/8;
                var seg = MemorySegs.define(@base + offset, size);
                return new FieldRef(src, seg);
            }
            else if(type.IsPrimalNumeric())
            {
                var nk = type.NumericKind();
                var size = nk.Width()/8;
                var seg = MemorySegs.define(@base + offset, size);
                return new FieldRef(src, seg);
            }
            else if(type.IsChar())
                return new FieldRef(src, MemorySegs.define(@base + offset, 2));
            else if(type.IsDecimal())
                return new FieldRef(src, MemorySegs.define(@base + offset, 16));
            return FieldRef.Empty;
        }

        [Op]
        public static FieldRef[] fieldrefs(Index<Type> src)
        {
            var dst = root.list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = src[i];
                var fields = ClrLiterals.search(type);
                var @base = memory.address(type);
                var offset = MemoryAddress.Zero;
                for(var j=0u; j<fields.Length; j++)
                {
                    var fi = fields[j];
                    var segment = fieldref(@base, offset, fi);
                    if(segment.IsNonEmpty)
                    {
                        root.append(dst, segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return dst.Array();
        }

        [Op]
        public static void strings(Type host, FieldInfo[] src, Span<string> dst)
        {
            var @base = memory.address(host);
            var count = src.Length;
            var offset = MemoryAddress.Zero;

            for(var j=0u; j<count; j++)
            {
                ref readonly var f = ref src[j];
                var content = ClrLiteralFields.@string(f) ?? EmptyString;
                seek(dst,j) = content;
                if(!text.blank(content))
                    offset += fieldref(@base, offset, f).DataSize;
            }
        }
    }
}