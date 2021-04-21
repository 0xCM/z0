//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        /// <summary>
        /// Description taken from the geberated documentation file xed-doc-top.txt
        /// </summary>
        const string SizeIndicators = @"
            The naming scheme for iforms can get rather complex and continues to
            evolve over time as the instruction set architecture grows.  They
            mostly use the lower-case letter codes found in the opcode map found
            in the appendix to the Intel&reg; 64 and IA-32 Architectures Software
            Developers Manual.  For example the scalable instructions
            mentioned above use the 'v' code which the manuals describe as
            representing 16, 32 or 64b operands depending on the effective operand
            size.  The code 'z' implies either 16 or 32b operation; When the
            effective operand size is 64, the operand is still 32b. Other common
            suffixes one might see are 'd' for 32b and 'q' for 64b. The codes 'ps'
            and 'pd' stand for packed scalar (single precision floating point) and
            packed double (double precision floating point). The code 'dq' is used
            to describe 128b (16B) quantities typically in memory or an XMM
            register. Similarly 'qq' describes a 256b (32B) quantity in memory or
            a YMM register.";
    }
}