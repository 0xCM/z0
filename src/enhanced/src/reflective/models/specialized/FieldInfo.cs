//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    
    using S = System;
    using R = System.Reflection;
    using G = System.Globalization;

    partial struct Reflected
    {
        public sealed class FieldInfo : R.FieldInfo
        {
            readonly R.FieldInfo Source;
            
            [MethodImpl(Inline)]
            public FieldInfo(R.FieldInfo src)
            {
                Source = src;
            }
            
            public override R.FieldAttributes Attributes 
                => Source.Attributes;
            
            public override S.RuntimeFieldHandle FieldHandle 
                 => Source.FieldHandle;

            public override S.Type FieldType 
                => Source.FieldType;

            public override S.Type DeclaringType 
                => Source.DeclaringType;

            public override string Name 
                => Source.Name;

            public override S.Type ReflectedType 
                => Source.ReflectedType;

            public override IEnumerable<R.CustomAttributeData> CustomAttributes 
                => Source.CustomAttributes;

            public override bool IsCollectible 
                => Source.IsCollectible;
            public override int MetadataToken 
                => Source.MetadataToken;

            public override R.Module Module 
                => Source.Module;
 
            public override bool IsSecurityCritical 
                => Source.IsSecurityCritical;

            public override bool IsSecuritySafeCritical 
                => Source.IsSecuritySafeCritical;

            public override bool IsSecurityTransparent 
                => Source.IsSecurityTransparent;

            public override R.MemberTypes MemberType 
                => Source.MemberType;

            public override bool Equals(object obj)
                => Source.Equals(obj);

            public override object[] GetCustomAttributes(bool inherit)
                => Source.GetCustomAttributes(inherit);

            public override object[] GetCustomAttributes(S.Type attributeType, bool inherit)
                => Source.GetCustomAttributes(attributeType, inherit);

            public override IList<R.CustomAttributeData> GetCustomAttributesData()
                => Source.GetCustomAttributesData();

            public override int GetHashCode()
                => Source.GetHashCode();

            public override S.Type[] GetOptionalCustomModifiers()
                => Source.GetOptionalCustomModifiers();

            public override object GetRawConstantValue()
                => Source.GetRawConstantValue();

            public override S.Type[] GetRequiredCustomModifiers()
                => Source.GetRequiredCustomModifiers();

            public override object GetValue(object obj)
                => Source.GetValue(obj);

            public override object GetValueDirect(S.TypedReference obj)
                => GetValueDirect(obj);

            public override bool HasSameMetadataDefinitionAs(R.MemberInfo other)
                => Source.HasSameMetadataDefinitionAs(other);

            public override bool IsDefined(S.Type attributeType, bool inherit)
                => Source.IsDefined(attributeType, inherit);

            public override void SetValue(object obj, object value, R.BindingFlags invokeAttr, R.Binder binder, G.CultureInfo culture)
                => Source.SetValue(obj, value, invokeAttr, binder, culture);

            public override void SetValueDirect(S.TypedReference obj, object value)
                => Source.SetValueDirect(obj, value);

            public override string ToString()
                => Source.ToString();
        }
    }
}