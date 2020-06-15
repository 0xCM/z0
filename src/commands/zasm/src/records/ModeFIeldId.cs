//-----------------------------------------------------------------------------
// Derived from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    public enum ModeFieldId : uint
    {
        [Comment("true if it's an instruction available in 16-bit mode")]
        Mode16,

        [Comment("true if it's an instruction available in 32-bit mode")]
        Mode32,

        [Comment("true if it's an instruction available in 64-bit mode")]
        Mode64,

    }
}