//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class Document<D> : Universe<D>, IDocument<D>
        where D : Document<D>, new()
    {
        public ILocation Source {get;}

        protected Document(ILocation src)
        {
            Source = src;
        }

        protected Document()
        {
            Source = Location.Empty;
        }

        public abstract D Load(ILocation location);

        public abstract string Format();
    }

    public abstract class Document<D,C> : Document<D>, IDocument<D,C>
        where D : Document<D,C>, new()
        where C : struct, ITextual
    {
        public C Content {get;}

        protected Document(C content)
            : base(Location.Empty)
        {
            Content = content;
        }

        protected Document(ILocation src, C content)
            : base(src)
        {
            Content = content;
        }

        public override string Format()
            => Content.Format();

        public override string ToString()
            => Format();
    }

    public abstract class Document<D,C,L> : Document<D,C>, IDocument<D,C,L>
        where D : Document<D,C>, new()
        where C : struct, ITextual
        where L : struct, ILocation
    {
        public static D load(L location)
            => new D().Load(location);

        protected Document(L src, C content)
            : base(src, content)
        {
            Source = src;
        }

        protected Document(C content)
            : base(content)
        {
            Source = default;
        }

        public new L Source {get;}

        public abstract D Load(L src);

        public sealed override D Load(ILocation src)
            => Load((L)src);
    }
}