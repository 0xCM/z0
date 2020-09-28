//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    public readonly struct Tags
    {
        public enum MetadataStreamKind : byte
        {
            Illegal,

            Compressed,

            Uncompressed,
        }


        public enum TypeOrMethodDefTag : byte
        {
            TypeDef = 0,

            MethodDef = 1,

            BitCount = 1
        }

        public enum TypeDefOrRefTag : byte
        {
            TypeDef = 0,

            TypeRef = 1,

            BitCount = 2
        }

        public enum TypeDefOrRefOrSpecTag : byte
        {
            TypeDef = 0,
            TypeRef = 1,
            TypeSpec = 2,

            BitCount = 2
        }

        public enum ResolutionScopeTag : byte
        {
            Module = 0,

            ModuleRef = 1,

            AssemblyRef = 2,

            TypeRef = 3,

            BitCount = 2
        }

        public enum MethodDefOrRefTag : byte
        {
            MethodDef = 0,

            MemberRef = 1,

            BitCount = 1
        }

        public enum MemberRefParentTag : byte
        {
            TypeDef = 0,

            TypeRef = 1,

            ModuleRef = 2,

            MethodDef = 3,

            TypeSpec = 4,

            BitCount = 3
        }

        public enum MemberForwardedTag : byte
        {
            Field = 0,

            MethodDef = 1,

            BitCount = 1
        }

        public enum ImplementationTag : byte
        {
            File = 0,

            AssemblyRef = 1,

            ExportedType = 2,

            BitCount = 2
        }

        public enum HasSemanticsTag : byte
        {
            Event = 0,

            Property = 1,

            BitCount = 1
        }

        public enum HasConstantTag : byte
        {
            Field = 0,

            Param = 1,

            Property = 2,

            BitCount = 2
        }

        public enum HasFieldMarshalTag : byte
        {
            Field = 0,

            Param = 1,

            BitCount = 1
        }

        public enum HasDeclSecurityTag : byte
        {
            TypeDef = 0,

            MethodDef = 1,

            Assembly = 2,

            BitCount = 2
        }

        public enum CustomAttributeTypeTag : byte
        {
            MethodDef = 2,

            MemberRef = 3,

            BitCount = 3
        }

        public enum HasCustomAttributeTag : byte
        {
            MethodDef = 0,

            Field = 1,

            TypeRef = 2,

            TypeDef = 3,

            Param = 4,

            InterfaceImpl = 5,

            MemberRef = 6,

            Module = 7,

            DeclSecurity = 8,

            Property = 9,

            Event = 10,

            StandAloneSig = 11,

            ModuleRef = 12,

            TypeSpec = 13,

            Assembly = 14,

            AssemblyRef = 15,

            File = 16,

            ExportedType = 17,

            ManifestResource = 18,

            GenericParam = 19,

            GenericParamConstraint = 20,

            MethodSpec = 21,

            BitCount = 5
        }

        public enum HasCustomDebugInformationTag : byte
        {
            MethodDef = 0,

            Field = 1,

            TypeRef = 2,

            TypeDef = 3,

            Param = 4,

            InterfaceImpl = 5,

            MemberRef = 6,

            Module = 7,

            DeclSecurity = 8,

            Property = 9,

            Event = 10,

            StandAloneSig = 11,

            ModuleRef = 12,

            TypeSpec = 13,

            Assembly = 14,

            AssemblyRef = 15,

            File = 16,

            ExportedType = 17,

            ManifestResource = 18,

            GenericParam = 19,

            GenericParamConstraint = 20,

            MethodSpec = 21,

            Document = 22,

            LocalScope = 23,

            LocalVariable = 24,

            LocalConstant = 25,

            ImportScope = 26,

            BitCount = 5
        }
    }
}