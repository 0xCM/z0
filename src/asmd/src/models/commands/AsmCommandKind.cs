//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    using G = CommandGroup;

    public enum CommandGroup : ushort
    {
        None = 0,

        ADD,

        AND,

        ANDN,

        BEXTR,

        CALL,

        CMP,

        JCC,

        MOV,
        
        POP,


        Last = 0b1111_1111_1111,

    }

    /// <summary>
    /// [CommandGroup:0..11 | ]
    /// </summary>
    public enum AsmCommandKind : ulong
    {
        None = 0,

        And_Rm8xR8 = G.AND,

        And_Rm16xR16 = G.AND,

        And_Rm32xR32 = G.AND,

        And_Rm64xR64 = G.AND,

    }

}