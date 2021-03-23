//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiExtractParser
    {
        Outcome Parse(string src, out ApiExtractBlock dst);
    }
}