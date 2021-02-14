//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    public readonly partial struct AsmPatterns
    {
        public readonly struct PreCodeFixupThunk
        {
            /*
            00007FFEBEF560E0 58                   pop         rax
            00007FFEBEF560E1 4C 0F B6 50 02       movzx       r10,byte ptr [rax+2]
            00007FFEBEF560E6 4C 0F B6 58 01       movzx       r11,byte ptr [rax+1]
            00007FFEBEF560EB 4A 8B 44 D0 03       mov         rax,qword ptr [rax+r10*8+3]
            00007FFEBEF560F0 4E 8D 14 D8          lea         r10,[rax+r11*8]
            00007FFEBEF560F4 E9 47 03 00 00       jmp         ThePreStub (07FFEBEF56440h)
            */

        }

    }
}
