//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Iced = Iced.Intel;

    partial class IceExtractors
    {
        [MethodImpl(Inline)]
        public static OpAccess[] OpAccess(Iced.InstructionInfo src)
            => Memories.array(
                    Deicer.Thaw(src.Op0Access),
                    Deicer.Thaw(src.Op0Access),
                    Deicer.Thaw(src.Op2Access),
                    Deicer.Thaw(src.Op3Access),
                    Deicer.Thaw(src.Op4Access)).Where(x => x != 0);
    }
}