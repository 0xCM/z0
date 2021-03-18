//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using I = IApiCanonicalClass;
    using K = ApiCanonicalClass;

    [Free]
    public interface IApiCanonicalClass : IApiKind<K>
    {
        new ApiCanonicalClass Kind {get;}
    }


    [Free]
    public interface IApiCanonicalClass<F,T> : IApiCanonicalClass
        where F : unmanaged, IApiCanonicalClass
    {
        K I.Kind
            => default(F).Kind;
    }
}