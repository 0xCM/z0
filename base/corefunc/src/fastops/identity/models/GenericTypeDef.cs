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

    public readonly struct GenericTypeDef : IGeneric<Type>
    {
        [MethodImpl(Inline)]
        public static Option<GenericTypeDef> From(Type src)
        {
            var t = src.EffectiveType();
            if(t.IsGenericTypeDefinition)
                return new GenericTypeDef(t);
            else if(t.IsConstructedGenericType || t.ContainsGenericParameters)
                return new GenericTypeDef(t.GetGenericTypeDefinition());
            else
                return none<GenericTypeDef>();                        
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Type(GenericTypeDef src)
            => src.Element;

        [MethodImpl(Inline)]
        GenericTypeDef(Type src)
        {
            this.Element = src;
            this.Kind = GenericKind.Definition;
        }

        public Type Element  {get;}

        public GenericKind Kind {get;}

        public override string ToString() 
            => Element.DisplayName();
    }
}