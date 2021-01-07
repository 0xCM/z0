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
            Kind = ClrPrimalKind.String;
        }

        public DataAttribute(byte src)
        {
            Content = src;
            Kind = ClrPrimalKind.U8;
        }

        public DataAttribute(ushort src)
        {
            Content = src;
            Kind = ClrPrimalKind.U16;
        }

        public DataAttribute(uint src)
        {
            Content = src;
            Kind = ClrPrimalKind.U32;
        }

        public object Content {get;}

        public ClrPrimalKind Kind {get;}
    }
}