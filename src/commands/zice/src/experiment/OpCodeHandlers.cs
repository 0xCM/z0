//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: Available in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;

    public class OpCodeHandlers
    {
        static int DataLength => OpCodeData.Legacy.Length;
		
        public void ReadLegacy()
		{
			var index = 0;
            var handlers = new List<HandlerInfo>();
            var bytecount = DataLength;
            while(index < bytecount)
            {
                switch(NextDataKind(ref index))
                {
                    case DataKind.ArrayReference:
                        Array(ref index, handlers);
                        break;
                    case DataKind.HandlerReference:
                    {
                        var kind = HandlerKind(ref index);
                        var handler = Handler(kind,ref index);
                        handlers.Add(new HandlerInfo(handler));
                        break;
                    }
                }
            }
		}

        void Array(ref int index, List<HandlerInfo> dst)
        {
            var count = u32(ref index);
            dst.Add(new HandlerInfo(Handlers(ref index, (int)count)));
        }

        IIceOpCodeHandler[] Handlers(ref int index, int count)
        {
            var handlers = new IIceOpCodeHandler[count];

            for(var i=0; i<count; i++)
            {
                var kind = HandlerKind(ref index);
                var handler = Handler(kind, ref index);
                if(handler.IsNonEmpty)
                {
                    var codes = string.Join(Chars.Comma, handler.Codes.Map(x => x.ToString()));
                    var regs = string.Join(Chars.Comma, handler.Registers.Map(x => x.ToString()));
                    term.print(string.Concat(codes, Chars.Space, regs));
                }
                
                handlers[i] = handler;
            }
            return handlers;
        }

        IIceOpCodeHandler Handler(OpCodeHandlerKind kind, ref int index)
        {
            var code = OpCodeId.INVALID;
            switch(kind)
            {
			    case OpCodeHandlerKind.Ap:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1);
			    
                case OpCodeHandlerKind.C_R_3a:
                    code = OpCode(ref index);                    
                    return IceOpCodeHandler.Define(Reg(ref index), code, code + 1);

			    case OpCodeHandlerKind.Eb_1:
                    return IceOpCodeHandler.Define(OpCode(ref index));
			    
                case OpCodeHandlerKind.Eb_2:
                    return IceOpCodeHandler.Define(HandlerFlags(ref index), OpCode(ref index));

			    case OpCodeHandlerKind.BranchSimple:
                    return IceOpCodeHandler.Define(code, code + 1, code + 2);
			    
                case OpCodeHandlerKind.Mf_1:
                    return IceOpCodeHandler.Define(OpCode(ref index));

			    case OpCodeHandlerKind.AL_DX:
                    return IceOpCodeHandler.Define(OpCode(ref index));

			    case OpCodeHandlerKind.Gv_Eb:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1, code + 2);
                
                case OpCodeHandlerKind.Gv_Ev_REX:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1);
                
                case OpCodeHandlerKind.Ib:
                    return IceOpCodeHandler.Define(OpCode(ref index));                
			    
			    case OpCodeHandlerKind.Ev_REXW:
                    code = OpCode(ref index);
                    var r = Boolean(ref index);
                    var m = Boolean(ref index);
                    return RexHandler.Define(r, m, code, code + 1);
                
                case OpCodeHandlerKind.Jb:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1, code + 2);

                case OpCodeHandlerKind.Jdisp:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1);

			    case OpCodeHandlerKind.Jx:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1, OpCode(ref index));
                
                case OpCodeHandlerKind.Jz:
                    code = OpCode(ref index);
                    return IceOpCodeHandler.Define(code, code + 1, code + 2);
                
                case OpCodeHandlerKind.Jb2:
                    {
                        return IceOpCodeHandler.Define(
                            OpCode(ref index), 
                            OpCode(ref index), 
                            OpCode(ref index), 
                            OpCode(ref index), 
                            OpCode(ref index), 
                            OpCode(ref index), 
                            OpCode(ref index));
                    }
                default:
                    return IceOpCodeHandler.Empty;
            }
        }

        [MethodImpl(Inline)]
        DataKind NextDataKind(ref int index)
            => (DataKind)u8(ref index);

        [MethodImpl(Inline)]
        OpCodeHandlerKind HandlerKind(ref int index) 
            => (OpCodeHandlerKind)u8(ref index);

        [MethodImpl(Inline)]
        HandlerFlags HandlerFlags(ref int index) 
            => (HandlerFlags)u32(ref index);

        [MethodImpl(Inline)]
        OpCodeId OpCode(ref int index) 
            => (OpCodeId)u32(ref index);
        
        [MethodImpl(Inline)]
		bool Boolean(ref int idx) 
            => u8(ref idx) != 0;

        [MethodImpl(Inline)]
		Register Reg(ref int idx) 
            => (Register)u8(ref idx);

        [MethodImpl(Inline)]
        byte u8(ref int index)
        {
             if(index < DataLength)
                return skip(OpCodeData.Legacy, index++);
            else
                return 0;
        }

		uint u32(ref int index) 
        {
			var result = 0u;
			for (var shift = 0; shift < 32; shift += 7) 
            {
				uint b = u8(ref index);
				if ((b & 0x80) == 0)
					return result | (b << shift);
				result |= (b & 0x7F) << shift;
			}

            throw new InvalidOperationException();
		}

	    enum DataKind : byte 
        {
		    HandlerReference,
		    ArrayReference,
	    }

   }
}