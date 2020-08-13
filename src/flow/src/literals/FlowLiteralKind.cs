//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum FlowLiteralKind : byte
    {
        /// <summary>
        /// Classifies the "|" literal
        /// </summary>
        Pipe,
        
        /// <summary>
        /// Classifies literals of the form "| {n}" where n = 0,1,.., for a natural integer N
        /// </summary>
        PSxN,


    }
}