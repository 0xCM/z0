//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct SpanIndicators
    {
        /// <summary>
        /// Indicates a system-defined mutable span type
        /// </summary>
        public const string Span = "span";

        /// <summary>
        /// Indicates an system-defined readonly span
        /// </summary>
        public const string ReadOnly = "rspan";

        /// <summary>
        /// Indicates a custom span type predicated parametrically on natrural number types
        /// </summary>
        public const string Natural = "nspan";
    }
}