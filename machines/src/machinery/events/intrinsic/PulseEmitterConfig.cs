//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines configuration parameters for pulse emission
    /// </summary>
    public sealed class PulseEmitterConfig
    {
        public PulseEmitterConfig(TimeSpan Frequency)
        {
            this.Frequency = Frequency;
        }

        /// <summary>
        /// Specifies the emission frequency
        /// </summary>
        public TimeSpan Frequency {get;}
    }
}