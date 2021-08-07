//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Blit
    {
        public interface ISigned : IPrimitive
        {
            BlittableKind IPrimitive.TypeKind
                => BlittableKind.Signed;
        }
    }
}