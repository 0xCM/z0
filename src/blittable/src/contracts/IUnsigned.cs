//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct Blit
    {
        [Free]
        public interface IUnsigned : IPrimitive
        {
            BlittableKind IPrimitive.TypeKind
                => BlittableKind.Unsigned;
        }
    }
}