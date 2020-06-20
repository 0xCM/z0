//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct r64 : IRegOp64
    {    
        public ulong Value  {get;}

        public RegisterKind Kind {get;}
        
        [MethodImpl(Inline)]
        public r64(ulong value, RegisterKind kind)
        {
            Value = value;
            Kind = kind;
        }
    }   
}