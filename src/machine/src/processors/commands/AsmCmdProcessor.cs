//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using Z0.Asm.Data;

    using static Konst;
    using static Root;

    public readonly struct AsmCmdProcessor
    {                
        readonly Dictionary<Mnemonic, ArrayBuilder<CommandInfo>> Index;

        TArchives DataSource 
            => Archives.Services;            

        readonly int[] Sequence;

        readonly uint[] Offset;

        readonly IAsmContext Context;

        readonly MnemonicParser MnemonicParse;

        IAsmFunctionDecoder Decoder
            => Context.Decoder;

        [MethodImpl(Inline)]
        TCaptureArchive CaptureArchive(FolderPath root)
            => DataSource.CaptureArchive(root, null, null);

        [MethodImpl(Inline)]
        IEncodedHexArchive UriBitsArchive(FolderPath root)
            => DataSource.EncodedHexArchive(root);

        [MethodImpl(Inline)]
        TCaptureArchive CaptureArchive(PartId part)
            => DataSource.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));
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

        [MethodImpl(Inline)]
        public static AsmCmdProcessor Service(IAsmContext context) 
            => new AsmCmdProcessor(context);

        [MethodImpl(Inline)]
        internal AsmCmdProcessor(IAsmContext context)
        {
            Context = context;
            MnemonicParse = MnemonicParser.Create();
            Index = new Dictionary<Mnemonic, ArrayBuilder<CommandInfo>>();
            Sequence = sys.alloc<int>(1);
            Offset = sys.alloc<uint>(1);
        }

        public CommandRecordSets<Mnemonic> Process(params PartId[] parts)
        {
            var pfs = PartFiles.Service(Context);
            var files = PartFiles.Service(Context).ParseFiles(parts);
            var parser = ParseReportParser.Service;
            var processor = this;

            for(var i=0; i<parts.Length; i++)
            {
                var part = parts[i];
                if(files.TryGetValue(part, out var partFiles))
                {
                    for(var j= 0; j<partFiles.Length; j++)
                    {
                        var path = partFiles[j].Path;
                        var records = parser.ParseRecords(path);
                        if(records)
                            processor.Process(records.Value);
                    }                    
                }       
            }   
            return Processed();
        }
 
        CommandRecordSets<Mnemonic> ProcessOpCodes(params PartId[] parts)
        {            
            var paths = Context.AppPaths.ForApp(PartId.Control);
            var capture = CaptureArchive(paths.AppCaptureRoot);
            var archive = UriBitsArchive(capture.CodeDir);

            for(var i=0; i<parts.Length; i++)
            {
                var part = parts[i];
                var data = archive.Read(part).ToArray();
                Process(data);
            }
            return Processed();
        }

        void Process(IdentifiedCode[] src)
        {
            var count = src.Length;
            for(var i=0; i< count; i++)
                Process(src[i]);
        }

        [MethodImpl(Inline)]
        void Process(in IdentifiedCode src)
        {
            var decoded = Decoder.Decode(src);
            if(decoded)
                Process(src.Encoded, decoded.Value);
        }

        [MethodImpl(Inline)]
        void Process(in MemberCode src)
        {
            var decoded = Decoder.Decode(src.Encoded);
            if(decoded)
                Process(src.Encoded, decoded.Value);
        }

        void Process(MemberParseRecord[] records)
        {
            var src = records.ToReadOnlySpan();
            for(var i=0; i<src.Length; i++)
                Process(skip(src,i));
        }

        void Process(in MemberParseRecord src)
        {
            var instructions = Decoder.Decode(src.Data);
            if(instructions)
                Process(src.Data, instructions.Value);
        }

        CommandRecordSets<Mnemonic> Processed()
        {
            var keys = Index.Keys.ToArray();
            var count = keys.Length;
            var sets = new CommandRecordSet<Mnemonic>[count];
            for(var i=0; i<count; i++)
            {
                var key = keys[i];
                sets[i] = CommandRecords.Set(key, Index[key].Create());
            }
            return CommandRecords.Sets(sets);
        }
               
        void Process(in LocatedCode code, in AsmInstructionList asm)
        {
            var data = code.Data;
            var bytes = data.ToReadOnlySpan();
            var instructions = asm.Data;
            Process(code.Encoded, instructions);
        }

        void Process(in BinaryCode code, Instruction[] asm)        
        {
            var bytes = Root.span(code.Data);
            
            ushort offset = 0;

            for(var i=0; i<asm.Length; i++)    
            {
                ref readonly var instruction = ref asm[i];
                
                var size = (ushort)instruction.ByteLength;
                var encoded = bytes.Slice(offset, size);
                
                var a16 = new Address16(offset);
                Process(a16, encoded, instruction);
                offset += size;
            }
        }

        [MethodImpl(Inline)]
        
        void Process(Address16 localOffset, Span<byte> encoded, in Instruction asm)
        {
            var mnemonic = asm.Mnemonic;

            if(mnemonic != 0)
            {
                var record = new CommandInfo(
                    Sequence: NextSequence,
                    Address: asm.IP,
                    LocalOffset: localOffset,
                    GlobalOffset: NextOffset,
                    Mnemonic: mnemonic.ToString().ToUpper(),
                    OpCode: asm.InstructionCode.OpCode.Replace("o32 ", string.Empty),
                    Encoded: new BinaryCode(encoded.TrimEnd().ToArray()),
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