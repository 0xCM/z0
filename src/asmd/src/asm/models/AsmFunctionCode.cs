//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmFunctionCode
    {
        public static AsmFunctionCode Empty 
            => new AsmFunctionCode(AsmFunction.Empty, CapturedCode.Empty);
        
        public AsmFunction Function {get;}

        public CapturedCode Code {get;}
 
        [MethodImpl(Inline)]
        public static implicit operator AsmFunctionCode((AsmFunction f, CapturedCode code) src)
            => new AsmFunctionCode(src.f, src.code);
        
        [MethodImpl(Inline)]
        public AsmFunctionCode(AsmFunction f, CapturedCode code)
        {
            Function = f;
            Code = code;
        }       
    }
}