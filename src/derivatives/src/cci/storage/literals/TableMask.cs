//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    partial struct ClrStorage
    {
        public enum TableMask : ulong
        {
            Module = 0x0000000000000001UL << 0x00,

            TypeRef = 0x0000000000000001UL << 0x01,

            TypeDef = 0x0000000000000001UL << 0x02,

            FieldPtr = 0x0000000000000001UL << 0x03,

            Field = 0x0000000000000001UL << 0x04,

            MethodPtr = 0x0000000000000001UL << 0x05,

            Method = 0x0000000000000001UL << 0x06,

            ParamPtr = 0x0000000000000001UL << 0x07,

            Param = 0x0000000000000001UL << 0x08,

            InterfaceImpl = 0x0000000000000001UL << 0x09,

            MemberRef = 0x0000000000000001UL << 0x0A,

            Constant = 0x0000000000000001UL << 0x0B,

            CustomAttribute = 0x0000000000000001UL << 0x0C,

            FieldMarshal = 0x0000000000000001UL << 0x0D,

            DeclSecurity = 0x0000000000000001UL << 0x0E,

            ClassLayout = 0x0000000000000001UL << 0x0F,

            FieldLayout = 0x0000000000000001UL << 0x10,

            StandAloneSig = 0x0000000000000001UL << 0x11,

            EventMap = 0x0000000000000001UL << 0x12,

            EventPtr = 0x0000000000000001UL << 0x13,

            Event = 0x0000000000000001UL << 0x14,

            PropertyMap = 0x0000000000000001UL << 0x15,

            PropertyPtr = 0x0000000000000001UL << 0x16,

            Property = 0x0000000000000001UL << 0x17,

            MethodSemantics = 0x0000000000000001UL << 0x18,

            MethodImpl = 0x0000000000000001UL << 0x19,

            ModuleRef = 0x0000000000000001UL << 0x1A,

            TypeSpec = 0x0000000000000001UL << 0x1B,

            ImplMap = 0x0000000000000001UL << 0x1C,

            FieldRva = 0x0000000000000001UL << 0x1D,

            EnCLog = 0x0000000000000001UL << 0x1E,

            EnCMap = 0x0000000000000001UL << 0x1F,

            Assembly = 0x0000000000000001UL << 0x20,

            AssemblyProcessor = 0x0000000000000001UL << 0x21,

            AssemblyOS = 0x0000000000000001UL << 0x22,

            AssemblyRef = 0x0000000000000001UL << 0x23,

            AssemblyRefProcessor = 0x0000000000000001UL << 0x24,

            AssemblyRefOS = 0x0000000000000001UL << 0x25,

            File = 0x0000000000000001UL << 0x26,

            ExportedType = 0x0000000000000001UL << 0x27,

            ManifestResource = 0x0000000000000001UL << 0x28,

            NestedClass = 0x0000000000000001UL << 0x29,

            GenericParam = 0x0000000000000001UL << 0x2A,

            MethodSpec = 0x0000000000000001UL << 0x2B,

            GenericParamConstraint = 0x0000000000000001UL << 0x2C,

            SortedTablesMask = TableMask.ClassLayout |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.DeclSecurity |
                TableMask.FieldLayout |
                TableMask.FieldMarshal |
                TableMask.FieldRva |
                TableMask.GenericParam |
                TableMask.GenericParamConstraint |
                TableMask.ImplMap |
                TableMask.InterfaceImpl |
                TableMask.MethodImpl |
                TableMask.MethodSemantics |
                TableMask.NestedClass,

            CompressedStreamNotAllowedMask = TableMask.FieldPtr |
                TableMask.MethodPtr |
                TableMask.ParamPtr |
                TableMask.EventPtr |
                TableMask.PropertyPtr |
                TableMask.EnCLog |
                TableMask.EnCMap,

            V1_0_TablesMask = TableMask.Module |
                TableMask.TypeRef |
                TableMask.TypeDef |
                TableMask.FieldPtr |
                TableMask.Field |
                TableMask.MethodPtr |
                TableMask.Method |
                TableMask.ParamPtr |
                TableMask.Param |
                TableMask.InterfaceImpl |
                TableMask.MemberRef |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.FieldMarshal |
                TableMask.DeclSecurity |
                TableMask.ClassLayout |
                TableMask.FieldLayout |
                TableMask.StandAloneSig |
                TableMask.EventMap |
                TableMask.EventPtr |
                TableMask.Event |
                TableMask.PropertyMap |
                TableMask.PropertyPtr |
                TableMask.Property |
                TableMask.MethodSemantics |
                TableMask.MethodImpl |
                TableMask.ModuleRef |
                TableMask.TypeSpec |
                TableMask.ImplMap |
                TableMask.FieldRva |
                TableMask.EnCLog |
                TableMask.EnCMap |
                TableMask.Assembly |
                TableMask.AssemblyRef |
                TableMask.File |
                TableMask.ExportedType |
                TableMask.ManifestResource |
                TableMask.NestedClass,
            V1_1_TablesMask = TableMask.Module |
                TableMask.TypeRef |
                TableMask.TypeDef |
                TableMask.FieldPtr |
                TableMask.Field |
                TableMask.MethodPtr |
                TableMask.Method |
                TableMask.ParamPtr |
                TableMask.Param |
                TableMask.InterfaceImpl |
                TableMask.MemberRef |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.FieldMarshal |
                TableMask.DeclSecurity |
                TableMask.ClassLayout |
                TableMask.FieldLayout |
                TableMask.StandAloneSig |
                TableMask.EventMap |
                TableMask.EventPtr |
                TableMask.Event |
                TableMask.PropertyMap |
                TableMask.PropertyPtr |
                TableMask.Property |
                TableMask.MethodSemantics |
                TableMask.MethodImpl |
                TableMask.ModuleRef |
                TableMask.TypeSpec |
                TableMask.ImplMap |
                TableMask.FieldRva |
                TableMask.EnCLog |
                TableMask.EnCMap |
                TableMask.Assembly |
                TableMask.AssemblyRef |
                TableMask.File |
                TableMask.ExportedType |
                TableMask.ManifestResource |
                TableMask.NestedClass,

            V2_0_TablesMask = TableMask.Module |
                TableMask.TypeRef |
                TableMask.TypeDef |
                TableMask.FieldPtr |
                TableMask.Field |
                TableMask.MethodPtr |
                TableMask.Method |
                TableMask.ParamPtr |
                TableMask.Param |
                TableMask.InterfaceImpl |
                TableMask.MemberRef |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.FieldMarshal |
                TableMask.DeclSecurity |
                TableMask.ClassLayout |
                TableMask.FieldLayout |
                TableMask.StandAloneSig |
                TableMask.EventMap |
                TableMask.EventPtr |
                TableMask.Event |
                TableMask.PropertyMap |
                TableMask.PropertyPtr |
                TableMask.Property |
                TableMask.MethodSemantics |
                TableMask.MethodImpl |
                TableMask.ModuleRef |
                TableMask.TypeSpec |
                TableMask.ImplMap |
                TableMask.FieldRva |
                TableMask.EnCLog |
                TableMask.EnCMap |
                TableMask.Assembly |
                TableMask.AssemblyRef |
                TableMask.File |
                TableMask.ExportedType |
                TableMask.ManifestResource |
                TableMask.NestedClass |
                TableMask.GenericParam |
                TableMask.MethodSpec |
                TableMask.GenericParamConstraint,
        }

    }
}