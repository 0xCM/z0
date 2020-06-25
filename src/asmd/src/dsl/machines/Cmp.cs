//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;


    public readonly struct Cmp  
    {

        public void exec(al dst, imm8 src)
        {

        }

        public void exec(ax dst, imm16 src)
        {

        }

        public void exec(eax dst, imm32 src)
        {

        }

    }

    /*
| 3C ib            | CMP AL, imm8      | I     | Valid       | Valid           | Compare imm8 with AL.                              |
| 3D iw            | CMP AX, imm16     | I     | Valid       | Valid           | Compare imm16 with AX.                             |
| 3D id            | CMP EAX, imm32    | I     | Valid       | Valid           | Compare imm32 with EAX.                            |

    */
}
