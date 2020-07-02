//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct r8 : IRegOperand8
    {    
        public readonly byte Content  {get;}
        
        public readonly RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public r8(byte value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }            
    } 
}