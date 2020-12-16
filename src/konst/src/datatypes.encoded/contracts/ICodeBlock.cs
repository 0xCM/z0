//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICodeBlock : IEncoded
    {
        /// <summary>
        /// The head of the memory location from which the data originated
        /// </summary>
        MemoryAddress Base {get;}
    }
}