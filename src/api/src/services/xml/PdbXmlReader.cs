//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class PdbXmlReader : XmlSourceReader<XmlSource>
    {
        public PdbXmlReader(XmlSource src)
            : base(src)
        {

        }

        public void Dispose()
        {
            Source.Dispose();
        }
    }

    public readonly partial struct PdbXmlModel
    {

    }
}