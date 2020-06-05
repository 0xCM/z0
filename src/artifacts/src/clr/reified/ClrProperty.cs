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
    
    using static Seed;
    
    public readonly struct ClrProperty<T>
    {   
        public PropertyInfo Data {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(ClrProperty<T> lhs, ClrProperty<T> rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(ClrProperty<T> lhs, ClrProperty<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator PropertyInfo(ClrProperty<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public ClrProperty(PropertyInfo data)
            => Data = data;
        
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