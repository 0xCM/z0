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
        public static IAsmCodeIndex ToCodeIndex(this IEnumerable<AsmCode> code)
            => AsmCodeIndex.Create(code);
        
        static IEnumerable<AsmInstructionList> GetInstructions(IAsmCodeArchive archive)
        {            
            var decoder = archive.Context.Decoder();
            foreach(var codeblock in archive.Read())
                yield return decoder.DecodeInstructions(codeblock);                
        }

        public static IAsmInstructionSource ToInstructionSource(this IAsmCodeArchive archive)
            => AsmInstructionSource.FromProducer(() => GetInstructions(archive));

        public static IEnumerable<AssemblyId> ActiveAssemblies(this IAsmContext context)
        {
            var settings = AppSettings.Load("z0.control").Pairs;
            foreach(var (key,value) in settings)
            {
                var index = key.Split(text.colon());            
                if(index.Length == 2 && bit.Parse(index[1]))
                {
                    var id = Enums.parse<AssemblyId>(value);
                    if(id != AssemblyId.None)
                        yield return id;                        
                }
            }
        }

    }
    
}