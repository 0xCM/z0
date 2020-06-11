//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static OpKind;

    partial struct SemanticRender
    {                
        public string Render(OpKind src)
        {
            var si = RenderSegKind(src);
            if(text.nonempty(si))
                return si;

            var result = src switch{
		    OpKind.Register => "register",
            NearBranch16 => "branch16",
		    NearBranch32 => "branch32",
		    NearBranch64 => "branch64",
            FarBranch16 => "farbranch16",
            FarBranch32 => "farbranch32",
            Immediate8 => "imm8",
            Immediate8_2nd => "imm8x2",
            Immediate16 => "imm16",
            Immediate32 => "imm32",
            Immediate64 => "imm64",
            Immediate8to16 => "imm16i",
            Immediate8to32 => "imm32i",
            Immediate8to64 => "imm64i",
            Immediate32to64 => "imm32x64i",
            Memory64 => "mem64",
            Memory => "mem",
                _ => src.ToString()
            };

            return result;
        }
    }
}