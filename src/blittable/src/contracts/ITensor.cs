//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct BitFlow
    {
        public interface ITensor : IPrimitive
        {
            byte Arity {get;}

            BlittableKind IPrimitive.TypeKind
                => BlittableKind.Tensor;
        }
    }
}