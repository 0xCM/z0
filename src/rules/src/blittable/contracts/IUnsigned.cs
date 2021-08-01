//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IUnsigned : IPrimitive
    {
        BlittableKind IPrimitive.TypeKind
            => BlittableKind.Unsigned;
    }
    [Free]
    public interface IUnsigned<T> : IUnsigned, IPrimitive<T>
        where T : unmanaged
    {
    }
}