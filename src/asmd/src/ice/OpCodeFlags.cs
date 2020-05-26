//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;

    [Flags, NumericBase(16)]
    public enum OpCodeFlags : uint 
    {
        None					= 0,

        Mode16					= 0x00000001,

        Mode32					= 0x00000002,

        Mode64					= 0x00000004,

        Fwait					= 0x00000008,

        LIG						= 0x00000010,

        WIG						= 0x00000020,

        WIG32					= 0x00000040,

        W						= 0x00000080,

        Broadcast				= 0x00000100,

        RoundingControl			= 0x00000200,

        SuppressAllExceptions	= 0x00000400,

        OpMaskRegister			= 0x00000800,

        ZeroingMasking			= 0x00001000,

        LockPrefix				= 0x00002000,

        XacquirePrefix			= 0x00004000,

        XreleasePrefix			= 0x00008000,

        RepPrefix				= 0x00010000,

        RepnePrefix				= 0x00020000,

        BndPrefix				= 0x00040000,

        HintTakenPrefix			= 0x00080000,

        NotrackPrefix			= 0x00100000,

        NoInstruction			= 0x00200000,

        NonZeroOpMaskRegister	= 0x00400000,
    }
}