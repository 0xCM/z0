//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures operation invocation information from the client perspective
    /// </summary>
    public struct Invocation : ITextual
    {
        /// <summary>
        /// The invoking operation
        /// </summary>
        public CallClient Client;

        /// <summary>
        /// The base-relative address that captures the offset follows the client call instruction
        /// </summary>
        public ushort CallSite;

        /// <summary>
        /// The argument supplied to the call instruction
        /// </summary>
        public CallTarget CalledTarget;

        /// <summary>
        /// The base address of the intended target, magically-known
        /// </summary>
        public CallTarget ActualTarget;

        [MethodImpl(Inline)]
        public Invocation(CallClient client, ushort site, CallTarget called, CallTarget actual = default)
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

        public string Format()
            => AsmCalls.format(this);

        public override string ToString()
            => Format();
    }
}