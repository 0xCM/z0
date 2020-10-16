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

    /// <summary>
    /// Applied to a data structure to indicate that a <see cref='CmdSpec'/> can be derived from the content of a value
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class CmdAttribute : Attribute
    {
        public string Id {get;}

        public string[] Synonyms {get;}

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
    }
}