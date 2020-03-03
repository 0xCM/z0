//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct GenericType
    {
        [MethodImpl(Inline)]
        public static GenericType? From(Type src)
        {
            var kind = src.GenericKind(false);
            if(kind.IsSome()) 
                return new GenericType(src,kind);
            else
                return null;
        }
        
        [MethodImpl(Inline)]
        GenericType(Type src, GenericKind kind)
        {
            this.Element = src;
            this.Kind = kind;                
        }

        public Type Element  {get;}

        public GenericKind Kind {get;}

    }
}