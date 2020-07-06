//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using static Konst;
    
    using R = System.Reflection;
    using S = System;
    using G = System.Globalization;

    partial struct Specialized
    {
        public sealed class Type : S.Type
        {
            readonly S.Type Source;

            [MethodImpl(Inline)]
            public Type(S.Type src)
            {
                Source = src;
            }

            public override R.Assembly Assembly 
                => Source.Assembly;

            public override string AssemblyQualifiedName 
                => Source.AssemblyQualifiedName;

            public override S.Type BaseType 
                => Source.BaseType;

            public override string FullName 
                => Source.FullName;

            public override S.Guid GUID 
                => Source.GUID;

            public override R.Module Module 
                => Source.Module;

            public override string Namespace 
                => Source.Namespace;

            public override S.Type UnderlyingSystemType 
                => Source.UnderlyingSystemType;

            public override string Name 
                => Source.Name;

            public override IEnumerable<R.CustomAttributeData> CustomAttributes 
                => Source.CustomAttributes;

            public override bool IsCollectible 
                => Source.IsCollectible;

            public override int MetadataToken 
                => Source.MetadataToken;

            public override bool ContainsGenericParameters 
                => Source.ContainsGenericParameters;

            public override R.MethodBase DeclaringMethod 
                => Source.DeclaringMethod;

            public override S.Type DeclaringType 
                => Source.DeclaringType;

            public override R.GenericParameterAttributes GenericParameterAttributes 
                => Source.GenericParameterAttributes;

            public override int GenericParameterPosition 
                => Source.GenericParameterPosition;

            public override S.Type[] GenericTypeArguments 
                => Source.GenericTypeArguments;

            public override bool IsByRefLike 
                => Source.IsByRefLike;

            public override bool IsConstructedGenericType 
                => Source.IsConstructedGenericType;

            public override bool IsEnum 
                => Source.IsEnum;

            public override bool IsGenericMethodParameter 
                => Source.IsGenericMethodParameter;

            public override bool IsGenericParameter 
                => Source.IsGenericParameter;

            public override bool IsGenericType 
                => Source.IsGenericType;

            public override bool IsGenericTypeDefinition 
                => Source.IsGenericTypeDefinition;

            public override bool IsGenericTypeParameter 
                => Source.IsGenericTypeParameter;

            public override bool IsSecurityCritical 
                => Source.IsSecurityCritical;

            public override bool IsSecuritySafeCritical 
                => Source.IsSecuritySafeCritical;

            public override bool IsSecurityTransparent 
                => Source.IsSecurityTransparent;

            public override bool IsSerializable 
                => Source.IsSerializable;

            public override bool IsSignatureType 
                => Source.IsSignatureType;

            public override bool IsSZArray 
                => Source.IsSZArray;

            public override bool IsTypeDefinition 
                => Source.IsTypeDefinition;

            public override bool IsVariableBoundArray 
                => Source.IsVariableBoundArray;

            public override R.MemberTypes MemberType 
                => Source.MemberType;

            public override S.Type ReflectedType 
                => Source.ReflectedType;

            public override StructLayoutAttribute StructLayoutAttribute 
                => Source.StructLayoutAttribute;

            public override S.RuntimeTypeHandle TypeHandle 
                => Source.TypeHandle;

            public override S.Type[] FindInterfaces(R.TypeFilter filter, object filterCriteria)
                => Source.FindInterfaces(filter, filterCriteria);
            
            public override R.MemberInfo[] FindMembers(R.MemberTypes memberType, R.BindingFlags bindingAttr, R.MemberFilter filter, object filterCriteria)
                => Source.FindMembers(memberType, bindingAttr, filter, filterCriteria);

            public override int GetArrayRank()
                => Source.GetArrayRank();
            public override R.ConstructorInfo[] GetConstructors(R.BindingFlags bindingAttr)
                => Source.GetConstructors(bindingAttr);

            public override object[] GetCustomAttributes(bool inherit)
                => Source.GetCustomAttributes(inherit);

            public override object[] GetCustomAttributes(S.Type attributeType, bool inherit)
                => Source.GetCustomAttributes(attributeType, inherit);

           public override IList<R.CustomAttributeData> GetCustomAttributesData()
                => Source.GetCustomAttributesData();

            public override R.MemberInfo[] GetDefaultMembers()
                => Source.GetDefaultMembers();

            public override S.Type GetElementType()
                => Source.GetElementType();

            public override string GetEnumName(object value)
                => Source.GetEnumName(value);

            public override string[] GetEnumNames()
                => Source.GetEnumNames();

            public override S.Type GetEnumUnderlyingType()
                => Source.GetEnumUnderlyingType();

            public override S.Array GetEnumValues()
                => Source.GetEnumValues();

            public override R.EventInfo GetEvent(string name, R.BindingFlags bindingAttr)
                => Source.GetEvent(name, bindingAttr);

            public override R.EventInfo[] GetEvents(R.BindingFlags bindingAttr)
                => Source.GetEvents(bindingAttr);

            public override R.EventInfo[] GetEvents()
                => Source.GetEvents();

            public override R.FieldInfo GetField(string name, R.BindingFlags bindingAttr)
                => Source.GetField(name, bindingAttr);

            public override R.FieldInfo[] GetFields(R.BindingFlags bindingAttr)
                => Source.GetFields(bindingAttr);

            public override S.Type[] GetGenericArguments()
                => Source.GetGenericArguments();

            public override S.Type[] GetGenericParameterConstraints()
                => Source.GetGenericParameterConstraints();

            public override S.Type GetGenericTypeDefinition()
                => Source.GetGenericTypeDefinition();

            public override S.Type GetInterface(string name, bool ignoreCase)
                => Source.GetInterface(name, ignoreCase);

            public override R.InterfaceMapping GetInterfaceMap(S.Type interfaceType)
                => Source.GetInterfaceMap(interfaceType);

            public override S.Type[] GetInterfaces()
                => Source.GetInterfaces();

            public override R.MemberInfo[] GetMember(string name, R.BindingFlags bindingAttr)
                => Source.GetMember(name, bindingAttr);

            public override R.MemberInfo[] GetMember(string name, R.MemberTypes type, R.BindingFlags bindingAttr)
                => Source.GetMember(name, type, bindingAttr);

            public override R.MemberInfo[] GetMembers(R.BindingFlags bindingAttr)
                => Source.GetMembers(bindingAttr);

            public override R.MethodInfo[] GetMethods(R.BindingFlags bindingAttr)
                => Source.GetMethods(bindingAttr);

            public override S.Type GetNestedType(string name, R.BindingFlags bindingAttr)
                => Source.GetNestedType(name, bindingAttr);

            public override S.Type[] GetNestedTypes(R.BindingFlags bindingAttr)
                => Source.GetNestedTypes(bindingAttr);

            public override R.PropertyInfo[] GetProperties(R.BindingFlags bindingAttr)
                => Source.GetProperties(bindingAttr);

            public override bool HasSameMetadataDefinitionAs(R.MemberInfo other)
                => Source.HasSameMetadataDefinitionAs(other);

            public override bool IsDefined(S.Type attributeType, bool inherit)
                => Source.IsDefined(attributeType, inherit);

            public override bool IsEnumDefined(object value)
                => Source.IsEnumDefined(value);

            public override bool Equals(object o)
                => Source.Equals(o);

            public override bool Equals(S.Type o)
                => Source.Equals(o);

 
             public override int GetHashCode()
                => Source.GetHashCode();

            public override string ToString()
                => Source.ToString();

            public override bool IsAssignableFrom(S.Type c) 
                => Source.IsAssignableFrom(c);

            public override bool IsEquivalentTo(S.Type other)
                => Source.IsEquivalentTo(other);

            public override bool IsInstanceOfType(object o)
                => Source.IsInstanceOfType(o);

            public override bool IsSubclassOf(S.Type c)
                => Source.IsSubclassOf(c);

            protected override S.TypeCode GetTypeCodeImpl()
                => S.Type.GetTypeCode(Source);

            protected override bool HasElementTypeImpl()
                => Source.HasElementType;

            protected override bool IsArrayImpl()
                => Source.IsArray;

            protected override bool IsByRefImpl()
                => Source.IsByRef;

            protected override bool IsCOMObjectImpl()
                => Source.IsCOMObject;

            protected override bool IsContextfulImpl()
                => Source.IsContextful;

            protected override bool IsMarshalByRefImpl()
                => Source.IsMarshalByRef;

            protected override bool IsPointerImpl()
                => Source.IsPointer;

            protected override bool IsPrimitiveImpl()
                => Source.IsPrimitive;

            protected override bool IsValueTypeImpl()
                => Source.IsValueType;

           protected override R.TypeAttributes GetAttributeFlagsImpl()
                => Source.Attributes;

            protected override R.ConstructorInfo GetConstructorImpl(R.BindingFlags bindingAttr, R.Binder binder, 
                R.CallingConventions callConvention, S.Type[] types, R.ParameterModifier[] modifiers)
                    => Source.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);

            protected override R.MethodInfo GetMethodImpl(string name, R.BindingFlags bindingAttr, R.Binder binder, 
                R.CallingConventions callConvention, S.Type[] types, R.ParameterModifier[] modifiers)
                    => Source.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);

            protected override R.MethodInfo GetMethodImpl(string name, int genericParameterCount, R.BindingFlags bindingAttr, 
                R.Binder binder, R.CallingConventions callConvention, S.Type[] types, R.ParameterModifier[] modifiers)
                    => Source.GetMethod(name, genericParameterCount, bindingAttr, binder, callConvention, types, modifiers);

            protected override R.PropertyInfo GetPropertyImpl(string name, R.BindingFlags bindingAttr, R.Binder binder, 
                S.Type returnType, S.Type[] types, R.ParameterModifier[] modifiers)
                    => Source.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);

            public override S.Type MakeArrayType()
                => Source.MakeArrayType();

            public override S.Type MakeArrayType(int rank)
                => Source.MakeArrayType(rank);

            public override S.Type MakeByRefType()
                => Source.MakeByRefType();

            public override S.Type MakeGenericType(params S.Type[] typeArguments)
                => Source.MakeGenericType(typeArguments);

            public override S.Type MakePointerType()
                => Source.MakePointerType();

            public override object InvokeMember(string name, R.BindingFlags invokeAttr, R.Binder binder, object target, object[] args, 
                R.ParameterModifier[] modifiers, G.CultureInfo culture, string[] namedParameters)
                    => Source.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
        }
    }
}