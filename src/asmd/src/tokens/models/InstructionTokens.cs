//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    readonly partial struct InstructionTokenInfo
    {
        const int TokenCount = (int)InstructionTokenKind.TokenCount;
    }
    
    public partial class InstructionTokens
    {
        [MethodImpl(Inline)]
        public static string Meaning(InstructionTokenKind token)
            => InstructionTokenInfo.Meanings[(int)token];

        [MethodImpl(Inline)]
        public static string Identity(InstructionTokenKind token)
            => InstructionTokenInfo.Identity[(int)token];

        [MethodImpl(Inline)]
        public static string Definition(InstructionTokenKind token)
            => InstructionTokenInfo.Definitions[(int)token];

        public static TokenInfo[] Models
            => InstructionTokenInfo.Models;                  
    }
}