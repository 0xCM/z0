//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface ISigned : IPrimitive
    {
        BlittableKind IPrimitive.TypeKind
            => BlittableKind.Signed;
    }

    [Free]
    public interface ISigned<T> : ISigned, IPrimitive<T>
        where T : unmanaged
    {
    }
}