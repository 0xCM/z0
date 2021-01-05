//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public interface IApiJit
    {
        Index<ApiAddressRecord> JitApi(FS.FilePath dst);
    }
}