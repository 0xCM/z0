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

        /// <summary>
        /// Defines the literal '{0}{1}'
        /// </summary>
        [RenderPattern(2, Adjacent2)]
        public const string Adjacent2 = "{0}{1}";

        /// <summary>
        /// Defines the literal '{0}{1}{2}'
        /// </summary>
        [RenderPattern(3, Adjacent3)]
        public const string Adjacent3 = "{0}{1}{2}";

        /// <summary>
        /// Defines the literal '{0}{1}{2}{3}'
        /// </summary>
        [RenderPattern(4, Adjacent4)]
        public const string Adjacent4 = "{0}{1}{2}{3}";
    }

    static partial class RU
    {


    }
}