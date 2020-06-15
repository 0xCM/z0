//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    public interface IAsmLiteralPublisher
    {
        void Publish();
    }
    
    public readonly struct AsmLiteralPublisher : IAsmLiteralPublisher, IAsmArchiveConfig
    {
        public static IAsmLiteralPublisher Service => default;
                
        public void Publish()
        {
            var publisher = AsmRecordPublisher.Service;

            publisher.PublishLiterals<OpCodeOperandKind>().OnSome(OnPublished);
            publisher.PublishLiterals<CpuidFeature>().OnSome(OnPublished);
            publisher.PublishLiterals<EncoderFlags>().OnSome(OnPublished);
            publisher.PublishLiterals<EncodingKind>().OnSome(OnPublished);
            publisher.PublishLiterals<FlowControl>().OnSome(OnPublished);
            publisher.PublishLiterals<LegacyFlags>().OnSome(OnPublished);
            publisher.PublishLiterals<LegacyFlags3>().OnSome(OnPublished);
            publisher.PublishLiterals<LegacyOpCodeTable>().OnSome(OnPublished);
            publisher.PublishLiterals<LegacyOpKind>().OnSome(OnPublished);
            publisher.PublishLiterals<MandatoryPrefix>().OnSome(OnPublished);
            publisher.PublishLiterals<MemorySize>().OnSome(OnPublished);
            publisher.PublishLiterals<OpCodeFlags>().OnSome(OnPublished);
            publisher.PublishLiterals<RegisterFlags>().OnSome(OnPublished);
            publisher.PublishLiterals<RflagsBits>().OnSome(OnPublished);
        }

        void OnPublished(FilePath path)
        {
            term.print(path);
        }
    }
}