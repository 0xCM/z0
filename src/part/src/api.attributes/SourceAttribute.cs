//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class DataSourceAttribute : Attribute
    {
        public DataSourceAttribute(object value)
        {
            Value = value;
        }

        public object Value {get;}
    }
}