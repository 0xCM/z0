//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd]
    public struct EmitHostHexCmd : ICmdSpec<EmitHostHexCmd>
    {
        public ApiHostUri ApiHost;

        public ApiMemberCodeBlocks Source;
    }

}