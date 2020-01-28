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

    interface IBaseAsmFormatter
    {
        ReadOnlySpan<string> CaptureBaseFormat(Iced.InstructionList src, ulong baseaddress);
    }

}