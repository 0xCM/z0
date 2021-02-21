//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public interface IApiServices : IWfService
    {
        IApiJit ApiJit();

        Index<ApiAddressRecord> EmitCatalog(BasedApiMembers src);

        void EmitApiClasses();

        Index<SymbolicLiteral> EmitSymbolicLiterals(Index<Assembly> src, FS.FilePath dst);
    }
}