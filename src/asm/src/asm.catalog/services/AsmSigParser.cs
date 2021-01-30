//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

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
        /// <returns></returns>
        [Op]
        public bool IsComposite(AsmSigOperandExpr src)
        {

            return false;
        }

        [Op]
        public bool ParseMnemonic(AsmSigExpr src, out AsmMnemonicExpr dst)
        {
            dst = AsmMnemonicExpr.Empty;
            var content = src.Content.Text;
            var index = content.FirstIndexOf(AsciChar.Space);
            if(index)
            {
                dst = text.slice(content,0, index.Value);
                return true;
            }
            return false;
        }
    }
}