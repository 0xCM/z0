//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    using static Parted;
    
    public interface TPartResolver : IPartResolver
    {
        IPart[] IPartResolver.Resolve(FilePath[] paths)
            => resolve(paths);

        bool IPartResolver.IsPart(Assembly src)
            => test(src);  

        Assembly[] IPartResolver.Parts(FilePath[] src)
            => parts(src);

        bool IPartResolver.DefinesPart(FilePath src)
            => assembly(src).MapValueOrDefault(x => test(x));   

        PartIndex IPartResolver.Index()
            => index();                     
    }
}