//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies a data type with content that can be rendered in tabular form
    /// </summary>
    public class TableAttribute : Attribute
    {
        public TableAttribute(Type fieldspec)
            => FieldSpec = fieldspec;

        public Type FieldSpec {get;}
    }
}