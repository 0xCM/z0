//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    [LiteralProvider]
    public readonly partial struct RenderPatterns
    {
        /// <summary>
        /// Defines the literal " |"
        /// </summary>
        [StringLiteral(" |")]
        public const string SpacePipe = Space + Pipe;

        /// <summary>
        /// Defines the literal '{0} -> {1}'
        /// </summary>
        [FormatPattern("{0} -> {1}")]
        public const string ArrowAxB = "{0} -> {1}";
    }
}