//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

        public readonly struct ymm : IYmmRegOp
        {
            public Fixed256 Value {get;}
            public RegisterKind Kind {get;}

            [MethodImpl(Inline)]
            public ymm(Fixed256 value, RegisterKind kind)
            {
                Value = value;
                Kind = kind;
            }                
        }
 
}