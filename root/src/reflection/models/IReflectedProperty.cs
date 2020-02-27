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

    public interface IReflectedProperty : IDataMember<PropertyInfo>
    {
        bool IsSpecialName => Member.IsSpecialName;

        MethodInfo GetMethod => Member.GetMethod;

        bool CanWrite => Member.CanWrite;

        bool CanRead => Member.CanRead;

        PropertyAttributes Attributes => Member.Attributes;

        Type PropertyType => Member.PropertyType;

        MethodInfo SetMethod => Member.SetMethod;

        MethodInfo[] GetAccessors() => Member.GetAccessors();

        MethodInfo[] GetAccessors(bool nonPublic) => Member.GetAccessors(nonPublic);

        MethodInfo GetGetMethod() => Member.GetGetMethod();

        MethodInfo GetGetMethod(bool nonPublic) => Member.GetGetMethod(nonPublic);

        ParameterInfo[] GetIndexParameters() => Member.GetIndexParameters();

        Type[] GetOptionalCustomModifiers() => Member.GetOptionalCustomModifiers();

        object GetRawConstantValue() => Member.GetRawConstantValue();

        Type[] GetRequiredCustomModifiers() => Member.GetRequiredCustomModifiers();

        MethodInfo GetSetMethod() => Member.GetSetMethod();

        MethodInfo GetSetMethod(bool nonPublic) => Member.GetSetMethod(nonPublic);

        object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) 
            => Member.GetValue(obj,invokeAttr,binder,index,culture);

        object GetValue(object obj, object[] index) => Member.GetValue(obj,index);

        void SetValue(object obj, object value, object[] index) => Member.SetValue(obj,value,index);

        void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
            => Member.SetValue(obj, value, invokeAttr,binder,index,culture);

        void SetValue(object obj, object value) => Member.SetValue(obj,value);        
    }    

}