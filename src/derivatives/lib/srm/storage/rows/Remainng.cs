//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    partial struct MetadataRows
    {
        //  0x1B
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeSpec
        {
            public uint Signature;
        }

        //  0x1E
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCLog
        {
            public uint Token;

            public uint FuncCode;

        }

        //  0x1F
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCMap
        {
            public uint Token;

        }

        //  0x26
        [StructLayout(LayoutKind.Sequential)]
        public struct FileRow
        {
            public FileFlags Flags;

            public uint Name;

            public uint HashValue;
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
        public struct GenericParam
        {
            public ushort Number;

            public GenericParamFlags Flags;

            public uint Owner;

            public uint Name;

        }


        //  0x2C
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamConstraint
        {
            public uint Owner;

            public uint Constraint;
        }
    }

}