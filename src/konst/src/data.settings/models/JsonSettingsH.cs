//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class JsonSettings<H> : IJsonSettings<H>
        where H : JsonSettings<H>, new()
    {
        public static H From(IJsonSettings src)
            => JsonSettings.From<H>(src);
    }
}