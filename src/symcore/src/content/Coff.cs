//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class Coff : BinaryContainer<Coff>
    {
        public Coff()
        {
            ContentType = ContentTypes.define(ContentKind.Coff, ContentNames.coff);
        }

        public override ContentType ContentType {get;}
    }
}