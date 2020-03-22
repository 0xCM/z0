//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IAsmFunctionWriter : IAsmStreamWriter
    {
        void Write(params AsmFunction[] src);
    }
}