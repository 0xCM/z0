//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using F = XedInstructionField;
    using R = XedInstructionRecord;

    public enum XedInstructionField : uint
    {
        Sequence = 0 | 16 << WidthOffset,
        
        Mnemonic = 1 | 16 << WidthOffset,

        Extension = 2 | 16 << WidthOffset,

        BaseCode = 3 | 8 << WidthOffset,

        Mod = 4 | 4 << WidthOffset,

        Reg = 5 | 8 << WidthOffset,
    }
    
    public readonly struct XedInstructionRecord : IRecord<F,R>
    {
        public static XedInstructionRecord Empty 
            => new XedInstructionRecord(0, asci.Null, asci.Null, asci.Null, asci.Null, asci.Null);

        public readonly int Sequence;
        
        public readonly asci16 Mnemonic;

        public readonly asci16 Extension;

        public readonly asci8 BaseCode;

        public readonly asci4 Mod;

        public readonly asci8 Reg;
    
        [MethodImpl(Inline)]
        public XedInstructionRecord(int Sequence, asci16 Mnemonic, asci16 Extension, asci8 BaseCode, asci4 Mod, asci8 Reg)
        {
            this.Sequence = Sequence;
            this.Mnemonic = Mnemonic;
            this.Extension = Extension;
            this.BaseCode = BaseCode;
            this.Mod = Mod;
            this.Reg = Reg;
        }
        
        public string DelimitedText(char delimiter)
        {            
            var formatter = Tabular.Formatter<F>(delimiter);
            formatter.Delimit(F.Sequence, Sequence);
            formatter.Delimit(F.Mnemonic, Mnemonic);
            formatter.Delimit(F.Extension, Extension);
            formatter.Delimit(F.BaseCode, BaseCode);
            formatter.Delimit(F.Mod, Mod);
            formatter.Delimit(F.Reg, Reg);
            return string.Empty;
        }

        int ISequential.Sequence 
            => Sequence;
    }
}