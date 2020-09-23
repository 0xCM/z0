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
        /// Defines a string consisting of 2 spaces
        /// </summary>
        [StringLiteral(Spaced2, 2)]
        public const string Spaced2 = Space + Space;

        /// <summary>
        /// Defines a string consisting of 4 spaces
        /// </summary>
        [StringLiteral(Spaced4, 4)]
        public const string Spaced4 = Spaced2 + Spaced2;

        /// <summary>
        /// Defines a string consisting of 8 spaces
        /// </summary>
        [StringLiteral(Spaced8, 8)]
        public const string Spaced8 = Spaced4 + Spaced4;

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
        /// Defines a string consisting of 64 spaces
        /// </summary>
        [StringLiteral(Spaced64, 64)]
        public const string Spaced64 = Spaced32 + Spaced32;

        /// <summary>
        /// Defines a string consisting of 64 spaces
        /// </summary>
        [StringLiteral(Spaced128, 128)]
        public const string Spaced128 = Spaced64 + Spaced64;
    }
}