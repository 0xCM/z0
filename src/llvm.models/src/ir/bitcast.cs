//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    using static Metatypes;

    public struct BitcastSpec
    {
        public TypeDescriptor Source;

        public TypeDescriptor Target;

        [MethodImpl(Inline)]
        public BitcastSpec(TypeDescriptor src, TypeDescriptor dst)
        {
            Source = src;
            Target = dst;
        }
    }
}