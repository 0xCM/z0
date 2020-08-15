//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct AsmTables
    {
        public static EnumNames<Mnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<Mnemonic>();
        }

        static ResExtractor Extractor
            => ResExtractor.Service(typeof(Z0.Parts.AsmModels).Assembly);

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        public static AppResourceDoc structured(string match)
            => Extractor.MatcDocument(match); 
    }    
}