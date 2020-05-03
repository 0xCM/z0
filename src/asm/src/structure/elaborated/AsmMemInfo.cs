//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public struct AsmMemInfo
    {      
        public static AsmMemInfo Empty => default(AsmMemInfo);
                
        public Register SegmentRegister {get; set;}
                
        public Register SegmentPrefix {get; set;}
        
        public AsmMemDirect? Direct {get;set;}

        public ulong Address {get; set;}

        public MemorySize Size {get; set;}

        public bool IsEmpty
        {
            get => Size == 0 && Direct == null && SegmentRegister == 0 && SegmentPrefix == 0;
        }
    }
}