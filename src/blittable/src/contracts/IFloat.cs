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
        public interface IFloat : IBlittable
        {
            DataKind IBlittable.TypeKind
                => DataKind.Float;
        }
    }
}