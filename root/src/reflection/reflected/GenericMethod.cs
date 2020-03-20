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

    public readonly struct GenericMethod
    {        
        [MethodImpl(Inline)]
        GenericMethod(MethodInfo src, GenericStateKind kind)
        {
            this.Element = src;
            this.Kind = kind;
        }
        public MethodInfo Element  {get;}

        public GenericStateKind Kind {get;}

    }
}