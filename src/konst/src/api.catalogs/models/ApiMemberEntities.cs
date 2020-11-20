//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiHostMemberEntities
    {
        public ApiHostUri Host;

        public TableSpan<ApiMemberEntity> Members;
    }
}