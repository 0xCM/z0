//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct r8 : IRegOp8
    {    
        public Fixed8 Value  {get;}
        
        public RegisterKind Kind {get;}        
        
        [MethodImpl(Inline)]
        public r8(Fixed8 value, RegisterKind kind)
        {
            Value = value;
            Kind = kind;
        }            
    } 
}