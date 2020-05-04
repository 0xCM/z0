//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    
    using static Seed;
    using static Memories;

    public interface IUriBitsDecoder : IService
    {
        IEnumerable<AsmInstructions> Decode(IEnumerable<UriBits> bits);
    }
}