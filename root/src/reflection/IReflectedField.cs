//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;
    using System.Reflection;

    using static Root;

    public interface IReflectedField : IDataMember<FieldInfo>
    {
        bool IsSpecialName => Member.IsSpecialName;
  
        bool IsSecurityTransparent => Member.IsSecurityTransparent;
  
        bool IsSecuritySafeCritical => Member.IsSecuritySafeCritical;
  
        bool IsSecurityCritical => Member.IsSecurityCritical;
  
        bool IsPublic => Member.IsPublic;
  
        bool IsPrivate => Member.IsPrivate;
  
        bool IsPinvokeImpl => Member.IsPinvokeImpl;
  
        bool IsNotSerialized => Member.IsNotSerialized;
  
        bool IsLiteral => Member.IsLiteral;
  
        bool IsInitOnly => Member.IsInitOnly;
  
        bool IsFamilyOrAssembly => Member.IsFamilyOrAssembly;
  
        bool IsFamilyAndAssembly => Member.IsFamilyAndAssembly;
  
        bool IsFamily => Member.IsFamily;
  
        bool IsAssembly => Member.IsAssembly;
  
        Type FieldType => Member.FieldType;

        RuntimeFieldHandle FieldHandle => Member.FieldHandle;

        FieldAttributes Attributes => Member.Attributes;

        bool IsStatic => Member.IsStatic;

        Type[] GetOptionalCustomModifiers() => Member.GetOptionalCustomModifiers();

        object GetRawConstantValue() => Member.GetRawConstantValue();

        Type[] GetRequiredCustomModifiers() => Member.GetRequiredCustomModifiers();

        object GetValueDirect(TypedReference obj) => Member.GetValueDirect(obj);

        void SetValue(object obj, object value) => Member.SetValue(obj,value);

        void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
            => Member.SetValue(obj,value, invokeAttr,binder,culture);

        void SetValueDirect(TypedReference obj, object value) => Member.SetValueDirect(obj,value);

    }
}