// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;

    using Z0.Dac;
    using Z0.MS;

    public sealed unsafe class MetadataImport : CallableCOMWrapper
    {
        private static readonly Guid IID_IMetaDataImport = new Guid("7DAC8207-D3AE-4c75-9B67-92801A497D44");

        private EnumInterfaceImplsDelegate _enumInterfaceImpls;

        private CloseEnumDelegate _closeEnum;

        private GetInterfaceImplPropsDelegate _getInterfaceImplProps;

        private GetTypeRefPropsDelegate _getTypeRefProps;

        private GetTypeDefPropsDelegate _getTypeDefProps;

        private EnumFieldsDelegate _enumFields;

        private GetRVADelegate _getRVA;

        private GetMethodPropsDelegate _getMethodProps;

        private GetNestedClassPropsDelegate _getNestedClassProps;

        private GetFieldPropsDelegate _getFieldProps;

        private GetCustomAttributeByNameDelegate _getCustomAttributeByName;

        private EnumGenericParamsDelegate _enumGenericParams;
        
        private GetGenericParamPropsDelegate _getGenericParamProps;

        public MetadataImport(DacLibrary library, IntPtr pUnknown)
            : base(null, IID_IMetaDataImport, pUnknown)
        {
        }

        private ref readonly IMetaDataImportVTable VTable => ref Unsafe.AsRef<IMetaDataImportVTable>(_vtable);

        public IEnumerable<int> EnumerateInterfaceImpls(int token)
        {
            InitDelegate(ref _enumInterfaceImpls, VTable.EnumInterfaceImpls);

            IntPtr handle = IntPtr.Zero;
            int[] tokens = ArrayPool<int>.Shared.Rent(32);
            try
            {
                int hr;
                while ((hr = _enumInterfaceImpls(Self, ref handle, token, tokens, tokens.Length, out int count)) >= S_OK && count > 0)
                    for (int i = 0; i < count; i++)
                        yield return tokens[i];
            }
            finally
            {
                if (handle != IntPtr.Zero)
                    CloseEnum(handle);

                ArrayPool<int>.Shared.Return(tokens);
            }
        }

        public MethodAttributes GetMethodAttributes(int token)
        {
            InitDelegate(ref _getMethodProps, VTable.GetMethodProps);

            int hr = _getMethodProps(Self, token, out int cls, null, 0, out int needed, out MethodAttributes result, out IntPtr sigBlob, out uint sigBlobLen, out uint codeRVA, out uint implFlags);
            return hr == S_OK ? result : default;
        }

        public uint GetRva(int token)
        {
            InitDelegate(ref _getRVA, VTable.GetRVA);

            int hr = _getRVA(Self, token, out uint rva, out uint flags);
            return hr == S_OK ? rva : 0;
        }

        public bool GetTypeDefProperties(int token, out string name, out TypeAttributes attributes, out int mdParent)
        {
            InitDelegate(ref _getTypeDefProps, VTable.GetTypeDefProps);

            name = null;
            int hr = _getTypeDefProps(Self, token, null, 0, out int needed, out attributes, out mdParent);
            if (hr < 0)
                return false;

            StringBuilder sb = new StringBuilder(needed + 1);
            hr = _getTypeDefProps(Self, token, sb, sb.Capacity, out needed, out attributes, out mdParent);

            if (hr != S_OK)
                return false;

            name = sb.ToString();
            return true;
        }

        public bool GetCustomAttributeByName(int token, string name, out IntPtr data, out uint cbData)
        {
            InitDelegate(ref _getCustomAttributeByName, VTable.GetCustomAttributeByName);

            int hr = _getCustomAttributeByName(Self, token, name, out data, out cbData);
            return hr == S_OK;
        }

        public bool GetFieldProps(int token, out string name, out FieldAttributes attrs, out IntPtr ppvSigBlob, out int pcbSigBlob, out int pdwCPlusTypeFlag, out IntPtr ppValue)
        {
            InitDelegate(ref _getFieldProps, VTable.GetFieldProps);

            name = null;
            int hr = _getFieldProps(
                Self,
                token,
                out int typeDef,
                null,
                0,
                out int needed,
                out attrs,
                out ppvSigBlob,
                out pcbSigBlob,
                out pdwCPlusTypeFlag,
                out ppValue,
                out int pcchValue);
            if (hr < 0)
                return false;

            StringBuilder sb = new StringBuilder(needed + 1);
            hr = _getFieldProps(Self, token, out typeDef, sb, sb.Capacity, out needed, out attrs, out ppvSigBlob, out pcbSigBlob, out pdwCPlusTypeFlag, out ppValue, out pcchValue);
            if (hr >= 0)
            {
                name = sb.ToString();
                return true;
            }

            return false;
        }

        public IEnumerable<int> EnumerateFields(int token)
        {
            InitDelegate(ref _enumFields, VTable.EnumFields);

            IntPtr handle = IntPtr.Zero;
            int[] tokens = ArrayPool<int>.Shared.Rent(32);
            try
            {
                int hr;
                while ((hr = _enumFields(Self, ref handle, token, tokens, tokens.Length, out int count)) >= 0 && count > 0)
                    for (int i = 0; i < count; i++)
                        yield return tokens[i];
            }
            finally
            {
                if (handle != IntPtr.Zero)
                    CloseEnum(handle);

                ArrayPool<int>.Shared.Return(tokens);
            }
        }

        internal bool GetTypeDefAttributes(int token, out TypeAttributes attrs)
        {
            InitDelegate(ref _getTypeDefProps, VTable.GetTypeDefProps);

            int hr = _getTypeDefProps(Self, token, null, 0, out int needed, out attrs, out int extends);
            return hr == S_OK;
        }

        public string GetTypeRefName(int token)
        {
            InitDelegate(ref _getTypeRefProps, VTable.GetTypeRefProps);

            int hr = _getTypeRefProps(Self, token, out int scope, null, 0, out int needed);
            if (hr < 0)
                return null;

            StringBuilder sb = new StringBuilder(needed + 1);
            hr = _getTypeRefProps(Self, token, out scope, sb, sb.Capacity, out needed);

            return hr == S_OK ? sb.ToString() : null;
        }

        public bool GetNestedClassProperties(int token, out int enclosing)
        {
            InitDelegate(ref _getNestedClassProps, VTable.GetNestedClassProps);
            int hr = _getNestedClassProps(Self, token, out enclosing);
            return hr == S_OK;
        }

        public bool GetInterfaceImplProps(int token, out int mdClass, out int mdInterface)
        {
            InitDelegate(ref _getInterfaceImplProps, VTable.GetInterfaceImplProps);

            int hr = _getInterfaceImplProps(Self, token, out mdClass, out mdInterface);
            return hr == S_OK;
        }

        private void CloseEnum(IntPtr handle)
        {
            if (handle != IntPtr.Zero)
            {
                InitDelegate(ref _closeEnum, VTable.CloseEnum);
                _closeEnum(Self, handle);
            }
        }

        public IEnumerable<int> EnumerateGenericParams(int token)
        {
            InitDelegate(ref _enumGenericParams, VTable.EnumGenericParams);

            IntPtr handle = IntPtr.Zero;
            int[] tokens = ArrayPool<int>.Shared.Rent(32);
            try
            {
                int hr;
                while ((hr = _enumGenericParams(Self, ref handle, token, tokens, tokens.Length, out int count)) >= 0 && count > 0)
                    for (int i = 0; i < count; i++)
                        yield return tokens[i];
            }
            finally
            {
                if (handle != IntPtr.Zero)
                    CloseEnum(handle);

                ArrayPool<int>.Shared.Return(tokens);
            }
        }

        public bool GetGenericParamProps(int token, out int index, out GenericParameterAttributes attributes, [NotNullWhen(true)] out string name)
        {
            name = null;
            InitDelegate(ref _getGenericParamProps, VTable.GetGenericParamProps);

            int hr = _getGenericParamProps(
                Self, token, out index, out attributes, out int owner, out _, null, 0, out int needed);

            if (hr < 0)
                return false;

            string nameResult = new string('\0', needed - 1);
            fixed (char* nameResultPtr = nameResult)
                hr = _getGenericParamProps(
                    Self, token, out index, out attributes, out owner, out _, nameResultPtr, nameResult.Length + 1, out needed);

            if (hr < 0)
                return false;

            name = nameResult;
            return true;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CloseEnumDelegate(IntPtr self, IntPtr e);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumInterfaceImplsDelegate(IntPtr self, ref IntPtr phEnum, int td, [Out] int[] rImpls, int cMax, out int pCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetInterfaceImplPropsDelegate(IntPtr self, int mdImpl, out int mdClass, out int mdIFace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetTypeRefPropsDelegate(
            IntPtr self,
            int token,
            out int resolutionScopeToken,
            [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder szName,
            int bufferSize,
            out int needed);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetTypeDefPropsDelegate(
            IntPtr self,
            int token,
            [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder szTypeDef,
            int cchTypeDef,
            out int pchTypeDef,
            out TypeAttributes pdwTypeDefFlags,
            out int ptkExtends);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumFieldsDelegate(IntPtr self, ref IntPtr phEnum, int cl, int[] mdFieldDef, int cMax, out int pcTokens);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetRVADelegate(IntPtr self, int token, out uint pRva, out uint flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetMethodPropsDelegate(
            IntPtr self,
            int md,
            out int pClass,
            StringBuilder szMethod,
            int cchMethod,
            out int pchMethod,
            out MethodAttributes pdwAttr,
            out IntPtr ppvSigBlob,
            out uint pcbSigBlob,
            out uint pulCodeRVA,
            out uint pdwImplFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetNestedClassPropsDelegate(IntPtr self, int tdNestedClass, out int tdEnclosingClass);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetFieldPropsDelegate(
            IntPtr self,
            int mb,
            out int mdTypeDef,
            [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder szField,
            int cchField,
            out int pchField,
            out FieldAttributes pdwAttr,
            out IntPtr ppvSigBlob,
            out int pcbSigBlob,
            out int pdwCPlusTypeFlab,
            out IntPtr ppValue,
            out int pcchValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetCustomAttributeByNameDelegate(IntPtr self, int tkObj, [MarshalAs(UnmanagedType.LPWStr)] string szName, out IntPtr ppData, out uint pcbData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumGenericParamsDelegate(
            IntPtr self,
            ref IntPtr phEnum,
            int tk,
            [Out] int[] rGenericParams,
            int cMax,
            out int pcGenericParams);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetGenericParamPropsDelegate(
            IntPtr self,
            int gp,
            out int pulParamSeq,
            out GenericParameterAttributes pdwParamFlags,
            out int ptOwner,
            out int reserved,
            char* wzname,
            int cchName,
            out int pchName);
    }   

}