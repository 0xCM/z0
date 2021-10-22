//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFloat : IBlittable
    {
        DataKind IBlittable.TypeKind
            => DataKind.Float;
    }


    [Free]
    public interface IFloat<T> : IFloat, IBlittable<T>
        where T : unmanaged
    {

    }
}