//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.CodeAnalysis;
    using System.Reflection;

    [ApiHost]
    public readonly struct MetadataReferences
    {
        public static MetadataReference from(FS.FilePath src)
        {
            var xml = src.ChangeExtension(FS.Xml);
            var doc = xmldoc(xml);
            var props = default(MetadataReferenceProperties);
            return MetadataReference.CreateFromFile(src.Name, props, doc);
        }

        public static MetadataReference from(Assembly src)
        {
            var path = FS.path(src.Location);
            var xml = path.ChangeExtension(FS.Xml);
            var doc = xmldoc(xml);
            var props = default(MetadataReferenceProperties);
            return MetadataReference.CreateFromFile(path.Name, props, doc);
        }

        public static XmlDocProvider xmldoc(FS.FilePath src)
            => new XmlDocProvider(src.Name);
    }

}