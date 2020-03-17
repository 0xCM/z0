//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;


    /// <summary>
    /// A succinct type signature
    /// </summary>
    public readonly struct TypeSig
    {        
        public static TypeSig FromType(Type src)
            => new TypeSig(
                src.DisplayName(), 
                src.IsConstructedGenericType,  
                src.IsGenericType && 
                !src.IsConstructedGenericType, 
                src.IsByRef, 
                src.IsPointer);

        public static TypeSig FromParameter(ParameterInfo src)
        {            
            
            var type = src.ParameterType;
            var name = type.EffectiveType().DisplayName();            
            return new TypeSig(name, 
                type.IsConstructedGenericType, 
                type.IsGenericType && !type.IsConstructedGenericType,
                type.IsRef(),
                src.IsIn,
                src.IsOut,
                type.IsPointer);
        }

        TypeSig(string DisplayName, bool IsOpenGeneric, bool IsClosedGeneric, bool IsByRef, bool IsIn = false, bool IsOut = false, bool IsPointer = false)
        {
            this.DisplayName = DisplayName;
            this.IsOpenGeneric = IsOpenGeneric;
            this.IsClosedGeneric = IsClosedGeneric;
            this.IsByRef = IsByRef;
            this.IsIn = IsIn;
            this.IsOut = IsOut;
            this.IsPointer = IsPointer;
        }

        public string DisplayName {get;}

        public bool IsOpenGeneric {get;}

        public bool IsClosedGeneric {get;}

        public bool IsByRef {get;}

        public bool IsIn {get;}

        public bool IsOut {get;}

        public bool IsPointer {get;}
        
        string Modifier
            => IsIn ? "in " : IsOut ? "out " : IsByRef ? "ref " : string.Empty;

        public string Format()
            => $"{Modifier}{DisplayName}";        
 
        public override string ToString()
            => Format();
    }
}