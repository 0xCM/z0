//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection;
    using System.Reflection.PortableExecutable;
    using Microsoft.CodeAnalysis;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Clr
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static CliToken token(Type src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(FieldInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(PropertyInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(MethodInfo src)
            => new CliToken(src);

        [MethodImpl(Inline), Op]
        public static CliToken token(ParameterInfo src)
            => new CliToken(src);

        public static MetadataReference metaref(FS.FilePath src)
        {
            var xml = src.ChangeExtension(FS.Xml);
            var doc = XmlDocProvider.create(xml);
            var props = default(MetadataReferenceProperties);
            return MetadataReference.CreateFromFile(src.Name, props, doc);
        }

        public static MetadataReference metaref(Assembly src)
        {
            var path = FS.path(src.Location);
            var xml = path.ChangeExtension(FS.Xml);
            var props = default(MetadataReferenceProperties);
            if(xml.Exists)
            {
                var doc = XmlDocProvider.create(xml);
                var reference = MetadataReference.CreateFromFile(path.Name, props, doc);
                return reference;
            }
            else
                return MetadataReference.CreateFromFile(path.Name, props);
        }

        public static Index<MetadataReference> metarefs(ReadOnlySpan<FS.FilePath> src)
        {
            var count = src.Length;
            var dst = alloc<MetadataReference>(count);
            for(var i=0; i<count; i++)
                seek(dst,i) = metaref(skip(src,i));
            return dst;
        }
    }
}