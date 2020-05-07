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
        public static string Render(OpKind src)
        {
            var si = SegIndicator.From(src);
            if(si.IsNonEmpty)
                return si.Format();

            var result = src switch{
		    OpKind.Register => "register",
            NearBranch16 => "branch[near:16]",
		    NearBranch32 => "branch[near:32]",
		    NearBranch64 => "branch[near:64]",
            FarBranch16 => "branch[far:16]",
            FarBranch32 => "branch[far:32]",
            Immediate8 => "imm8",
            Immediate8_2nd => "imm8[2]",
            Immediate16 => "imm16",
            Immediate32 => "imm32",
            Immediate64 => "imm64",
            Immediate8to16 => "imm8[16i]",
            Immediate8to32 => "imm8[32i]",
            Immediate8to64 => "imm8[64i]",
            Immediate32to64 => "imm32[64i]",
            Memory64 => "mem64",
            Memory => "mem",
                _ => ""
            };

            return result;
        }
    }
}