//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct RegClass
    {
        public RegClassCode Code {get;}

        [MethodImpl(Inline)]
        public RegClass(RegClassCode code)
        {
            Code = code;
        }

        [MethodImpl(Inline)]
        public static implicit operator RegClass(RegClassCode src)
            => new RegClass(src);

        [MethodImpl(Inline)]
        public static implicit operator RegClassCode(RegClass src)
            => src.Code;
    }
}