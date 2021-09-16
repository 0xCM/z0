//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class FieldSegAttribute : Attribute
    {
        public uint Order {get;}
        public uint Width {get;}

        public FieldSegAttribute(uint width)
        {
            Width = width;
        }

        public FieldSegAttribute(uint order, uint width)
        {
            Order = order;
            Width = width;
        }
    }
}