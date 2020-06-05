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
    
    public readonly struct ClrField<T>
    {   
        public FieldInfo Data {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(ClrField<T> lhs, ClrField<T> rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(ClrField<T> lhs, ClrField<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrField<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public ClrField(FieldInfo data)
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