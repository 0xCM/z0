//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures operation invocation information from the client perspective
    /// </summary>
    public struct AsmCallInfo
    {
        /// <summary>
        /// Computes the call-site offset relative to the base address of the client
        /// </summary>
        /// <param name="src">The invocation</param>
        [MethodImpl(Inline), Op]
        public static string format(in AsmCallInfo src)
        {
            var site = src.InstructionAddress;
            var target =  src.CalledTarget.Base;
            var o = (site - target).Location;
            var delta = (src.ActualTarget.Base - site).Location;
            var actual = src.ActualTarget.Identity;
            var client_field = text.concat(src.Client.Identity, text.embrace(site.Format()));
            return $"{client_field} | {target} | {o} | {actual} | {delta}";
        }

        /// <summary>
        /// The invoking operation
        /// </summary>
        public AsmCaller Client;

        /// <summary>
        /// The base-relative address that captures the offset follows the client call instruction
        /// </summary>
        public Address16 CallSite;

        /// <summary>
        /// The argument supplied to the call instruction
        /// </summary>
        public AsmCallee CalledTarget;

        /// <summary>
        /// The base address of the intended target
        /// </summary>
        public AsmCallee ActualTarget;

        [MethodImpl(Inline)]
        public AsmCallInfo(AsmCaller client, Address16 site, AsmCallee called, AsmCallee actual)
        {
            Client = client;
            CallSite = site;
            CalledTarget = called;
            ActualTarget = actual;
        }

        /// <summary>
        /// The callsite-relative target location
        /// </summary>
        public MemoryAddress TargetOffset
        {
            [MethodImpl(Inline)]
            get => CalledTarget.Base - (Client.Base + CallSite);
        }

        /// <summary>
        /// The address of the call instruction
        /// </summary>
        public MemoryAddress InstructionAddress
        {
            [MethodImpl(Inline)]
            get => Client.Base + CallSite;
        }

        public string Format()
            => format(this);

        public override string ToString()
            => Format();
    }
}