//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDocument : ITextual
    {
        ILocation Source {get;}
    }

    public interface IDocument<D> : IDocument
        where D :  IDocument, new()
    {
        D Load(ILocation src);
    }


    public interface IDocument<D,C> : IDocument<D>
        where D : IDocument, new()
        where C : struct, ITextual
    {
        C Content {get;}
    }

    public interface IDocument<D,C,L> : IDocument<D,C>
        where D :  IDocument, new()
        where C : struct, ITextual
        where L : struct, ILocation
    {
        D Load(L location);

        new L Source {get;}

        ILocation IDocument.Source
            => Source;

        D IDocument<D>.Load(ILocation location)
            => Load((L)location);
    }
}