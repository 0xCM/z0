//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class CmdAttribute : Attribute
    {
        public CmdAttribute()
        {
            Id = EmptyString;
        }

        public CmdAttribute(string id)
        {
            Id = id;
            Synonyms = sys.empty<string>();
        }

        public CmdAttribute(string id, params string[] syn)
        {
            Id = id;
            Synonyms = syn;
        }

        public string Id {get;}


        public string[] Synonyms {get;}
    }
}