//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using SP = SymbolPaths;

    partial interface IEnvPaths
    {
        SymbolPaths SymbolPaths()
            => SP.create(Env);

        SymbolPaths SymbolPaths(FS.FolderPath root)
            => SP.create(root);
    }
}