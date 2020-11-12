//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = RegAspectKind;

    /// <summary>
    /// Defines register aspect identifiers
    /// </summary>
    public enum RegisterAspect : byte
    {
        None = 0,

        /// <summary>
        /// Identifies the <see cref='K.Volatile'/> aspect
        /// </summary>
        Volatile,

        /// <summary>
        /// Identifies the <see cref='K.Persistent'/> aspect
        /// </summary>
        Persistent,

        /// <summary>
        /// Identifies the <see cref='K.StackPointer'/> aspect
        /// </summary>
        StackPointer,

        /// <summary>
        /// Identifies the <see cref='K.ArgSequence'/> aspect
        /// </summary>
        ArgSequence,

        /// <summary>
        /// Identifies the <see cref='K.Return'/> aspect
        /// </summary>
        Return,
    }
}