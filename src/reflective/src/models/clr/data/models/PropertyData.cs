//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Reflective;
    
    public readonly struct PropertyData<T> : IClrDataAdapter<PropertyInfo,T>
    {                
        [MethodImpl(Inline)]
        public static bool operator ==(PropertyData<T> lhs, PropertyData<T> rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(PropertyData<T> lhs, PropertyData<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator PropertyInfo(PropertyData<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public PropertyData(PropertyInfo data)
            => Data = data;
        
        public PropertyInfo Data {get;}

        public string Format()
            => Data.ToString();
        
        public override bool Equals(object obj)
            => Data.Equals(obj);

        public override int GetHashCode()
            => Data.GetHashCode();

        public override string ToString()
            => Format();
    }
}