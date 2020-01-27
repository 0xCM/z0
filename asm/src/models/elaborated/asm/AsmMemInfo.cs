//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public class AsmMemInfo
    {        
        public Register BaseRegister {get;set;}
        
        public uint? Displacement {get; set;}
        
        public int? IndexScale {get; set;}
        
        public int? DisplacementSize {get;set;}
        
        public Register SegmentRegister {get; set;}
        
        public Register SegmentPrefix {get; set;}
        
        public ulong Address {get; set;}

        public MemorySize Size {get; set;}

        public string SizeFormat {get;set;}
        
    }

}