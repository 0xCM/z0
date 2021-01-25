//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiJit
    {
        BasedApiMembers JitApi(FS.FilePath dst);

        BasedApiMembers JitApi();

        ApiMembers Jit(IPart src);

        ApiMembers Jit(IApiHost src);

        ApiMember[] Jit(Index<ApiTypeInfo> src);

        Index<ApiAddressRecord> EmitAddresses(BasedApiMembers src, FS.FilePath dst);
    }
}