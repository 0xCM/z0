//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;

    using static Part;

    partial struct XmlParts
    {
        public readonly struct Element : IXmlElement
        {
            public Name Value {get;}

            public XmlAttributes Attributes {get;}

            [MethodImpl(Inline)]
            public Element(string value, XmlAttributes attributes)
            {
                Value = value;
                Attributes = attributes;
            }

            public XmlNodeType Kind
                => XmlNodeType.Element;
        }
    }
}