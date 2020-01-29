//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using AsmSpecs;

    using static zfunc;

    public static partial class AsmExtend
    {
 
        public static IAsmCodeIndex ToCodeIndex(this IEnumerable<AsmCode> code, bool generic)
            => AsmCodeIndex.Create(code,generic);

        static IEnumerable<AsmInstructionList> GetInstructions(IAsmCodeArchive archive)
        {
            
            var decoder = archive.Context.Decoder();
            foreach(var file in archive.Files)
            foreach(var codeblock in archive.Read(file))
                yield return decoder.DecodeInstructions(codeblock);                
        }

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive)
            => AsmInstructionSource.FromProducer(() => GetInstructions(archive));
    }
}