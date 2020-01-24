//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
 	using Iced.Intel;

    using static zfunc;

    public class AsmDecoder : IAsmDecoder
    {
        internal static IAsmDecoder Create(ClrMetadataIndex index = null, int? bufferlen = null)
            => new AsmDecoder(index,bufferlen);

        byte[] _Buffer;

        Option<ClrMetadataIndex> ClrMetadata;

        AsmDecoder(ClrMetadataIndex index, int? bufferlen)
        {
            this.ClrMetadata = index;
            this._Buffer = new byte[bufferlen ?? 4*1024];
        }

        AsmFormatConfig FormatConfig {get;}
            = AsmFormatConfig.Default;

        public AsmFunction Decode(Moniker id, MethodInfo src)
            => function(NativeReader.read(id, src, TakeBuffer()), ClrMetadata.ValueOrDefault());

        public AsmFunction Decode(NativeMemberCapture src)
            => Decode(src.Id, src.Method);

        public AsmFunction Decode(Moniker id, DynamicDelegate src)
            => function(id, src, TakeBuffer(), ClrMetadata.ValueOrDefault());

        /// <summary>
        /// Decodes an instruction list
        /// </summary>
        /// <param name="src">The code source</param>
        public AsmSpecs.AsmInstructionList DecodeList(AsmCode src)
        {
            var decoded = list(src);
            var dst = new AsmSpecs.Instruction[decoded.Count];
            var formatted = AsmSpecFormatter.CaptureBaseFormat(decoded,src.Origin.Start, FormatConfig.Invert());
            for(var i=0; i<dst.Length; i++)
                dst[i] = decoded[i].ToSpec(formatted[i]);
            return AsmSpecs.AsmInstructionList.Create(dst);
        }

        /// <summary>
        /// Decodes a function from a native capture
        /// </summary>
        /// <param name="src">The cource capture</param>
        public AsmSpecs.AsmFunction DecodeFunction(NativeMemberCapture src)
        {
            var list = DecodeList(src.Code);
            var block = AsmSpecs.AsmInstructionBlock.Define(src.Code, list, src.CaptureInfo.TermCode);
            var cil = ClrMetadata.MapValueOrDefault(idx => idx.FindCilFunction(src.Method).ValueOrDefault());
            return AsmServices.FunctionBuilder().BuildFunction(block).WithCil(cil);            
        }

        /// <summary>
        /// Decodes a function from a method
        /// </summary>
        /// <param name="src">The cource capture</param>
        public AsmSpecs.AsmFunction DecodeFunction(Moniker id, MethodInfo src)
            => DecodeFunction(NativeReader.read(id, src, TakeBuffer()));

        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="id">The identity to confer</param>
        /// <param name="src">The source delegate</param>
        public AsmSpecs.AsmFunction DecodeDelegate(Moniker id, DynamicDelegate src)
            => DecodeDelegate(id, src, TakeBuffer());

        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        /// <param name="id">The identity to confer</param>
        /// <param name="id">The target buffer</param>
        AsmSpecs.AsmFunction DecodeDelegate(Moniker id, DynamicDelegate src, byte[] dst)
            => DecodeFunction(NativeReader.read(id, src, dst));

        byte[] TakeBuffer()
        {
            _Buffer.Clear();
            return _Buffer;
        }

        /// <summary>
        /// Decodes an assembly function from native member data
        /// </summary>
        /// <param name="src">The source data</param>
        static AsmFunction function(NativeMemberCapture src, ClrMetadataIndex index)
		{
            var block = instructions(src.Code, src.CaptureInfo.TermCode);
            var cil = index?.FindCilFunction(src.Method).ValueOrDefault();            
            return AsmServices.FunctionBuilder().BuildFunction(block).WithCil(cil);
		}

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="src">The native source data</param>
        public static AsmFunction function(NativeMemberCapture src)
            => function(src,null);
            
        /// <summary>
        /// Decodes an assembly function from a dynamic delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        public static AsmFunction function(Moniker id, DynamicDelegate src, byte[] dst, ClrMetadataIndex index = null)
            => function(NativeReader.read(id, src, dst), index);

        /// <summary>
        /// Decodes an instruction list from native code
        /// </summary>
        /// <param name="src">The native code</param>
        static InstructionList list(AsmCode src)
        {
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Encoded);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
            decoder.IP = src.Origin.Start;
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction); 
			}
            return dst;            
        }

        /// <summary>
        /// Decodes an instruction block
        /// </summary>
        /// <param name="src">The encoded source</param>
        /// <param name="origin">The memory range from which the code was extracted</param>
        static InstructionBlock instructions(AsmCode src, CaptureTermCode tc)
            => InstructionBlock.Define(src, tc, list(src));
    }
}