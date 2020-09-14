//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct ClrStorage
    {
        //  0x17
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow
        {
            public PropertyFlags Flags;

            public uint Name;

            public uint Signature;
        }

        //  0x18
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodSemanticsRow
        {
            public MethodSemanticsFlags SemanticsFlag;

            public uint Method;

            public uint Association;

        }

        //  0x19
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodImplRow
        {
            public uint Class;

            public uint MethodBody;

            public uint MethodDeclaration;
        }

        //  0x1A
        [StructLayout(LayoutKind.Sequential)]
        public struct ModuleRefRow
        {
            public uint Name;
        }

        //  0x1B
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeSpecRow
        {
            public uint Signature;
        }

        //  0x1C
        [StructLayout(LayoutKind.Sequential)]
        public struct ImplMapRow
        {
            public PInvokeMapFlags PInvokeMapFlags;

            public uint MemberForwarded;

            public uint ImportName;

            public uint ImportScope;
        }

        //  0x1D
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldRVARow
        {
            public Address32 RVA;

            public uint Field;

        }

        //  0x1E
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCLogRow
        {
            public uint Token;

            public uint FuncCode;

        }

        //  0x1F
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCMapRow
        {
            public uint Token;

        }

        //  0x20
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRow
        {
            public uint HashAlgId;

            public ushort MajorVersion;

            public ushort MinorVersion;

            public ushort BuildNumber;

            public ushort RevisionNumber;

            public AssemblyFlags Flags;

            public uint PublicKey;


            public uint Name;


            public uint Culture;
        }

        //  0x21
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyProcessorRow
        {
            public uint Processor;
        }

        //  0x22
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOSRow
        {
            public uint OSPlatformId;

            public uint OSMajorVersionId;

            public uint OSMinorVersionId;

        }

        //  0x23
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefRow
        {
            public ushort MajorVersion;

            public ushort MinorVersion;

            public ushort BuildNumber;

            public ushort RevisionNumber;

            public AssemblyFlags Flags;

            public uint PublicKeyOrToken;

            public uint Name;

            public uint Culture;

            public uint HashValue;
        }

        //  0x24
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefProcessorRow
        {
            public uint Processor;
            public uint AssemblyRef;

        }

        //  0x25
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefOSRow
        {
            public uint OSPlatformId;
            public uint OSMajorVersionId;
            public uint OSMinorVersionId;
            public uint AssemblyRef;
        }

        //  0x26
        [StructLayout(LayoutKind.Sequential)]
        public struct FileRow
        {
            public FileFlags Flags;

            public uint Name;

            public uint HashValue;
        }

        //  0x27
        [StructLayout(LayoutKind.Sequential)]
        public struct ExportedTypeRow
        {
            public TypeDefFlags Flags;

            public uint TypeDefId;

            public uint TypeName;

            public uint TypeNamespace;

            public uint Implementation;

            public bool IsNested
            {
                get
                {
                    return (this.Flags & TypeDefFlags.NestedMask) != 0;
                }
            }
        }

        //  0x28
        [StructLayout(LayoutKind.Sequential)]
        public struct ManifestResourceRow
        {
            public uint Offset;

            public ManifestResourceFlags Flags;

            public uint Name;

            public uint Implementation;
        }

        //  0x29
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow
        {
            public uint NestedClass;

            public uint EnclosingClass;
        }

        //  0x2A
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamRow
        {
            public ushort Number;

            public GenericParamFlags Flags;

            public uint Owner;

            public uint Name;

        }

        //  0x2B
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodSpecRow
        {
            public uint Method;

            public uint Instantiation;
        }

        //  0x2C
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamConstraintRow
        {
            public uint Owner;

            public uint Constraint;
        }
    }

}