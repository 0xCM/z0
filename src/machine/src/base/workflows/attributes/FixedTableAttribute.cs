//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies a tabular data type with fixed-width content
    /// </summary>
    public class FixedTableAttribute : TableAttribute
    {        
        public FixedTableAttribute(Type fieldspec)
        : base(fieldspec)
        {

        }
    }
}