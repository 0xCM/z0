//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct r16 : IRegOp16
    {    
        public ushort Content  {get;}

        public RegisterKind Kind {get;}        

        [MethodImpl(Inline)]
        public r16(ushort value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }
    } 
}