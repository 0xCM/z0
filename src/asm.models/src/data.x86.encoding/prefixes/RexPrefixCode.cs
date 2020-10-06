//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    /// <summary>
    /// Defines the rex prefix codes
    /// </summary>
    public enum RexPrefixCode : byte
    {
        /// <summary>
        /// Defines the <see cref='x40'/> prefix
        /// </summary>
        Rex40 = x40,

        /// <summary>
        /// Defines the <see cref='x41'/> prefix
        /// </summary>
        Rex41 = x41,

        /// <summary>
        /// Defines the <see cref='x42'/> prefix
        /// </summary>
        Rex42 = x42,

        /// <summary>
        /// Defines the <see cref='x43'/> prefix
        /// </summary>
        Rex43 = x43,

        /// <summary>
        /// Defines the <see cref='x44'/> prefix
        /// </summary>
        Rex44 = x44,

        /// <summary>
        /// Defines the <see cref='x45'/> prefix
        /// </summary>
        Rex45 = x45,

        /// <summary>
        /// Defines the <see cref='x46'/> prefix
        /// </summary>
        Rex46 = x46,

        /// <summary>
        /// Defines the <see cref='x47'/> prefix
        /// </summary>
        Rex47 = x47,

        /// <summary>
        /// Defines the <see cref='x48'/> prefix
        /// </summary>
        RexW = x48,

        /// <summary>
        /// Defines the <see cref='x49'/> prefix
        /// </summary>
        RexWB = x49,

        /// <summary>
        /// Defines the <see cref='x4a'/> prefix
        /// </summary>
        RexWX = x4a,

        /// <summary>
        /// Defines the <see cref='x4b'/> prefix
        /// </summary>
        RexXB = x4b,

        /// <summary>
        /// Defines the <see cref='x4c'/> prefix
        /// </summary>
        RexWR = x4c,

        /// <summary>
        /// Defines the <see cref='x4d'/> prefix
        /// </summary>
        RexWRB = x4d,

        /// <summary>
        /// Defines the <see cref='x4e'/> prefix
        /// </summary>
        RexWRX = x4e,

        /// <summary>
        /// Defines the <see cref='x4f'/> prefix
        /// </summary>
        RexWRXB = x4f,
    }
}