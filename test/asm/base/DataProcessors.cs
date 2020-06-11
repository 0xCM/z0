//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using Z0.Asm.Data;

    using static Seed;
    using static Typed;
 
    public readonly struct DataProcessors
    {
        IAsmContext Context {get;}
        
        readonly IArchives DataSource; 

        readonly CodeProcessorSink CodeSink;

        public static DataProcessors Create(IAsmContext context)
            => new DataProcessors(context);
        
        DataProcessors(IAsmContext context)
        {
            Context = context;
            DataSource = Archives.Services;            
            CodeSink = CodeProcessorSink.Create(context.Decoder);
        }

        public OpCodeRecordSets<Mnemonic> ProcessOpCodes(params PartId[] parts)
        {            
            var paths = Context.AppPaths.ForApp(PartId.Control);
            var capture = CaptureArchive(paths.AppCapturePath);
            var archive = UriBitsArchive(capture.CodeDir);

            for(var i=0; i<parts.Length; i++)
            {
                var part = parts[i];
                var data = archive.Read(part).ToArray();
                Process(data);
            }
            return CodeSink.Processed();
        }

        public void Process(UriHex[] src)
        {
            var count = src.Length;
            for(var i=0; i< count; i++)
            {
                CodeSink.Deposit(src[i]);
            }
        }

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(PartId part)
            => DataSource.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root)
            => DataSource.CaptureArchive(root, null, null);

        [MethodImpl(Inline)]
        IUriHexArchive UriBitsArchive(FolderPath root)
            => DataSource.UriBitsArchive(root);
                 

        readonly struct MnemonicParser : IParser<string,Mnemonic>
        {
            readonly Dictionary<string,Mnemonic> Index;

            [MethodImpl(Inline)]
            public static MnemonicParser Create()
                => new MnemonicParser((int)Mnemonic.LAST);

            [MethodImpl(Inline)]
            MnemonicParser(int capacity)
            {
                Index = new Dictionary<string, Mnemonic>(capacity);
                var literals = Enums.valarray<Mnemonic>();
                foreach(var l in literals)
                    Index[l.ToString().ToLower()] = l;
            }

            public ParseResult<string, Mnemonic> Parse(string src)
            {
                if(Index.TryGetValue(src.Trim().ToLower(), out var mne))
                    return ParseResult.Success<string,Mnemonic>(src,mne);
                else
                    return ParseResult.Fail<string,Mnemonic>(src);
            }
            
        }                 
        readonly struct CodeProcessorSink : IDataSink<UriCode>, IDataSink<UriHex>
        {
            readonly Dictionary<Mnemonic, ArrayBuilder<CommandInfo>> Index;
            
            readonly int[] Sequence;

            readonly uint[] Offset;


            int NextSequence
            {
                [MethodImpl(Inline)]
                get => Sequence[0]++;
            }
            
            Address32 NextOffset
            {
                [MethodImpl(Inline)]
                get => Offset[0]++;
            }

            readonly IAsmFunctionDecoder Decoder;

            readonly MnemonicParser MnemonicParse;

            readonly AsmStatementParser StatementParse;

            public static CodeProcessorSink Create(IAsmFunctionDecoder decoder)
                => new CodeProcessorSink(decoder);    

            [MethodImpl(Inline)]
            CodeProcessorSink(IAsmFunctionDecoder decoder)
            {
                Decoder = decoder;
                Index = new Dictionary<Mnemonic, ArrayBuilder<CommandInfo>>();
                
                Sequence = new int[1];
                Offset = new uint[1];
                MnemonicParse = MnemonicParser.Create();
                StatementParse = AsmStatementParser.Create(MnemonicParse);
            }


            [MethodImpl(Inline)]
            public void Deposit(in UriHex src)
            {
                var decoded = Decoder.Decode(src);
                if(decoded)
                    Process(src.Encoded, decoded.Value);
            }

            [MethodImpl(Inline)]
            public void Deposit(in UriCode src)
            {
                var decoded = Decoder.Decode(src.Encoded);
                if(decoded)
                    Process(src.Encoded, decoded.Value);
            }

            public OpCodeRecordSets<Mnemonic> Processed()
            {
                var keys = Index.Keys.ToArray();
                var count = keys.Length;
                var sets = new OpCodeRecordSet<Mnemonic>[count];
                for(var i=0; i<count; i++)
                {
                    var key = keys[i];
                    sets[i] = OpCodeRecords.Set(key, Index[key].Create());
                }
                return OpCodeRecords.Sets(sets);
            }

            [MethodImpl(Inline)]
            void Process(in BinaryCode code, in AsmInstructions asm)
            {
                var bytes = code.Bytes;
                ushort offset = 0;
                for(var i=0; i<asm.Count; i++)   
                { 
                    var instruction = asm[i];
                    var size = (ushort)instruction.ByteLength;
                    var encoded = bytes.Slice(offset, size);
                    Process(Address16.From(offset), encoded, asm[i]);
                    offset += size;
                }
            }

            [MethodImpl(Inline)]
            void Process(in LocatedCode code, in AsmInstructionList asm)
            {
                var bytes = code.Bytes;

                ushort offset = 0;

                for(var i=0; i<asm.Count; i++)    
                {
                    var instruction = asm[i];
                    var size = (ushort)instruction.ByteLength;
                    var encoded = bytes.Slice(offset, size);
                    Process(Address16.From(offset) ,encoded, asm[i]);
                    offset += size;
                }
            }


            static BinaryCode ToBinaryCode(ReadOnlySpan<byte> src)
            {
                var length = src.Length;
                for(var i= length - 1; i>=0; i--)
                {
                    ref readonly var x = ref Control.skip(src,i);
                    if(x != 0)
                        return new BinaryCode(src.Slice(0,length).ToArray());
                }
                return BinaryCode.Empty;
            }
            
            ParseResult<AsmStatement> ParseStatement(string src)
                => StatementParse.Parse(src);

            [MethodImpl(Inline)]
            static ReadOnlySpan<char> Render(CpuidFeature src)
            {
                
                return src.ToString();
            }

            static asci16 Render(ReadOnlySpan<CpuidFeature> src)
            {
                var count = src.Length;
                var dst = default(Vector128<byte>);
                for(var i=0; i<count; i++)
                {
                    var item = Render(Control.skip(src,i));
                    var length = item.Length;
                }
                
                return new asci16(dst);
            }
            
            void Process(Address16 localOffset, ReadOnlySpan<byte> encoded, in Instruction asm)
            {
                var mnemonic = asm.Mnemonic;
                if(mnemonic != 0)
                {
                    var record = new CommandInfo(
                        Seq: NextSequence,
                        LocalOffset: localOffset,
                        GlobalOffset: NextOffset,
                        Mnemonic: mnemonic.ToString().ToUpper(),
                        OpCode: asm.InstructionCode.OpCode.Replace("o32 ", string.Empty),
                        Encoded: ToBinaryCode(encoded),
                        InstructionFormat: asm.FormattedInstruction,
                        InstructionCode: asm.InstructionCode.Expression,
                        CpuId: text.embrace(asm.CpuidFeatures.Select(x => x.ToString()).Concat(",")),
                        Id: (OpCodeId)asm.Code 
                        );
                    
                    if(Index.TryGetValue(mnemonic, out var builder))
                        builder.Include(record);
                    else
                        Index.Add(mnemonic, ArrayBuilder.Create(record));
                }
            }            
        }
    }    
}