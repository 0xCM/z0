//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct IMetaDataImportVTable
    {
        public readonly IntPtr CloseEnum;

        public readonly IntPtr CountEnum;

        public readonly IntPtr ResetEnum;

        public readonly IntPtr EnumTypeDefs;

        public readonly IntPtr EnumInterfaceImpls;

        public readonly IntPtr EnumTypeRefs;

        public readonly IntPtr FindTypeDefByName;

        public readonly IntPtr GetScopeProps;

        public readonly IntPtr GetModuleFromScope;

        public readonly IntPtr GetTypeDefProps;

        public readonly IntPtr GetInterfaceImplProps;

        public readonly IntPtr GetTypeRefProps;


        public readonly IntPtr ResolveTypeRef;

        public readonly IntPtr EnumMembers;

        public readonly IntPtr EnumMembersWithName;

        public readonly IntPtr EnumMethods;

        public readonly IntPtr EnumMethodsWithName;

        public readonly IntPtr EnumFields;

        public readonly IntPtr EnumFieldsWithName;

        public readonly IntPtr EnumParams;

        public readonly IntPtr EnumMemberRefs;

        public readonly IntPtr EnumMethodImpls;

        public readonly IntPtr EnumPermissionSets;

        public readonly IntPtr FindMember;

        public readonly IntPtr FindMethod;

        public readonly IntPtr FindField;

        public readonly IntPtr FindMemberRef;

        public readonly IntPtr GetMethodProps;

        public readonly IntPtr GetMemberRefProps;

        public readonly IntPtr EnumProperties;

        public readonly IntPtr EnumEvents;

        public readonly IntPtr GetEventProps;

        public readonly IntPtr EnumMethodSemantics;

        public readonly IntPtr GetMethodSemantics;

        public readonly IntPtr GetClassLayout;

        public readonly IntPtr GetFieldMarshal;

        public readonly IntPtr GetRVA;

        public readonly IntPtr GetPermissionSetProps;

        public readonly IntPtr GetSigFromToken;

        public readonly IntPtr GetModuleRefProps;

        public readonly IntPtr EnumModuleRefs;

        public readonly IntPtr GetTypeSpecFromToken;

        public readonly IntPtr GetNameFromToken;

        public readonly IntPtr EnumUnresolvedMethods;

        public readonly IntPtr GetUserString;

        public readonly IntPtr GetPinvokeMap;

        public readonly IntPtr EnumSignatures;

        public readonly IntPtr EnumTypeSpecs;

        public readonly IntPtr EnumUserStrings;

        public readonly IntPtr GetParamForMethodIndex;

        public readonly IntPtr EnumCustomAttributes;

        public readonly IntPtr GetCustomAttributeProps;

        public readonly IntPtr FindTypeRef;

        public readonly IntPtr GetMemberProps;

        public readonly IntPtr GetFieldProps;

        public readonly IntPtr GetPropertyProps;

        public readonly IntPtr GetParamProps;

        public readonly IntPtr GetCustomAttributeByName;

        public readonly IntPtr IsValidToken;

        public readonly IntPtr GetNestedClassProps;

        public readonly IntPtr GetNativeCallConvFromSig;

        public readonly IntPtr IsGlobal;

        // IMetaDataImport2
        public readonly IntPtr EnumGenericParams;

        public readonly IntPtr GetGenericParamProps;

        public readonly IntPtr GetMethodSpecProps;

        public readonly IntPtr EnumGenericParamConstraints;

        public readonly IntPtr GetGenericParamConstraintProps;

        public readonly IntPtr GetPEKind;

        public readonly IntPtr GetVersionString;

        public readonly IntPtr EnumMethodSpecs;
    }    
}