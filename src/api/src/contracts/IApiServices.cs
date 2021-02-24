//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IApiServices : IWfService
    {
        IApiJit ApiJit();

        IApiHexIndex HexIndexService();

        BasedApiMemberCatalog RebaseMembers(BasedApiMembers src);

        BasedApiMemberCatalog RebaseMembers();

        Index<ApiCatalogRecord> LoadRebaseEntries();

        void EmitApiClasses();

        Index<SymbolicLiteral> EmitSymbolicLiterals(Index<Assembly> src, FS.FilePath dst);
    }
}