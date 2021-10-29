//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IUnsigned : IBlittable
    {
        DataKind IBlittable.TypeKind
            => DataKind.Unsigned;
    }

    [Free]
    public interface IUnsigned<T> : IUnsigned, IBlittable<T>
        where T : unmanaged
    {
    }
}