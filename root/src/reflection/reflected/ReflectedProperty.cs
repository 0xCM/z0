//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

     public readonly struct ReflectedProperty : IDataMember<PropertyInfo>
     {
        [MethodImpl(Inline)]
        internal ReflectedProperty(PropertyInfo member)
            => this.Member = member;            
        
        public PropertyInfo Member {get;}          

        [MethodImpl(Inline)]
        public object GetStaticValue()
            => Member.GetValue(null);

        [MethodImpl(Inline)]
        public object GetConstantValue()
            => Member.GetRawConstantValue();

        [MethodImpl(Inline)]
        public object GetValue(object src)
            => Member.GetValue(src);

        [MethodImpl(Inline)]
        public object GetValue(TypedReference tr)
            => throw new NotSupportedException();
     } 
}