//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Specifies the target width
    /// </summary>
    public class FieldWidthAttribute : Attribute
    {
        public FieldWidthAttribute(byte width)
        {
            Width = width;
        }

        public FieldWidthAttribute(object width)
        {

            Width = width;
        }

        public object Width {get;}
    }
}