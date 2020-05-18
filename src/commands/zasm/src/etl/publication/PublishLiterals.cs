//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;
    using static AsmDataModels;
 
    partial class AsmEtl
    {                
        static string DescribeLiteral<E>(E literal)
            where E : unmanaged, Enum
        {            
            var info = CommentAttribute.GetDocumentation(typeof(E).Field(literal.ToString()).Require());
            return info ?? string.Empty;
        }

        public Option<FilePath> PublishLiterals<E>()
            where E : unmanaged, Enum
        {
            
            var dst = Config.DatasetPath(typeof(E).Name);            
            var report = LiteralTable.Report<E>(typeof(E).Name, DescribeLiteral);
            return report.Save(dst);
        }
        
        public void PublishLiterals()
        {
            PublishLiterals<OpCodeOperandKind>().OnSome(OnPublished);
            PublishLiterals<CpuidFeature>().OnSome(OnPublished);
            PublishLiterals<EncoderFlags>().OnSome(OnPublished);
            PublishLiterals<EncodingKind>().OnSome(OnPublished);
            PublishLiterals<FlowControl>().OnSome(OnPublished);
            PublishLiterals<LegacyFlags>().OnSome(OnPublished);
            PublishLiterals<LegacyFlags3>().OnSome(OnPublished);
            PublishLiterals<LegacyOpCodeTable>().OnSome(OnPublished);
            PublishLiterals<LegacyOpKind>().OnSome(OnPublished);
            PublishLiterals<MandatoryPrefix>().OnSome(OnPublished);
            PublishLiterals<MemorySize>().OnSome(OnPublished);
            PublishLiterals<OpCodeFlags>().OnSome(OnPublished);
            PublishLiterals<OpCodeHandlerKind>().OnSome(OnPublished);

            PublishLiterals<RegisterFlags>().OnSome(OnPublished);
            PublishLiterals<RflagsBits>().OnSome(OnPublished);

        }

        void OnPublished(FilePath path)
        {
            term.print(path);
        }


    }
}