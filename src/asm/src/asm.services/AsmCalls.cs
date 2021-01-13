//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct AsmCalls
    {
        [MethodImpl(Inline), Op]
        public static string format(in AsmCallTarget src)
            => text.concat(src.Base.Format(), Chars.Colon, Chars.Space, ifempty(src.Id, "target"));

        /// <summary>
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress offset(in AsmCall src)
            => src.Client.Base + src.CallSite;

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