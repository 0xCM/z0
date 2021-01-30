//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    [ApiHost]
    public sealed partial class AsmSigParser : WfService<AsmSigParser, AsmSigParser>
    {
        public bool Parse(AsmSigExpr src, out AsmSig dst)
        {
            dst = AsmSig.Empty;


            return false;
        }


        /// <summary>
        /// Determines whether a <see cref='AsmSigOperandExpr'/> is a composite expression delimited by the <see cref='Chars.FSlash'/> character
        /// </summary>
        /// <param name="src"></param>
        [Op]
        public bool IsComposite(AsmSigOperandExpr src)
        {

            return src.Content.Contains(AsciChar.FS);
        }

        [Op]
        public bool ParseMnemonic(AsmSigExpr src, out AsmMnemonicExpr dst)
        {
            dst = AsmMnemonicExpr.Empty;
            var content = src.Content;
            var index = content.FirstIndexOf(AsciChar.Space);
            if(index != NotFound)
            {
                dst = text.slice(content,0, index);
                return true;
            }
            return false;
        }
    }
}