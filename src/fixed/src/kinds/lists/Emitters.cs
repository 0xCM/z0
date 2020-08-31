//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    partial class FixedOpKinds
    {
        /// <summary>
        /// Specifies a fixed emitter that produces 8-bit values
        /// </summary>
        public static FixedOpKind<W8,FixedCell8,Emitter8> Emitter8 => default;

        /// <summary>
        /// Specifies a fixed emitter that produces 16-bit values
        /// </summary>
        public static FixedOpKind<W16,FixedCell16,Emitter16> Emitter16 => default;

        /// <summary>
        /// Specifies a fixed emitter that produces 32-bit values
        /// </summary>
        public static FixedOpKind<W32,Fixed32,Emitter32> Emitter32 => default;

        /// <summary>
        /// Specifies a fixed emitter that produces 64-bit values
        /// </summary>
        public static FixedOpKind<W64,FixedCell64,Emitter64> Emitter64 => default;

        /// <summary>
        /// Specifies a fixed emitter that produces 128-bit values
        /// </summary>
        public static FixedOpKind<W128,FixedCell128,Emitter128> Emitter128 => default;

        /// <summary>
        /// Specifies a fixed emitter that produces 256-bit values
        /// </summary>
        public static FixedOpKind<W256,FixedCell256,Emitter256> Emitter256 => default;

        /// <summary>
        /// Specifies a fixed emitter that produces 512-bit values
        /// </summary>
        public static FixedOpKind<W512,FixedCell512,Emitter512> Emitter512 => default;

    }
}
