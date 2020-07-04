//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    public interface IPartResolver
    {
        IPart[] Resolve(FilePath[] paths);

        bool IsPart(Assembly src);

        Assembly[] Parts(FilePath[] src);

        bool DefinesPart(FilePath src);

        PartIndex Index();
    }
}