//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static SFx;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {

        [Free]
        public interface IBinarySquare<W,T> : IBinaryRefOp<W,T>, IBinaryRefStepOp<W,T>
            where T : unmanaged
            where W : unmanaged, ITypeWidth
        {
        }
    }
}