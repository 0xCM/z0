//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RP
    {
        /// <summary>
        /// Defines the literal " |"
        /// </summary>
        [RenderLiteral(" |")]
        public const string SpacePipe = Space + Pipe;

        /// <summary>
        /// Defines a string consisting of 2 spaces
        /// </summary>
        [RenderLiteral(Spaced2, 2)]
        public const string Spaced2 = Space + Space;

        /// <summary>
        /// Defines a string consisting of 3 spaces
        /// </summary>
        [RenderLiteral(Spaced3, 3)]
        public const string Spaced3 = Spaced2 + Space;

        /// <summary>
        /// Defines a string consisting of 4 spaces
        /// </summary>
        [RenderLiteral(Spaced4, 4)]
        public const string Spaced4 = Spaced3 + Space;

        /// <summary>
        /// Defines a string consisting of 5 spaces
        /// </summary>
        [RenderLiteral(Spaced5, 5)]
        public const string Spaced5 = Spaced4 + Space;

        /// <summary>
        /// Defines a string consisting of 6 spaces
        /// </summary>
        [RenderLiteral(Spaced6, 6)]
        public const string Spaced6 = Spaced5 + Space;

        /// <summary>
        /// Defines a string consisting of 7 spaces
        /// </summary>
        [RenderLiteral(Spaced7, 7)]
        public const string Spaced7 = Spaced6 + Space;

        /// <summary>
        /// Defines a string consisting of 8 spaces
        /// </summary>
        [RenderLiteral(Spaced8, 8)]
        public const string Spaced8 = Spaced7 + Space;

        /// <summary>
        /// Defines a string consisting of 9 spaces
        /// </summary>
        [RenderLiteral(Spaced9, 9)]
        public const string Spaced9 = Spaced8 + Space;

        /// <summary>
        /// Defines a string consisting of 10 spaces
        /// </summary>
        [RenderLiteral(Spaced10, 10)]
        public const string Spaced10 = Spaced9 + Space;

        /// <summary>
        /// Defines a string consisting of 11 spaces
        /// </summary>
        [RenderLiteral(Spaced11, 11)]
        public const string Spaced11 = Spaced10 + Space;

        /// <summary>
        /// Defines a string consisting of 12 spaces
        /// </summary>
        [RenderLiteral(Spaced12, 12)]
        public const string Spaced12 = Spaced11 + Space;

        /// <summary>
        /// Defines a string consisting of 13 spaces
        /// </summary>
        [RenderLiteral(Spaced13, 13)]
        public const string Spaced13 = Spaced12 + Space;

        /// <summary>
        /// Defines a string consisting of 14 spaces
        /// </summary>
        [RenderLiteral(Spaced14, 14)]
        public const string Spaced14 = Spaced13 + Space;

        /// <summary>
        /// Defines a string consisting of 15 spaces
        /// </summary>
        [RenderLiteral(Spaced15, 15)]
        public const string Spaced15 = Spaced14 + Space;

        /// <summary>
        /// Defines a string consisting of 16 spaces
        /// </summary>
        [RenderLiteral(Spaced16, 16)]
        public const string Spaced16 = Spaced8 + Spaced8;

        /// <summary>
        /// Defines a string consisting of 32 spaces
        /// </summary>
        [RenderLiteral(Spaced32, 32)]
        public const string Spaced32 = Spaced16 + Spaced16;

        /// <summary>
        /// Defines a string consisting of 48 spaces
        /// </summary>
        [RenderLiteral(Spaced48, 48)]
        public const string Spaced48 = Spaced32 + Spaced16;

        /// <summary>
        /// Defines a string consisting of 64 spaces
        /// </summary>
        [RenderLiteral(Spaced64, 64)]
        public const string Spaced64 = Spaced32 + Spaced32;

        /// <summary>
        /// Defines a string consisting of 128 spaces
        /// </summary>
        [RenderLiteral(Spaced128, 128)]
        public const string Spaced128 = Spaced64 + Spaced64;

        /// <summary>
        /// Defines a string consisting of 256 spaces
        /// </summary>
        [RenderLiteral(Spaced256, 256)]
        public const string Spaced256 = Spaced128 + Spaced128;

        /// <summary>
        /// Defines a string consisting of 512 spaces
        /// </summary>
        [RenderLiteral(Spaced512, 512)]
        public const string Spaced512 = Spaced256 + Spaced256;
    }
}