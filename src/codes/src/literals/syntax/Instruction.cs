//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    partial class SyntaxAtoms
    {

        public enum InstructionAtom : byte
        {

            imm8,
            
            imm16,
            
            imm32,
            
            imm64,

            m16ᙾ16,

            m16є16,

            m16э16
        }
    }
}