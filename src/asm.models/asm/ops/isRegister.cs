//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm;
    
    using static Konst;
   
    partial struct asm
    {
        /// <summary>
        /// Tests whether the the source operand kind is a register kind
        /// </summary>
        /// <param name="src">The source operand kind</param>
        [MethodImpl(Inline), Op]
        public static bool isRegister(OpKind src)
            => src == OpKind.Register;  
    }
}