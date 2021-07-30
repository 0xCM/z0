//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IUnsigned : IPrimitive
    {
        TypeKind IPrimitive.TypeKind
            => TypeKind.Unsigned;
    }
    [Free]
    public interface IUnsigned<T> : IUnsigned, IPrimitive<T>
        where T : unmanaged
    {
    }
}