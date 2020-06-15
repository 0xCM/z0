//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    
    using F = InstructionField;
    using R = InstructionRecord;

    public enum InstructionField : uint
    {
        Sequence = 0,
        
        Mnemonic = 1,

        Extension = 2,

        BaseCode = 3,

        Mod = 4,

        Reg = 5
    }


    public readonly struct InstructionRecord : IRecord<F,R>
    {
        public readonly int Sequence;
        
        public readonly asci16 Mnemonic;

        public readonly asci16 Extension;

        public readonly asci8 BaseCode;

        public readonly asci4 Mod;

        public readonly asci8 Reg;

        int ISequential.Sequence => Sequence;

        // public string Format()
        // {
            

        //     return string.Empty;

        // }

    }

}