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

    public readonly struct LinkIdentifier<T> : IIdentified<T>
    {
        public T Id {get;}             

        readonly T[] Segments;

        public string Identifier {get;}
        
        [MethodImpl(Inline)]        
        public static implicit operator LinkIdentifier<T>(T src)
            => new LinkIdentifier<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(LinkIdentifier<T> src)
            => src.Id;

        [MethodImpl(Inline)]
        public static implicit operator LinkIdentifier<T>((T src, T dst) id)
            => new LinkIdentifier<T>(id.src, id.dst);
        
        [MethodImpl(Inline)]
        public static implicit operator LinkIdentifier(LinkIdentifier<T> src)
            => new LinkIdentifier(src.Identifier);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public LinkIdentifier(T id)
        {
            Segments = new T[1]{id};
            Id = id;
            Identifier = text.format(id);
        }                    

        public LinkIdentifier(T[] components)
        {
            Segments = components;
            Id = default;
            Identifier = text.join(" -> ", Segments);
        }

        public LinkIdentifier(T src, T dst)
        {
            Segments = z.array(src,dst);
            Id = default;
            Identifier = text.join(" -> ", Segments);         
        }
    }
}