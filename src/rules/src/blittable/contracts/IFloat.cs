//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFloat : IPrimitive
    {
        TypeKind IPrimitive.TypeKind
            => TypeKind.Float;
    }

    [Free]
    public interface IFloat<T> : IFloat, IPrimitive<T>
        where T : unmanaged
    {

    }
}