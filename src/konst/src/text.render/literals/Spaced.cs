//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    partial struct RP
    {
        /// <summary>
        /// Defines the literal ' | '
        /// </summary>
        [StringLiteral(" | ")]
        public const string SpacedPipe = Space + Pipe + Space;

        /// <summary>
        /// Defines a string consisting of 2 spaces
        /// </summary>
        [StringLiteral(Spaced2, 2)]
        public const string Spaced2 = Space + Space;

        /// <summary>
        /// Defines a string consisting of 3 spaces
        /// </summary>
        [StringLiteral(Spaced3, 3)]
        public const string Spaced3 = Spaced2 + Space;

        /// <summary>
        /// Defines a string consisting of 4 spaces
        /// </summary>
        [StringLiteral(Spaced4, 4)]
        public const string Spaced4 = Spaced3 + Space;

        /// <summary>
        /// Defines a string consisting of 5 spaces
        /// </summary>
        [StringLiteral(Spaced5, 5)]
        public const string Spaced5 = Spaced4 + Space;

        /// <summary>
        /// Defines a string consisting of 6 spaces
        /// </summary>
        [StringLiteral(Spaced6, 6)]
        public const string Spaced6 = Spaced5 + Space;

        /// <summary>
        /// Defines a string consisting of 7 spaces
        /// </summary>
        [StringLiteral(Spaced7, 7)]
        public const string Spaced7 = Spaced6 + Space;

        /// <summary>
        /// Defines a string consisting of 8 spaces
        /// </summary>
        [StringLiteral(Spaced8, 8)]
        public const string Spaced8 = Spaced7 + Space;

        /// <summary>
        /// Defines a string consisting of 9 spaces
        /// </summary>
        [StringLiteral(Spaced9, 9)]
        public const string Spaced9 = Spaced8 + Space;

        /// <summary>
        /// Defines a string consisting of 10 spaces
        /// </summary>
        [StringLiteral(Spaced10, 10)]
        public const string Spaced10 = Spaced9 + Space;

        /// <summary>
        /// Defines a string consisting of 16 spaces
        /// </summary>
        [StringLiteral(Spaced16, 16)]
        public const string Spaced16 = Spaced8 + Spaced8;

        /// <summary>
        /// Defines a string consisting of 32 spaces
        /// </summary>
        [StringLiteral(Spaced32, 32)]
        public const string Spaced32 = Spaced16 + Spaced16;

        /// <summary>
        /// Defines a string consisting of 48 spaces
        /// </summary>
        [StringLiteral(Spaced48, 48)]
        public const string Spaced48 = Spaced32 + Spaced16;

        /// <summary>
        /// Defines a string consisting of 64 spaces
        /// </summary>
        [StringLiteral(Spaced64, 64)]
        public const string Spaced64 = Spaced32 + Spaced32;

        /// <summary>
        /// Defines a string consisting of 128 spaces
        /// </summary>
        [StringLiteral(Spaced128, 128)]
        public const string Spaced128 = Spaced64 + Spaced64;

        /// <summary>
        /// Defines a string consisting of 256 spaces
        /// </summary>
        [StringLiteral(Spaced256, 256)]
        public const string Spaced256 = Spaced128 + Spaced128;

        /// <summary>
        /// Defines a string consisting of 512 spaces
        /// </summary>
        [StringLiteral(Spaced512, 512)]
        public const string Spaced512 = Spaced256 + Spaced256;
    }
}