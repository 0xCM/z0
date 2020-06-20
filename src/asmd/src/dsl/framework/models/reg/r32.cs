//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct r32 : IRegOp32
    {   
        public Fixed32 Value  {get;}

        public RegisterKind Kind {get;}             

        [MethodImpl(Inline)]
        public r32(Fixed32 value, RegisterKind kind)
        {
            Value = value;
            Kind = kind;
        }
    } 
}