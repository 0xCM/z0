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
        /// Classifies the " " literal
        /// </summary>
        Space,

        /// <summary>
        /// Classifies a literal of the fom "{n}" where n = 0,1..,N for natural integer integer N
        /// </summary>
        Slot,

        /// <summary>
        /// Classifies literals that intersperse <see cref='Slot'/> literals with <see cref='Pipe'/> literals
        /// </summary>
        PS,

        /// <summary>
        /// Classifies literals that intersperse <see cref='Slot'/> literals with <see cref='Space'/> literals
        /// </summary>
        SS,
        
        /// <summary>
        /// Classifies literals of the form "| {n}" where n = 0,1,.., for a natural integer N
        /// </summary>
        PSxN,

        /// <summary>
        /// Classifies literals of the form " {n}" where n = 0,1,.., for a natural integer N
        /// </summary>
        SSxN,

    }
}