//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{    
    public interface ILink
    {
        LinkIdentifier Name { get; }
    }

    public interface ILink<X> : ILink
    {

        X Source { get; }

        X Target { get; }
    }

    public interface ILink<X,Y> : ILink
    {
        X Source { get; }

        Y Target { get; }
    }
}