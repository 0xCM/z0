//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct BitFlow
    {
        [Free]
        public interface IUnsigned : IBlittable
        {
            BlittableKind IBlittable.TypeKind
                => BlittableKind.Unsigned;
        }
    }
}