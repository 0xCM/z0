//-----------------------------------------------------------------------------
// Derived from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    public enum OpKindFieldId : uint
    {
        [Comment("Gets operand #0's opkind")]
        Op0Kind,

        [Comment("Gets operand #1's opkind")]
        Op1Kind,

        [Comment("Gets operand #2's opkind")]
        Op2Kind,

        [Comment("Gets operand #3's opkind")]
        Op3Kind,

        [Comment("Gets operand #4's opkind")]
        Op4Kind,
    }
}