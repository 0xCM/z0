//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static XmlParts;

    public interface IXmlElement : IXmlPart<Name>
    {
        XmlAttributes Attributes {get;}
    }
}