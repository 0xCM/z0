//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Root;
    using static CliRows;
    using static core;

    partial class CliReader
    {
        public ref AssemblyRefRow Row(AssemblyReferenceHandle handle, ref AssemblyRefRow dst)
        {
            var src = MD.GetAssemblyReference(handle);
            dst.Culture = src.Culture;
            dst.Flags = src.Flags;
            dst.Hash = src.HashValue;
            dst.Token = src.PublicKeyOrToken;
            dst.Version = src.Version;
            dst.Name = src.Name;
            return ref dst;
        }

        public ref TypeDefRow Row(TypeDefinitionHandle handle, ref TypeDefRow dst)
        {
            var src = MD.GetTypeDefinition(handle);
            dst.Name = src.Name;
            dst.Namespace = src.Namespace;
            dst.Attributes = src.Attributes;
            dst.Layout = src.GetLayout();
            return ref dst;
        }

        public uint Rows(ReadOnlySpan<MethodDefinitionHandle> src, Span<MethodDefRow> dst)
        {
            var count = (uint)min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                 Row(skip(src,i), ref seek(dst,i));
            return count;
        }

        [MethodImpl(Inline), Op]
        public ref MethodDefRow Row(MethodDefinitionHandle handle, ref MethodDefRow dst)
        {
            var src = MD.GetMethodDefinition(handle);
            dst.Attributes = src.Attributes;
            dst.ImplAttributes  = src.ImplAttributes;
            dst.Rva = src.RelativeVirtualAddress;
            dst.Name = src.Name;
            dst.Signature = src.Signature;
            var keys = Keys(src.GetParameters());
            var count = keys.Count;
            if(count != 0)
            {
                dst.FirstParam = keys.First;
                dst.ParamCount = (ushort)count;
            }

            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public ref CustomAttributeRow Row(CustomAttribute src, ref CustomAttributeRow dst)
        {
            dst.Parent = src.Parent;
            dst.Constructor = src.Constructor;
            dst.Value = src.Value;
            dst.ValueOffset = HeapOffset(src.Value);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public ref FieldDefRow Row(FieldDefinitionHandle handle, ref FieldDefRow dst)
        {
            var src = MD.GetFieldDefinition(handle);
            dst.Attributes = src.Attributes;
            dst.Name = src.Name;
            dst.Signature = src.Signature;
            dst.Offset = (uint)src.GetOffset();
            dst.Marshal = src.GetMarshallingDescriptor();
            return ref dst;
        }
    }
}