//-----------------------------------------------------------------------------
// OpCode data Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IOpCodeHandler : INullaryKnown
    {
        OpCodeId[] Codes {get;}

        Register[] Registers {get;}

    }

    readonly struct RexHandler : IOpCodeHandler
    {
        [MethodImpl(Inline)]
        public static RexHandler Define(bool allowReg, bool allowMem, Register[] registers, params OpCodeId[] codes)
            => new RexHandler(codes,registers, allowReg, allowMem);

        [MethodImpl(Inline)]
        public static RexHandler Define(bool allowReg, bool allowMem, params OpCodeId[] codes)
            => new RexHandler(codes,Control.array<Register>(), allowReg, allowMem);

        public readonly bool AllowReg;
        
        public readonly bool AllowMem;
        
        public OpCodeId[] Codes {get;}

        public Register[] Registers {get;}

        [MethodImpl(Inline)]
        public RexHandler(OpCodeId[] code, Register[] registers, bool allowReg, bool allowMem)
        {
            Codes = code;
            Registers = registers;
            AllowReg = allowReg;
            AllowMem = allowMem;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Codes == null || Codes.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

    readonly struct OpCodeHandler : IOpCodeHandler
    {
        public static OpCodeHandler Empty => new OpCodeHandler(Control.array<OpCodeId>());

        public OpCodeId[] Codes {get;}

        public Register[] Registers {get;}

        public readonly HandlerFlags Flags;

        [MethodImpl(Inline)]
        public static OpCodeHandler Define(params OpCodeId[] codes)
            => new OpCodeHandler(codes);

        [MethodImpl(Inline)]
        public static OpCodeHandler Define(HandlerFlags flags, params OpCodeId[] codes)
            => new OpCodeHandler(codes, flags);

        [MethodImpl(Inline)]
        public static OpCodeHandler Define(Register r, params OpCodeId[] codes)
            => new OpCodeHandler(codes, Control.array(r));

        [MethodImpl(Inline)]
        public OpCodeHandler(OpCodeId[] code, HandlerFlags flags = default)
        {
            Codes = code;
            Registers = Control.array<Register>();
            Flags = flags;
        }

        [MethodImpl(Inline)]
        public OpCodeHandler(OpCodeId[] code, Register[] registers, HandlerFlags flags = default)
        {
            Codes = code;
            Registers = registers;
            Flags = flags;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Codes == null || Codes.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

	readonly struct HandlerInfo 
    {
		public readonly IOpCodeHandler Handler;
		
        public readonly IOpCodeHandler[] Handlers;

		public HandlerInfo(IOpCodeHandler handler) 
        {
			Handler = handler;
			Handlers = Control.array<IOpCodeHandler>();
		}

		public HandlerInfo(IOpCodeHandler[] handlers) 
        {
			Handler = OpCodeHandler.Empty;
			Handlers = handlers;
		}
	}
}