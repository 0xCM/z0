//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly partial struct RP
    {
        /// <summary>
        /// Defines the literal " |"
        /// </summary>
        [StringLiteral(" |")]
        public const string SpacePipe = Space + Pipe;

        /// <summary>
        /// Defines the literal '{0} -> {1}'
        /// </summary>
        [RenderPattern("{0} -> {1}")]
        public const string ArrowAxB = "{0} -> {1}";
    }

    static partial class RU
    {


    }
}