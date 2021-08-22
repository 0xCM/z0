//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RegClass
    {
        public RegClassCode Code {get;}

        [MethodImpl(Inline)]
        public RegClass(RegClassCode code)
        {
            Code = code;
        }

        public string Format()
            => AsmRender.format(this);


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RegClassCode(RegClass src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator RegClass(RegClassCode src)
            => new RegClass(src);
    }
}