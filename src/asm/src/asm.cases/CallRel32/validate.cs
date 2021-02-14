//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmCases
    {
        [Op]
        public static bool validate(in CallRel32Case src, ITextBuffer errors)
        {
            var valid = true;
            if(src.IpDelta != 5)
            {
                errors.AppendLineFormat($"{nameof(src.IpDelta)} = ${src.IpDelta} != 5");
                valid = false;
            }

            if(src.Offset != src.RelTarget)
            {
                errors.AppendLineFormat($"{nameof(src.Offset)} = ${src.Offset} != {src.RelTarget} = {nameof(src.RelTarget)}");
                valid = false;
            }

            return valid;
        }
    }
}