//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    unsafe partial struct Buffers
    {

        [MethodImpl(Inline)]
        public static ref readonly BinaryCode liberate(in BinaryCode src)
        {
            memory.liberate<byte>(src.Ref);
            return ref src;
        }
    }
}