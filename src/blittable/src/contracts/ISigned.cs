//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public interface ISigned : IBlittable
        {
            DataKind IBlittable.TypeKind
                => DataKind.Signed;
        }
    }
}