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
        GenericType(Type src, GenericStateKind kind)
        {
            this.Element = src;
            this.Kind = kind;                
        }

        public Type Element  {get;}

        public GenericStateKind Kind {get;}
    }
}