//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Delegate contract for emission event receipt
    /// </summary>
    /// <param name="data">The event data</param>
    public delegate void AsmEmissionObserver(in AsmEmissionTokens<OpUri> data);

    /// <summary>
    /// Defines a source for events that originate within a capture exchange context. This
    /// device is used as a means to compensate for the fact that the exchange itself, which is a
    /// ref struct, cannot be contracted.
    /// </summary>
    public interface IExtractJunction
    {
        /// <summary>
        /// Invoked by the exchange to relay a capture state change
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The new state</param>
        void OnCaptureStep(in OpExtractExchange src, in ExtractState state);   

        /// <summary>
        /// Invoked by the exchange to relay a capture completion event
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The final state</param>
        /// <param name="captured">The captured member</param>
        void OnCaptureComplete(in OpExtractExchange src, in ExtractState state, in CapturedMember captured);        
    }

    public interface IExtractControl : ICaptureService, IExtractJunction
    {

    }
}