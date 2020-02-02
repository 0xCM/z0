//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct GenericMethodDef : IGeneric<MethodInfo>
    {
        [MethodImpl(Inline)]
        public static Option<GenericMethodDef> From(MethodInfo src)
        {
            if(src.IsGenericMethodDefinition)
                return new GenericMethodDef(src);
            else if(src.IsConstructedGenericMethod || src.ContainsGenericParameters)
                return new GenericMethodDef(src.GetGenericMethodDefinition());
            else
                return none<GenericMethodDef>();                        
        }
        
        [MethodImpl(Inline)]
        public static implicit operator MethodInfo(GenericMethodDef src)
            => src.Element;

        [MethodImpl(Inline)]
        GenericMethodDef(MethodInfo src)
        {
            this.Element = src;
            this.Kind = GenericKind.Definition;
        }

        public MethodInfo Element  {get;}

        public GenericKind Kind {get;}

        public override string ToString() 
            => Element.Signature().ToString();
    }

}