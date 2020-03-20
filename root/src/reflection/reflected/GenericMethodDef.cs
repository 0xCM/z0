//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct GenericMethodDef
    {
        [MethodImpl(Inline)]
        public static GenericMethodDef? From(MethodInfo src)
        {
            if(src.IsGenericMethodDefinition)
                return new GenericMethodDef(src);
            else if(src.IsConstructedGenericMethod || src.ContainsGenericParameters)
                return new GenericMethodDef(src.GetGenericMethodDefinition());
            else
                return null;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator MethodInfo(GenericMethodDef src)
            => src.Definition;

        [MethodImpl(Inline)]
        GenericMethodDef(MethodInfo src)
        {
            this.Definition = src;
            this.Kind = GenericStateKind.Definition;
        }

        public MethodInfo Definition  {get;}

        public GenericStateKind Kind {get;}

    }

}