//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Dsl;

    using static Konst;
    using R = Registers;

    partial struct DslCases
    {
        [MethodImpl(Inline), Op]
        public function kind(in FunctionBuilder dst)
        {
            //var mov = asm.movzx(R.cx, R.eax);
            return dst.Emit();
        }        
    }
}