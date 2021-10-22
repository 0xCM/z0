//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISigned : IBlittable
    {
        DataKind IBlittable.TypeKind
            => DataKind.Signed;
    }

    [Free]
    public interface ISigned<T> : ISigned, IBlittable<T>
        where T : unmanaged
    {
    }

}