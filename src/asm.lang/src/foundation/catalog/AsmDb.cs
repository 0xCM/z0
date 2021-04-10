//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmDbSourceDocs;

    public class AsmDb : WfService<AsmDb>
    {
        public AsmDbSourceDocs SourceDocs()
        {
            var assets = Assets.create();
            if(Resources.document(assets.AsmDbInstructions(), TextDocFormat.Structured(), out var instructions)
            && (Resources.document(assets.AsmDbOperands(), TextDocFormat.Structured(), out var operands)))
                return new AsmDbSourceDocs(instructions,operands);
            else
                return AsmDbSourceDocs.Empty;
        }

        public void ShowSourceDocs()
        {
            var asmdb = Wf.AsmDb();
            var docs = asmdb.SourceDocs();
            if(docs.IsNonEmpty)
            {
                var pattern = RP.slots(Chars.Pipe, -8, -32, -8, -32, -32);
                using var log = ShowLog(FS.Csv);
                var instructions = docs.Instructions;
                var count = instructions.RowCount;
                var rows = instructions.Rows;
                for(var i=0; i<count; i++)
                {
                    ref readonly var row = ref skip(rows,i);
                    var index = row.Cell(InstructionField.Index);
                    var monic = row.Cell(InstructionField.Mnemonic);
                    var arch = row.Cell(InstructionField.Arch);
                    var opcode = row.Cell(InstructionField.OpCode);
                    var sig = row.Cell(InstructionField.Sig);
                    var description = string.Format(pattern, index, monic, arch, sig, opcode);
                    log.Show(description);

                }
            }
        }

        static ReadOnlySpan<string> OpCodeRules => new string[]
        {
            "",
        };

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
            Index = 0,

            /// <summary>
            /// The instruction mnemonic
            /// </summary>
            Mnemonic,

            /// <summary>
            /// The instruction form
            /// </summary>
            Sig,

            /// <summary>
            ///
            /// </summary>
            Arch,

            /// <summary>
            ///
            /// </summary>
            OpCode,

            /// <summary>
            ///
            /// </summary>
            Encoding,

            /// <summary>
            /// The instruction prefix
            /// </summary>
            Prefix,

            /// <summary>
            /// The primaryh opcode byte
            /// </summary>
            OpCodeByte,

            /// <summary>
            /// Opcode L field, one of {128, 256, 512}, if any
            /// </summary>
            L,

            /// <summary>
            /// Opcode w field
            /// </summary>
            W,

            /// <summary>
            /// Opcode pp segment
            /// </summary>
            PP,

            /// <summary>
            ///
            /// </summary>
            MM,

            /// <summary>
            /// Indicates whether the instruction requires a size override prefix
            /// </summary>
            x67,

            /// <summary>
            /// Instruction specific payload in ModRM byte (R part), one of {/0, /1, /2, /3, /4, /5, /6, /7}, if any
            /// </summary>
            ModR,

            /// <summary>
            /// Instruction specific payload in ModRM byte (RM part), specified as another opcode byte.
            /// </summary>
            ModRM,

            /// <summary>
            /// AVX VSIB register type (xmm/ymm/zmm).
            /// </summary>
            VsibReg,

            /// <summary>
            /// AVX VSIB register size (32/64).
            /// </summary>
            VsibSize,

            /// <summary>
            /// AVX-512 merging {k}.
            /// </summary>
            KMask,

            /// <summary>
            /// AVX-512 zeroing {kz}, implies {k}.
            /// </summary>
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