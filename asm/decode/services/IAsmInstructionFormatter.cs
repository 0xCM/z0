//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    using Iced = Iced.Intel;

    /// <summary>
    /// Internal contract for instruction-level formatting
    /// </summary>
    public interface IAsmInstructionFormatter
    {
        ReadOnlySpan<string> FormatInstructions(Iced.InstructionList src, ulong baseaddress);
    }
}