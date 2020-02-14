//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly struct GenericMethod
    {
        [MethodImpl(Inline)]
        public static GenericMethod? From(MethodInfo src)
        {
            var kind = src.GenericKind(false);
            if(kind.IsSome())
                return new GenericMethod(src,kind);
            else
                return null;            
        }
        
        [MethodImpl(Inline)]
        GenericMethod(MethodInfo src, GenericKind kind)
        {
            this.Element = src;
            this.Kind = kind;
        }
        public MethodInfo Element  {get;}

        public GenericKind Kind {get;}

    }
}