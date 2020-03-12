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

    public interface IDataMember<M> : ICustomAttributeProvider
        where M : MemberInfo
    {
        M Member {get;}       

        object GetStaticValue();

        object GetConstantValue();

        object GetValue(object src);        

        object GetValue(TypedReference tr);

        string Name
            => Member.Name;

        int MetadataToken
            => Member.MetadataToken;
                                
        Type DeclaringType
            => Member.DeclaringType;

        MemberTypes MemberType
            => Member.MemberType;
        
        Module Module
            => Member.Module;

        object[] ICustomAttributeProvider.GetCustomAttributes(bool inherit)
            => Member.GetCustomAttributes(inherit);

        object[] ICustomAttributeProvider.GetCustomAttributes(Type attributeType, bool inherit)
            => Member.GetCustomAttributes(attributeType, inherit);

        bool ICustomAttributeProvider.IsDefined(Type attributeType, bool inherit)
            => Member.IsDefined(attributeType, inherit);
    } 
}