//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiJit
    {
        LocatedMethod JitMethod(IdentifiedMethod src);

        BasedApiMembers JitCatalog();

        ApiMembers JitPart(IPart src);

        ApiMembers JitHost(IApiHost src);

        ApiMembers Jit(Index<ApiRuntimeType> src);
    }
}