//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    public readonly partial struct MsReg
    {
        
        [StructLayout(LayoutKind.Explicit)]
        public struct XmmSaveArea
        {
            public const int HeaderSize = 2;
            public const int LegacySize = 8;

            [FieldOffset(0x0)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HeaderSize)]
            public M128A[] Header;

            [FieldOffset(0x20)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = LegacySize)]
            public M128A[] Legacy;

            [FieldOffset(0xa0)]
            public M128A Xmm0;

            [FieldOffset(0xb0)]
            public M128A Xmm1;

            [FieldOffset(0xc0)]
            public M128A Xmm2;

            [FieldOffset(0xd0)]
            public M128A Xmm3;
            
            [FieldOffset(0xe0)]
            public M128A Xmm4;
            
            [FieldOffset(0xf0)]
            public M128A Xmm5;
            
            [FieldOffset(0x100)]
            public M128A Xmm6;
            
            [FieldOffset(0x110)]
            public M128A Xmm7;
            
            [FieldOffset(0x120)]
            public M128A Xmm8;
            
            [FieldOffset(0x130)]
            public M128A Xmm9;
            
            [FieldOffset(0x140)]
            public M128A Xmm10;
            
            [FieldOffset(0x150)]
            public M128A Xmm11;
            
            [FieldOffset(0x160)]
            public M128A Xmm12;
            [FieldOffset(0x170)]
            public M128A Xmm13;
            [FieldOffset(0x180)]
            public M128A Xmm14;
            [FieldOffset(0x190)]
            public M128A Xmm15;
        }        
        
        [Flags]
        public enum RegisterType : byte
        {
            General             = 0x01,
            Control             = 0x02,
            Segments            = 0x03,
            FloatingPoint       = 0x04,
            Debug               = 0x05,
            TypeMask            = 0x0f,

            ProgramCounter      = 0x10,
            StackPointer        = 0x20,
            FramePointer        = 0x40,
        }        

        /// <summary>
        /// Float in X86-specific windows thread context.
        /// </summary>
        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public struct Float80
        {
            [FieldOffset(0x0)]
            public ulong Mantissa;

            [FieldOffset(0x8)]
            public ushort Exponent;
        }
                
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
        public class RegisterAttribute : Attribute
        {
            /// <summary>
            /// Gets or sets optional name override
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets register type and flags
            /// </summary>
            public RegisterType RegisterType { get; }

            public RegisterAttribute(RegisterType registerType)
            {
                RegisterType = registerType;
            }
        }

        /// <summary>
        /// X86-specific windows thread context.
        /// </summary>
        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        public struct X86Context
        {
            public const uint Context = 0x00100000;
            public const uint ContextControl = Context | 0x1;
            public const uint ContextInteger = Context | 0x2;
            public const uint ContextSegments = Context | 0x4;
            public const uint ContextFloatingPoint = Context | 0x8;
            public const uint ContextDebugRegisters = Context | 0x10;

            public static int Size => Marshal.SizeOf(typeof(X86Context));

            // Control flags

            [FieldOffset(0x0)]
            public uint ContextFlags;

            #region Debug registers

            [Register(RegisterType.Debug)]
            [FieldOffset(0x4)]
            public uint Dr0;

            [Register(RegisterType.Debug)]
            [FieldOffset(0x8)]
            public uint Dr1;

            [Register(RegisterType.Debug)]
            [FieldOffset(0xc)]
            public uint Dr2;

            [Register(RegisterType.Debug)]
            [FieldOffset(0x10)]
            public uint Dr3;

            [Register(RegisterType.Debug)]
            [FieldOffset(0x14)]
            public uint Dr6;

            [Register(RegisterType.Debug)]
            [FieldOffset(0x18)]
            public uint Dr7;

            #endregion

            #region Floating point registers

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x1c)]
            public uint ControlWord;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x20)]
            public uint StatusWord;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x24)]
            public uint TagWord;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x28)]
            public uint ErrorOffset;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x2c)]
            public uint ErrorSelector;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x30)]
            public uint DataOffset;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x34)]
            public uint DataSelector;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x38)]
            public Float80 ST0;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x42)]
            public Float80 ST1;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x4c)]
            public Float80 ST2;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x56)]
            public Float80 ST3;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x60)]
            public Float80 ST4;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x6a)]
            public Float80 ST5;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x74)]
            public Float80 ST6;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x7e)]
            public Float80 ST7;

            [Register(RegisterType.FloatingPoint)]
            [FieldOffset(0x88)]
            public uint Cr0NpxState;

            #endregion

            #region Segment Registers

            [Register(RegisterType.Segments)]
            [FieldOffset(0x8c)]
            public uint Gs;

            [Register(RegisterType.Segments)]
            [FieldOffset(0x90)]
            public uint Fs;

            [Register(RegisterType.Segments)]
            [FieldOffset(0x94)]
            public uint Es;

            [Register(RegisterType.Segments)]
            [FieldOffset(0x98)]
            public uint Ds;

            #endregion

            #region Integer registers

            [Register(RegisterType.General)]
            [FieldOffset(0x9c)]
            public uint Edi;

            [Register(RegisterType.General)]
            [FieldOffset(0xa0)]
            public uint Esi;

            [Register(RegisterType.General)]
            [FieldOffset(0xa4)]
            public uint Ebx;

            [Register(RegisterType.General)]
            [FieldOffset(0xa8)]
            public uint Edx;

            [Register(RegisterType.General)]
            [FieldOffset(0xac)]
            public uint Ecx;

            [Register(RegisterType.General)]
            [FieldOffset(0xb0)]
            public uint Eax;

            #endregion

            #region Control registers

            [Register(RegisterType.Control | RegisterType.FramePointer)]
            [FieldOffset(0xb4)]
            public uint Ebp;

            [Register(RegisterType.Control | RegisterType.ProgramCounter)]
            [FieldOffset(0xb8)]
            public uint Eip;

            [Register(RegisterType.Segments)]
            [FieldOffset(0xbc)]
            public uint Cs;

            [Register(RegisterType.General)]
            [FieldOffset(0xc0)]
            public uint EFlags;

            [Register(RegisterType.Control | RegisterType.StackPointer)]
            [FieldOffset(0xc4)]
            public uint Esp;

            [Register(RegisterType.Segments)]
            [FieldOffset(0xc8)]
            public uint Ss;

            #endregion

            [FieldOffset(0xcc)]
            public unsafe fixed byte ExtendedRegisters[512];
        }       
    }
}