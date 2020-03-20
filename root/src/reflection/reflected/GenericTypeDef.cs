//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct GenericTypeDef
    {
        [MethodImpl(Inline)]
        public static GenericTypeDef? From(Type src)
        {
            var t = src.EffectiveType();
            if(t.IsGenericTypeDefinition)
                return new GenericTypeDef(t);
            else if(t.IsConstructedGenericType || t.ContainsGenericParameters)
                return new GenericTypeDef(t.GetGenericTypeDefinition());
            else
                return null;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Type(GenericTypeDef src)
            => src.Definition;

        [MethodImpl(Inline)]
        GenericTypeDef(Type src)
        {
            this.Definition = src;
            this.Kind = GenericStateKind.Definition;
        }

        public Type Definition  {get;}

        public GenericStateKind Kind {get;}
    }
}