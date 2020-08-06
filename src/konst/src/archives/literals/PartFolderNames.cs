//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    [LiteralProvider]
    public readonly struct PartFolderNames
    {
        /// <summary>
        /// An archive partition for files emitted during test execution
        /// </summary>
        public const string test = nameof(test);

        /// <summary>
        /// An archive partition for reference data
        /// </summary>
        public const string data = nameof(data);

        /// <summary>
        /// An archive partition for application-specific data
        /// </summary>
        public const string apps = nameof(apps);

        /// <summary>
        /// An archive partition for application logs
        /// </summary>
        public const string logs = nameof(logs);

        /// <summary>
        /// Raw/unparsed binary extracts
        /// </summary>
        public const string extracted = nameof(extracted);

        /// <summary>
        /// Parsed binary extracts
        /// </summary>
        public const string parsed = nameof(parsed);

        /// <summary>
        /// Formatted x86 assembly
        /// </summary>
        public const string asm = nameof(asm);

        /// <summary>
        /// Hex formatted encoded x86 assembly
        /// </summary>
        public const string hex = nameof(hex);
    }
}