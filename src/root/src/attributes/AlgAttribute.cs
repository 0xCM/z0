//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AsmAlgAttribute : OpAttribute
    {
        public AsmAlgAttribute(object data)
            : base(ApiClassKind.Asm, (ushort)data)
        {

        }
    }

    public class AsmOpAttribute : OpAttribute
    {
        public AsmOpAttribute(object data)
            : base(ApiClassKind.Asm, (ushort)data)
        {

        }
    }
}