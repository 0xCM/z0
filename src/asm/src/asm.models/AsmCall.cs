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
    [Record]
    public struct AsmCall : ITextual, IRecord<AsmCall>
    {
        /// <summary>
        /// The invoking operation
        /// </summary>
        public AsmCallClient Client;

        /// <summary>
        /// The base-relative address that captures the offset follows the client call instruction
        /// </summary>
        public ushort CallSite;

        /// <summary>
        /// The argument supplied to the call instruction
        /// </summary>
        public AsmCallTarget CalledTarget;

        /// <summary>
        /// The base address of the intended target, magically-known
        /// </summary>
        public AsmCallTarget ActualTarget;

        [MethodImpl(Inline)]
        public AsmCall(AsmCallClient client, ushort site, AsmCallTarget called, AsmCallTarget actual = default)
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