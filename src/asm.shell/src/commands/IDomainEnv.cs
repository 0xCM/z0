//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDomainEnv
    {
        Identifier Name {get;}

        ReadOnlySpan<FS.FolderPath> Folders {get;}
    }

    public interface IDomainEnv<T> : IDomainEnv
        where T : IDomainEnv<T>
    {
        Identifier IDomainEnv.Name
            => typeof(T).Name;
    }

}