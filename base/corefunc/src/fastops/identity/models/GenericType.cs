//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct GenericType : IGeneric<Type>
    {
        [MethodImpl(Inline)]
        public static Option<GenericType> From(Type src)
        {
            var kind = src.GetGenericKind(false);
            return kind.IsSome() ? new GenericType(src,kind) : none<GenericType>();
        }
        
        [MethodImpl(Inline)]
        GenericType(Type src, GenericKind kind)
        {
            this.Element = src;
            this.Kind = kind;
                
        }

        public Type Element  {get;}

        public GenericKind Kind {get;}

        public override string ToString() 
            => Element.DisplayName();         
    }
}