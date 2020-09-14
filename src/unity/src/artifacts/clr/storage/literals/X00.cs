//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial struct ClrStorage
    {
        public enum PEMagic : ushort
        {
            PEMagic32 = 0x010B,

            PEMagic64 = 0x020B,
        }

        [Flags]
        public enum PropertyFlags : ushort
        {
            SpecialNameImpl = 0x0200,

            RTSpecialNameReserved = 0x0400,

            HasDefaultReserved = 0x1000,

            //  Comes from signature...
            HasThis = 0x0001,

            ReturnValueIsByReference = 0x0002,
            //  Load flags

            GetterLoaded = 0x0004,

            SetterLoaded = 0x0008,
        }

        [Flags]
        public enum EventFlags : ushort
        {
            SpecialNameImpl = 0x0200,

            RTSpecialNameReserved = 0x0400,

            //  Load flags
            AdderLoaded = 0x0001,

            RemoverLoaded = 0x0002,

            FireLoaded = 0x0004,
        }

        [Flags]
        public enum DeclSecurityActionFlags : ushort
        {
            ActionNil = 0x0000,

            Request = 0x0001,

            Demand = 0x0002,

            Assert = 0x0003,

            Deny = 0x0004,

            PermitOnly = 0x0005,

            LinktimeCheck = 0x0006,

            InheritanceCheck = 0x0007,

            RequestMinimum = 0x0008,

            RequestOptional = 0x0009,

            RequestRefuse = 0x000A,

            PrejitGrant = 0x000B,

            PrejitDenied = 0x000C,

            NonCasDemand = 0x000D,

            NonCasLinkDemand = 0x000E,

            NonCasInheritance = 0x000F,

            MaximumValue = 0x000F,

            ActionMask = 0x001F,
        }

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