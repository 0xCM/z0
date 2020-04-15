//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public enum TriangularKind : byte
    {        
        /// <summary>
        /// Classifies a matrix as lower-triangular
        /// </summary>
        Lower,
        
        /// <summary>
        /// Classifies a matrix as upper-triangular
        /// </summary>
        Upper,
    }    
}