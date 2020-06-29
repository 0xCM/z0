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
        public uint Content  {get;}

        public RegisterKind Kind {get;}             

        [MethodImpl(Inline)]
        public r32(uint value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }
    } 
}