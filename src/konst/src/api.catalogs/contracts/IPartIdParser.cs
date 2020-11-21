//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPartIdParser<P> : IArrayParser<P,PartId>
        where P : ITextParser<PartId>
    {

    }

    [Free]
    public interface IPartIdParser : IPartIdParser<ApiPartIdParser>
    {

    }
}