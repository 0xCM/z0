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
    public struct AsmMemInfo : IFormattable<AsmMemInfo>
    {      
        [MethodImpl(Inline)]
        public static AsmMemInfo Init(MemorySize size, string sizefmt)
        {
            var dst = default(AsmMemInfo);
            dst.Size = size;
            dst.SizeFormat = sizefmt;
            return dst;
        }

        public Register BaseRegister {get;set;}
        
        public uint? Displacement {get; set;}
        
        public int? IndexScale {get; set;}
        
        public int? DisplacementSize {get;set;}
        
        public Register SegmentRegister {get; set;}
                
        public Register SegmentPrefix {get; set;}
        
        public ulong Address {get; set;}

        public MemorySize Size {get; set;}

        public string SizeFormat {get;set;}

        public string Format()
        {
            var formatted = string.Empty;
            if(BaseRegister != Register.None)                
                formatted += BaseRegister.ToString();
            if(Size != MemorySize.Unknown)
                formatted += text.lspace(Size);
            if(SizeFormat.IsNotBlank())
                formatted += text.lspace(SizeFormat);
            return formatted;

        }

        public override string ToString()
            => Format();
    }
}