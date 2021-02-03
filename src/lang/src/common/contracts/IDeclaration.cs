//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public interface IDeclaration
    {

    }

    public interface IDeclaration<T> : IDeclaration
        where T : struct, IDeclaration<T>
    {

    }
}