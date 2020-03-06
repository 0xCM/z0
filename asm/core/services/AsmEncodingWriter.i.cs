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
    public interface IAsmEncodingWriter : IAsmStreamWriter
    {
        void Write(in CapturedOp src, int? idpad = null);

        void Write(OpIdentity id, Span<byte> data, int? idpad = null);
    }
}