//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public interface ITensor : IBlittable
        {
            byte Arity {get;}

            BlittableKind IBlittable.TypeKind
                => BlittableKind.Tensor;
        }
    }
}