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

    public interface IClrDataAdapter<M,T> : ICustomAttributeProvider
        where M : ICustomAttributeProvider
    {
         object[] ICustomAttributeProvider.GetCustomAttributes(bool inherit)
            => Data.GetCustomAttributes(inherit);

         object[] ICustomAttributeProvider.GetCustomAttributes(Type tAttrib, bool inherit)
            => Data.GetCustomAttributes(tAttrib, inherit);

         bool ICustomAttributeProvider.IsDefined(Type tAttrib, bool inherit) 
            => Data.IsDefined(tAttrib, inherit);
        
        bool Tagged<A>(bool inherit)
            where A : Attribute
                => Data.IsDefined(typeof(A), inherit);

         A[] Tags<A>(bool inherit)
            where A : Attribute
                => Data.GetCustomAttributes(typeof(A),inherit).Cast<A>().ToArray();

         M Data {get;}
    }
}