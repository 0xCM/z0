//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartIdParser<P> : IArrayParser<P,PartId>
        where P : ITextParser<PartId>
    {
        PartId[] ParseValid(params string[] args);
    }

    public interface IPartIdParser : IPartIdParser<PartIdParser>
    {
    
    }
}