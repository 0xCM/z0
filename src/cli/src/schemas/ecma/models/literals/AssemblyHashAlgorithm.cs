// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0.Schemas.Ecma
{
    /// <summary>
    /// Specifies all the hash algorithms used for hashing assembly files and for generating the strong name.
    /// </summary>
    public enum AssemblyHashAlgorithm : uint
    {
        /// <summary>
        /// A mask indicating that there is no hash algorithm. If you specify None for a multi-module assembly, the common language runtime defaults to the SHA1 algorithm, since multi-module assemblies need to generate a hash.
        /// </summary>
        None = 0,

        /// <summary>
        /// Retrieves the MD5 message-digest algorithm. MD5 was developed by Rivest in 1991. It is basically MD4 with safety-belts and while it is slightly slower than MD4, it helps provide more security. The algorithm consists of four distinct rounds, which has a slightly different design from that of MD4. Message-digest size, as well as padding requirements, remain the same.
        /// </summary>
        MD5 = 0x8003,

        /// <summary>
        /// Retrieves a revision of the Secure Hash Algorithm that corrects an unpublished flaw in SHA.
        /// </summary>
        Sha1 = 0x8004,

        /// <summary>
        /// Retrieves a version of the Secure Hash Algorithm with a hash size of 256 bits.
        /// </summary>
        Sha256 = 0x800c,

        /// <summary>
        /// Retrieves a version of the Secure Hash Algorithm with a hash size of 384 bits.
        /// </summary>
        Sha384 = 0x800d,

        /// <summary>
        /// Retrieves a version of the Secure Hash Algorithm with a hash size of 512 bits.
        /// </summary>
        Sha512 = 0x800e
    }
}