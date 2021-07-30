//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface ISigned : IPrimitive
    {
        TypeKind IPrimitive.TypeKind
            => TypeKind.Signed;
    }

    [Free]
    public interface ISigned<T> : ISigned, IPrimitive<T>
        where T : unmanaged
    {
    }
}