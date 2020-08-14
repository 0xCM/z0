//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using System.Linq;

    using static Konst;
    using static z;

    partial class MetadataReader
    {
        ref TableSpan<AssemblyFileHandle> Fill(out TableSpan<AssemblyFileHandle> dst)
        {
            if(_AssemblyFileHandles.IsEmpty)
                _AssemblyFileHandles = Reader.AssemblyFiles.ToArray();            
            dst = _AssemblyFileHandles;            
            return ref dst;
        }

        ref TableSpan<ManifestResourceHandle> Fill(out TableSpan<ManifestResourceHandle> dst)
        {
            if(_ManifestResourceHandles.IsEmpty)
                _ManifestResourceHandles = Reader.ManifestResources.ToArray();            
            dst = _ManifestResourceHandles;            
            return ref dst;
        }

        ref TableSpan<FieldDefinitionHandle> Fill(out TableSpan<FieldDefinitionHandle> dst)
        {
            if(_FieldDefinitionHandles.IsEmpty)
                _FieldDefinitionHandles = Reader.FieldDefinitions.ToArray();            
            dst = _FieldDefinitionHandles;            
            return ref dst;
        }

        ref TableSpan<AssemblyReferenceHandle> Fill(out TableSpan<AssemblyReferenceHandle> dst)
        {
            if(_AssemblyReferenceHandles.IsEmpty)
                _AssemblyReferenceHandles = Reader.AssemblyReferences.ToArray();            
            dst = _AssemblyReferenceHandles;            
            return ref dst;
        }

        public TableSpan<CustomAttributeHandle> CustomAttributesHandle
            => Reader.CustomAttributes.ToArray();

        public TableSpan<AssemblyFileHandle> AssemblyFileHandles
            => Fill(out TableSpan<AssemblyFileHandle> _);

        public TableSpan<ManifestResourceHandle> ManifestResourceHandles
            => Fill(out TableSpan<ManifestResourceHandle> _);

        public TableSpan<FieldDefinitionHandle> FieldDefinitionHandles
            => Fill(out TableSpan<FieldDefinitionHandle> _);

        public TableSpan<AssemblyReferenceHandle> AssemblyReferenceHandles
            => Fill(out TableSpan<AssemblyReferenceHandle> _);
    }
}