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

    using R = System.Reflection;

    [ApiHost]
    public readonly struct ClrFields
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> adapt(R.FieldInfo[] src)
            => adapt<FieldInfo,ClrFieldAdapter>(src);

        [MethodImpl(Inline), Op]
        internal static ReadOnlySpan<V> adapt<S,V>(S[] src)
            => recover<S,V>(@readonly(src));

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> fields(Type src)
            => adapt(src.GetFields(BF));

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the declared instance fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> instance(Type src, bool declared = true)
            => adapt(src.GetFields(declared ? BF_DeclaredInstance : BF_All));

        /// <summary>
        /// Returns a <see cref='ClrFieldAdapter'/> readonly span of the fields defined by the source
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrFieldAdapter> all(Type src)
            => fields(src);

        [Op]
        public unsafe static FieldRef primal(MemoryAddress @base, MemoryAddress offset, FieldInfo src)
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
        public static FieldRef[] literals(ReadOnlySpan<Type> src)
        {
            var dst = list<FieldRef>();
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                var type = skip(src,i);
                var fields = ClrLiterals.search(type);
                var @base = address(type);
                var offset = MemoryAddress.Zero;
                for(var j=0u; j<fields.Length; j++)
                {
                    var fi = fields[j];
                    var segment = primal(@base, offset, fi);
                    if(segment.IsNonEmpty)
                    {
                        dst.Add(segment);
                        offset += segment.DataSize;
                    }
                }
            }
            return dst.Array();
        }
    }
}