//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IToolsetDist : IFileArchive
    {
        ToolId ToolsetId {get;}

        Index<ToolId> Tools {get;}
    }

    public interface IToolsetDist<H> : IToolsetDist
        where H : IToolsetDist<H>, new()
    {

    }
}