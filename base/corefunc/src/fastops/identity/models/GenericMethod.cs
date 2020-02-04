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

    public readonly struct GenericMethod : IGeneric<MethodInfo>
    {
        [MethodImpl(Inline)]
        public static Option<GenericMethod> From(MethodInfo src)
        {
            var kind = src.GenericKind(false);
            return kind.IsSome() ? new GenericMethod(src,kind) : none<GenericMethod>();
        }
        
        [MethodImpl(Inline)]
        GenericMethod(MethodInfo src, GenericKind kind)
        {
            this.Element = src;
            this.Kind = kind;
        }
        public MethodInfo Element  {get;}

        public GenericKind Kind {get;}

        public override string ToString() 
            => Element.Signature().ToString();
    }

}