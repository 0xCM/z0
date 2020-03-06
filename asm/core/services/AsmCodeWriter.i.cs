//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface IAsmCodeWriter : IAsmStreamWriter
    {
        void WriteCode(in CapturedOp src, int? idpad = null);

        void WriteHexLine(in CapturedOp src, int? idpad = null);

        void WriteHexLine(OpIdentity id, Span<byte> data, int? idpad = null);

    }
}