//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IChar : IBlittable
    {
        DataKind IBlittable.TypeKind
            => DataKind.Char;
    }

    [Free]
    public interface IChar<T> : IChar, IBlittable<T>
        where T : unmanaged
    {

    }
}