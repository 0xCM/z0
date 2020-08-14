//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection;
    using System.Reflection.PortableExecutable;


    using static Konst;
    using static z;

    partial class MetadataReader
    {
        
        public void Read(TableSpan<AssemblyFileHandle> src, Receiver<AssemblyFile> dst)
            => src.Iter(handle => dst(Reader.GetAssemblyFile(handle)));

        public void Read(TableSpan<FieldDefinitionHandle> src, Receiver<FieldDefinition> dst)
            => src.Iter(handle => dst(Reader.GetFieldDefinition(handle)));

        public void Read(TableSpan<CustomAttributeHandle> src, Receiver<CustomAttribute> dst)
            => src.Iter(handle => dst(Reader.GetCustomAttribute(handle)));

        public void Read(TableSpan<MethodDefinitionHandle> src, Receiver<MethodDefinition> dst)
            => src.Iter(handle => dst(Reader.GetMethodDefinition(handle)));

        public void Read(TableSpan<MethodImplementationHandle> src, Receiver<MethodImplementation> dst)
            => src.Iter(handle => dst(Reader.GetMethodImplementation(handle)));

        public void Read(MethodImplementationHandle src, MethodImplementation dst)
            => Reader.GetMethodImplementation(src);

        public void Read(TypeDefinitionHandle src, Receiver<TypeDefinition> dst)
            => dst(Reader.GetTypeDefinition(src));

        public void Read(TableSpan<TypeDefinitionHandle> src, Receiver<TypeDefinition> dst)
            => src.Iter(handle => dst(Reader.GetTypeDefinition(handle)));

        public MethodImplementation Read(MethodImplementationHandle src)
            => Reader.GetMethodImplementation(src);

        public MethodDefinition Read(MethodDefinitionHandle src)
            => Reader.GetMethodDefinition(src);

        public string Read(StringHandle src)
            => Reader.GetString(src);
        
        public MethodBodyBlock Read(MethodDefinition src)
            => Pe.GetMethodBody(src.RelativeVirtualAddress);        
    }
}