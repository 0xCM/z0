//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiJit
    {
        LocatedMethod Jit(IdentifiedMethod src);

        BasedApiMembers JitApi(FS.FilePath dst);

        BasedApiMembers JitApi();

        ApiMembers Jit(IPart src);

        ApiMembers Jit(IApiHost src);

        ApiMember[] Jit(Index<ApiRuntimeType> src);

        Index<ApiAddressRecord> EmitAddresses(BasedApiMembers src, FS.FilePath dst);
    }
}