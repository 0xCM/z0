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

    public readonly struct TypeData<T> : IClrDataAdapter<Type,T>
    {                
        [MethodImpl(Inline)]
        public static bool operator ==(TypeData<T> lhs, TypeData<T> rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(TypeData<T> lhs, TypeData<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator Type(TypeData<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public TypeData(Type data)
            => Data = Control.require(data);
        
        public Type Data {get;}

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