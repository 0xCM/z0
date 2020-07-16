//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct LinkIdentifier : IIdentified<string>
    {
        public string Id {get;}                         
        
        readonly string[] Segments;

        [MethodImpl(Inline)]        
        public static implicit operator LinkIdentifier(string src)
            => new LinkIdentifier(src);

        [MethodImpl(Inline)]
        public static implicit operator string(LinkIdentifier src)
            => src.Id;

        [MethodImpl(Inline)]
        public static implicit operator LinkIdentifier((string src, string dst) id)
            => new LinkIdentifier(id.src, id.dst);
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Id);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public LinkIdentifier(string id)
        {
            Segments = new string[1]{id};
            Id = id;
        }                    

        public LinkIdentifier(object[] components)
        {
            Segments = (from c in components select text.format(c)).Array();
            Id = text.join(" -> ", Segments);
        }

        public LinkIdentifier(string src, string dst)
        {
            Segments = z.array(src,dst);
            Id = text.join(" -> ", Segments);         
        }
    }
}