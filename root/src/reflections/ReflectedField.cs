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

     public readonly struct ReflectedField : IDataMember<FieldInfo>
     {
        public FieldInfo Member {get;}
        
        [MethodImpl(Inline)]
        internal ReflectedField(FieldInfo member)
            => this.Member = member;
        
        [MethodImpl(Inline)]
        public object GetStaticValue()
            => Member.GetValue(null);

        [MethodImpl(Inline)]
        public object GetConstantValue()
            => Member.GetRawConstantValue();

        [MethodImpl(Inline)]
        public object GetValue(TypedReference tr)
            => Member.GetValueDirect(tr);

        [MethodImpl(Inline)]
        public object GetValue(object src)
            => Member.GetValue(src);
    } 
}