//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using IF = AsmDbSourceDocs.InstructionField;

    public class AsmDbCatalog : AppService<AsmDbCatalog>
    {
        public AsmDbSourceDocs SourceDocs()
        {
            var assets = AsmData.Assets;
            if(TextDocs.resource(assets.AsmDbInstructions(), TextDocFormat.Structured(), out var instructions)
            && (TextDocs.resource(assets.AsmDbOperands(), TextDocFormat.Structured(), out var operands)))
                return new AsmDbSourceDocs(instructions,operands);
            else
                return AsmDbSourceDocs.Empty;
        }

        public void ShowSourceDocs()
        {
            var asmdb = Wf.AsmDbCatalog();
            var docs = asmdb.SourceDocs();
            if(docs.IsNonEmpty)
            {
                var pattern = RP.slots(Chars.Pipe, -8, -32, -8, -8, -32, -32, -8, -8);
                using var log = ShowLog(FS.Csv);
                var instructions = docs.Instructions;
                var count = instructions.RowCount;
                var rows = instructions.Rows;
                for(var i=0; i<count; i++)
                {
                    ref readonly var row = ref skip(rows,i);
                    var entry = new AsmDbEntry();
                    var index = row.Cell(IF.Index);
                    var monic = row.Cell(IF.Mnemonic);
                    var ocb = row.Cell(IF.OpCodeByte);
                    var arch = row.Cell(IF.Arch);
                    var opcode = row.Cell(IF.OpCode);
                    var sig = ConformSig(row.Cell(IF.Sig));
                    var encrule = row.Cell(IF.Encoding);
                    var prefix = row.Cell(IF.Prefix);
                    var w = row.Cell(IF.W);
                    var l = row.Cell(IF.L);
                    var pp = row.Cell(IF.PP);
                    var mm = row.Cell(IF.MM);
                    var x67 = row.Cell(IF.x67);
                    var modr = row.Cell(IF.ModR);
                    var modrm = row.Cell(IF.ModRM);

                    //DataParser.parse(index, out entry.Index);
                    //entry.Mnemonic = asm.mnemonic(monic);
                    //entry.X64 = SupportsX64(arch);
                    //if(DataParser.parse(ocb, out byte _ocb))
                    //    entry.OpCodeByte = _ocb;
                    //AsmParser.sig(sig, out entry.Sig);

                    var summary = string.Format(pattern, index, monic, ocb, arch, sig, opcode, encrule, prefix);
                    log.Show(summary);
                }
            }
        }

        static bool SupportsX64(string src)
            => src == "ANY" || src == "X64";

        static string ConformSig(string src)
        {
            return src.Replace("/ub", EmptyString);
        }

        static string ConformOpCode(string src)
        {
            return src;
        }
    }

    public ref struct AsmDbEntry
    {
        public ReadOnlySpan<byte> Index;

        public ReadOnlySpan<byte> Mnemonic;

        public ReadOnlySpan<byte> X64;

        public ReadOnlySpan<byte> OpCodeByte;

        public ReadOnlySpan<byte> Sig;
    }

    public readonly struct AsmDbSourceDocs
    {
        public static string conform(InstructionField field, string value)
            => field switch {
                InstructionField.OpCode => value.Replace("ib/ub", "ib"),
                _ => value
            };

        public enum InstructionField : byte
        {
            /// <summary>
            ///
            /// </summary>
            [Symbol("Index","A 0-based monotonic surrogate key")]
            Index = 0,

            [Symbol("Mnemonic","The instruction mnemonic")]
            Mnemonic,

            [Symbol("Sig","The instruction form expression")]
            Sig,

            [Symbol("Arch","The architectures supported by the instruction; one of:ANY,X86,X64")]
            Arch,

            [Symbol("","The opcode expression")]
            OpCode,

            [Symbol("","The encoding type code")]
            Encoding,

            [Symbol("","The instruction prefix")]
            Prefix,

            [Symbol("","The primaryh opcode byte")]
            OpCodeByte,

            [Symbol("","Opcode L field, one of {128, 256, 512}, if any")]
            L,

            [Symbol("","Opcode w field")]
            W,

            [Symbol("","Opcode pp segment")]
            PP,

            [Symbol("","")]
            MM,

            [Symbol("","Indicates whether the instruction requires a size override prefix")]
            x67,

            [Symbol("","Instruction specific payload in ModRM byte (R part), one of {/0, /1, /2, /3, /4, /5, /6, /7}, if any")]
            ModR,

            [Symbol("","Instruction specific payload in ModRM byte (RM part), specified as another opcode byte")]
            ModRM,

            [Symbol("","AVX VSIB register type (xmm/ymm/zmm)")]
            VsibReg,

            [Symbol("","AVX VSIB register size (32/64).")]
            VsibSize,

            [Symbol("","AVX-512 merging {k}")]
            KMask,

            [Symbol("","AVX-512 zeroing {kz}, implies {k}")]
            ZMask,
        }

/*
    this.name = name;
    this.privilege = "L3";     // Privilege level required to execute the instruction.
    this.prefix = "";          // Prefix - "", "3DNOW", "EVEX", "VEX", "XOP".
    this.opcodeHex = "";       // A single opcode byte as hexadecimal string "00-FF".

    this.l = "";               // Opcode L field (nothing, 128, 256, 512).
    this.w = "";               // Opcode W field.
    this.pp = "";              // Opcode PP part.
    this.mm = "";              // Opcode MM[MMM] part.
    this._67h = false;         // Instruction requires a size override prefix.

    this.modR = "";            // Instruction specific payload in ModRM byte (R part), specified as "/0..7".
    this.modRM = "";           // Instruction specific payload in ModRM byte (RM part), specified as another opcode byte.
    this.ri = false;           // Instruction opcode is combined with register, "XX+r" or "XX+i".
    this.rel = 0;              // Displacement ("cb", "cw", and "cd" parts).

    this.fpu = false;          // If the instruction is an FPU instruction.
    this.fpuTop = 0;           // FPU top index manipulation [-1, 0, 1, 2].

    this.vsibReg = "";         // AVX VSIB register type (xmm/ymm/zmm).
    this.vsibSize = -1;        // AVX VSIB register size (32/64).

    this.broadcast = false;    // AVX-512 broadcast support.
    this.bcstSize = -1;        // AVX-512 broadcast size.

    this.kmask = false;        // AVX-512 merging {k}.
    this.zmask = false;        // AVX-512 zeroing {kz}, implies {k}.
    this.er = false;           // AVX-512 embedded rounding {er}, implies {sae}.
    this.sae = false;          // AVX-512 suppress all exceptions {sae} support.

    this.tupleType = "";       // AVX-512 tuple-type.
    this.elementSize = -1;     // Instruction's element size.

*/

        public enum OperandField : byte
        {
            Index,

            Operand,

            Instruction,

            Sig,

            OpCode,

            Type,

            Data,

            Reg,

            Mem,

            MemSize,

            MemSeg,

            MemOff,

            MemFar,

            Imm,

            RwxIndex,

            RwxWidth
        }

        public TextDoc Instructions {get;}

        public TextDoc Operands {get;}

        public AsmDbSourceDocs(TextDoc instructions, TextDoc operands)
        {
            Instructions = instructions;
            Operands = operands;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Instructions.IsEmpty || Operands.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Instructions.IsNonEmpty || Operands.IsNonEmpty;
        }

        public static AsmDbSourceDocs Empty
        {
            get => new AsmDbSourceDocs(TextDoc.Empty, TextDoc.Empty);
        }
    }
}