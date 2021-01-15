//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using RF = RexFieldIndex;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static string format(in AsmCallRow src)
            => string.Format(AsmCallRow.RenderPattern, src.Source, src.Target, src.InstructionSize, src.TargetOffset, src.Instruction, src.Encoded);

        [Op]
        public static string format(RexPrefixBits src)
            => $"{RF.Code}:{src.Code} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";

        /// <summary>
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static string format(in AsmCall src)
        {
            var site = offset(src);
            var target =  src.CalledTarget.Base;
            var o = (site - target).Location;
            var delta = (src.ActualTarget.Base - site).Location;
            var actual = src.ActualTarget.Id;
            var client_field = text.concat(src.Client.Id, text.embrace(site.Format()));
            return $"{client_field} | {target} | {o} | {actual} | {delta}";
        }
    }
}