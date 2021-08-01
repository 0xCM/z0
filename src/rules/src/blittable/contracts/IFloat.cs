//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFloat : IPrimitive
    {
        BlittableKind IPrimitive.TypeKind
            => BlittableKind.Float;
    }

    [Free]
    public interface IFloat<T> : IFloat, IPrimitive<T>
        where T : unmanaged
    {

    }
}