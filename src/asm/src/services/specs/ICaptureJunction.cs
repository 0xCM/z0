//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Defines a source for events that originate within a capture exchange context. 
    /// </summary>
    /// <remarks>
    /// This device is used as a means to compensate for the fact that the exchange itself, which is a
    /// ref struct, cannot be contracted.
    /// </remarks>
    public interface ICaptureJunction
    {
        /// <summary>
        /// Invoked by the exchange to relay a capture state change
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The new state</param>
        void OnCaptureStep(in CaptureExchange src, in ExtractState state);   

        /// <summary>
        /// Invoked by the exchange to relay a capture completion event
        /// </summary>
        /// <param name="src">The source exchange</param>
        /// <param name="state">The final state</param>
        /// <param name="captured">The captured member</param>
        void OnCaptureComplete(in CaptureExchange src, in ExtractState state, in MemberCapture captured);        
    } 
}