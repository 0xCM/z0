//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Id = ApiKeyId;

    /// <summary>
    /// Classifies binary boolean and bitwise logical operations
    /// </summary>
    public enum CanonicalApiKeyKind : ushort
    {
        None = 0,

        Reverse = Id.Reverse,

        Concat = Id.Concat,

        Identity = Id.Identity,

        Parse = Id.Parse,

        Slice = Id.Slice,

        Enable = Id.Enable,

        Disable = Id.Disable,

        Lo = Id.Lo,

        Hi = Id.Hi,

        Left = Id.Left,

        Right = Id.Right,

        Replicate = Id.Replicate,

        Split = Id.Split,

        Toggle = Id.Toggle,

        /// <summary>
        /// Classifies an operation that produces an additive monoidal identity value
        /// </summary>
        Zero = Id.Zero,

        /// <summary>
        /// Classifies an operation that produces a multiplicative monoidal identity value
        /// </summary>
        One = Id.One,

        /// <summary>
        /// Classifies an operation that evaluates one or more operands to determine that a subject is, or is not, of some target kind
        /// </summary>
        Test = Id.Test,

        Broadcast = Id.Broadcast,

        /// <summary>
        /// Pervasive truth
        /// </summary>
        Ones = Id.Ones,

        /// <summary>
        /// The unbearable nothingness of the void
        /// </summary>
        Zeroes = Id.Zeroes,

        /// <summary>
        /// Classifies an operation that implements a switch statement
        /// </summary>
        Switch = Id.Switch,

        Copy = Id.Copy,

        Zip = Id.Zip,

        Map = Id.Map,

        VZip = Id.VZip,

        VMap = Id.VMap,

    }
}