//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.All)]
    public class DataAttribute : Attribute
    {
        public DataAttribute(string src)
        {
            Content = src;
            Kind = PrimalKind.String;
        }

        public DataAttribute(byte src)
        {
            Content = src;
            Kind = PrimalKind.U8;
        }

        public DataAttribute(ushort src)
        {
            Content = src;
            Kind = PrimalKind.U16;
        }

        public DataAttribute(uint src)
        {
            Content = src;
            Kind = PrimalKind.U32;
        }

        public object Content {get;}

        public PrimalKind Kind {get;}
    }
}