//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    /// <summary>
    /// A succinct type signature
    /// </summary>
    public class TypeSig
    {        
        public static TypeSig FromType(Type src)
            => new TypeSig(src.DisplayName(), src.IsConstructedGenericType,  src.IsGenericType && !src.IsConstructedGenericType, src.IsByRef);

        public static TypeSig FromParameter(ParameterInfo src)
        {
            var type = src.ParameterType;
            var name = type.EffectiveType().DisplayName();
            
            return new TypeSig(name, 
                type.IsConstructedGenericType, 
                type.IsGenericType && !type.IsConstructedGenericType,
                type.IsRef(),
                src.IsIn,
                src.IsOut);
        }

        public TypeSig(string Name, bool IsOpenGeneric, bool IsClosedGeneric, bool IsByRef, bool IsIn = false, bool IsOut = false)
        {
            this.Name = Name;
            this.IsOpenGeneric = IsOpenGeneric;
            this.IsClosedGeneric = IsClosedGeneric;
            this.IsByRef = IsByRef;
            this.IsIn = IsIn;
            this.IsOut = IsOut;
        }

        public string Name {get;}

        public bool IsOpenGeneric {get;}

        public bool IsClosedGeneric {get;}

        public bool IsByRef {get;}

        public bool IsIn {get;}

        public bool IsOut {get;}
        
        string Modifier
            => IsIn ? "in " : IsOut ? "out " : IsByRef ? "ref " : string.Empty;

        public string Format()
            => $"{Modifier}{Name}";        
 
 
        public override string ToString()
            => Format();
    }
}