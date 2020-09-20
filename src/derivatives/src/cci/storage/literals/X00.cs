//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial struct ClrStorage
    {
        [Flags]
        public enum MethodImplFlags : ushort
        {
            ILCodeType = 0x0000,

            NativeCodeType = 0x0001,

            OPTILCodeType = 0x0002,

            RuntimeCodeType = 0x0003,

            CodeTypeMask = 0x0003,

            Unmanaged = 0x0004,

            NoInlining = 0x0008,

            ForwardRefInterop = 0x0010,

            Synchronized = 0x0020,

            NoOptimization = 0x0040,

            PreserveSigInterop = 0x0080,

            AggressiveInlining = 0x0100,

            InternalCall = 0x1000,
        }

        [Flags]
        public enum AssemblyFlags : uint
        {
            PublicKey = 0x00000001,

            Retargetable = 0x00000100,

            ContainsForeignTypes = 0x00000200
        }

        [Flags]
        public enum ManifestResourceFlags : uint
        {
            PublicVisibility = 0x00000001,
            PrivateVisibility = 0x00000002,
            VisibilityMask = 0x00000007,

            InExternalFile = 0x00000010,
        }

        public enum FileFlags : uint
        {
            ContainsMetadata = 0x00000000,

            ContainsNoMetadata = 0x00000001,
        }

        [Flags]
        public enum GenericParamFlags : ushort
        {
            NonVariant = 0x0000,

            Covariant = 0x0001,

            Contravariant = 0x0002,

            VarianceMask = 0x0003,

            ReferenceTypeConstraint = 0x0004,

            ValueTypeConstraint = 0x0008,

            DefaultConstructorConstraint = 0x0010,
        }
    }
}