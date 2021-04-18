//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmCases
    {
        /// <summary>
        /// Validates the integrity of the case itself
        /// </summary>
        /// <param name="src">The case to validate</param>
        /// <param name="errors">An error receiver</param>
        [Op]
        public static bool validate(in CallRel32Case src, ITextBuffer errors)
        {
            var valid = true;
            const byte fxsize = 5;

            if(src.IpDelta != fxsize)
            {
                errors.AppendLineFormat($"{nameof(src.IpDelta)} = ${src.IpDelta} != {fxsize}");
                valid = false;
            }

            if(src.Encoding.Size != fxsize)
            {
                errors.AppendLineFormat($"{nameof(src.Encoding.Size)} = ${src.Encoding.Size} != {fxsize}");
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