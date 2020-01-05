//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Describes a block of memory the context of an asm instruction operand
    /// </summary>
    public class AsmMemInfo
    {        
        public string BaseRegister {get;set;}
        
        public uint? Displacement {get; set;}
        
        public int? IndexScale {get; set;}
        
        public int? DisplacementSize {get;set;}
        
        public string SegmentRegister {get; set;}
        
        public string SegmentPrefix {get; set;}
        
        public ulong Address {get; set;}

        public string Size {get; set;}
        
    }

}