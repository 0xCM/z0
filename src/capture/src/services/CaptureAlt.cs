//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ExtractTermCode;

    [ApiHost]
    public readonly unsafe struct CaptureAlt
    {
        [Op]
        public static ReadOnlySpan<IdentifiedMethod> identify(ReadOnlySpan<MethodInfo> src)
            => src.Map(m =>  new IdentifiedMethod(m.Identify(), m));

        [Op]
        public static Span<LocatedMethod> locate(ReadOnlySpan<IdentifiedMethod> src)
        {
            var count = src.Length;
            var buffer = alloc<LocatedMethod>(count);
            ref var located = ref first(span(buffer));

            for(var i=0u; i<count; i++)
                seek(located, i) = ApiDynamic.jit(skip(src,i));
            Array.Sort(buffer);

            return buffer;
        }

        [Op]
        public static ReadOnlySpan<ApiCaptureBlock> capture(ReadOnlySpan<MethodInfo> src)
            => capture(src.Map(m =>  new IdentifiedMethod(m.Identify(),m)));

        [Op]
        public static ReadOnlySpan<ApiCaptureBlock> capture(Type src)
            => capture(src.DeclaredMethods());

        [Op]
        public static ReadOnlySpan<ApiCaptureBlock> capture(ReadOnlySpan<IdentifiedMethod> src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        /// <summary>
        /// Captures a concrete method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="id">The identity to confer to the captured result</param>
        /// <param name="buffer">The target buffer</param>
        [Op]
        public static ApiCaptureBlock capture(MethodInfo src, OpIdentity id, Span<byte> buffer)
        {
            var summary = capture(buffer, id, ApiMemberJit.jit(src));
            var outcome = summary.Outcome;
            return block(id, src, summary.Encoded, outcome.TermCode);
        }

        /// <summary>
        /// Captures a concrete method for the truly lazy programmer
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="id">The identity to confer to the captured result, if specified</param>
        /// <param name="buffersize">The target buffer size to allocate,</param>
        [Op]
        public static ApiCaptureBlock capture(MethodInfo src, OpIdentity? id = null, uint buffersize = Pow2.T14)
        {
            var _id = id ?? OpIdentity.define(src.MetadataToken.ToString());
            var summary = capture(alloc<byte>(buffersize), _id, ApiMemberJit.jit(src));
            var outcome = summary.Outcome;
            return block(_id, src, summary.Encoded, outcome.TermCode);
        }

        [Op]
        public static ReadOnlySpan<ApiCaptureBlock> capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
        {
            var located = locate(src);
            var count = located.Length;
            var captured = span<ApiCaptureBlock>(count);

            for(var i=0u; i<count; i++)
            {
                ref readonly var method = ref skip(located, i);
                try
                {
                    var summary = capture(buffer, method.Id, method.Address);
                    var outcome = summary.Outcome;
                    seek(captured,i) = block(method.Id, method.Method, summary.Encoded, outcome.TermCode);
                }
                catch(Exception e)
                {
                    term.errlabel(e, method.Method.Name);
                }
            }
            return captured;
        }

        [Op]
        public static ApiMemberCapture capture(in ApiMember src, Span<byte> buffer)
        {
            var summary = capture(buffer, src.Id, ApiDynamic.jit(src));
            var size = summary.Data.Length;
            var code = new ApiCaptureBlock(src.Id, src.Method, summary.Encoded.Input, summary.Encoded.Output, summary.Outcome.TermCode);
            return new ApiMemberCapture(src, code);
        }

        [Op]
        public static ApiCaptureBlock capture(LocatedMethod located, Span<byte> buffer)
        {
            var summary = capture(buffer, located.Id, located.Address);
            return block(located.Id, located.Method, summary.Encoded, summary.Outcome.TermCode);
        }

        [Op]
        public static ApiCaptureBlock capture(IdentifiedMethod src, Span<byte> buffer)
        {
            var located = ApiDynamic.jit(src);
            var summary = capture(buffer, src.Id, located.Address);
            return block(located.Id, located.Method, summary.Encoded, summary.Outcome.TermCode);
        }

        [Op]
        public static ApiCaptureBlock capture(IdentifiedMethod src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        [MethodImpl(Inline), Op]
        static ApiCaptureBlock block(OpIdentity id, MethodInfo src, Z0.CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src, bits.Input, bits.Output, term);

        [MethodImpl(Inline), Op]
        static CapturedOperation capture(Span<byte> buffer, OpIdentity id, MemoryAddress src)
            => capture(buffer, id, src.Pointer<byte>());

        [MethodImpl(Inline), Op]
        static CapturedOperation capture(Span<byte> buffer, OpIdentity id, byte* pSrc)
        {
            var limit = buffer.Length - 1;
            var start = (MemoryAddress)pSrc;
            var offset = 0;
            int? ret_offset = null;
            var end = (MemoryAddress)pSrc;
            var state = default(ExtractState);

            while(offset < limit)
            {
                state = Step(buffer, id, ref offset, ref end, ref pSrc);

                if(ret_offset == null && state.Captured == RET)
                    ret_offset = offset;

                var tc = CalcTerm(buffer, offset, ret_offset, out var delta);
                if(tc != 0)
                    return SummarizeParse(buffer, state, id, tc, start, end, delta);
            }
            return SummarizeParse(buffer, state, id, CTC_BUFFER_OUT, start, end, 0);
        }

        [MethodImpl(Inline)]
        static ExtractState Step(Span<byte> buffer, OpIdentity id, ref int offset, ref MemoryAddress location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            buffer[offset++] = code;
            location = pSrc;
            return new ExtractState((uint)offset, location, code);
        }

        [MethodImpl(Inline)]
        static CaptureOutcome Complete(in ExtractState state, ExtractTermCode tc, MemoryAddress start, MemoryAddress end, int delta)
            => new CaptureOutcome(state, (start, (ulong)(end + delta)), tc);

        static CapturedOperation SummarizeParse(Span<byte> buffer, in ExtractState state, OpIdentity id, ExtractTermCode tc, MemoryAddress start, MemoryAddress end, int delta)
        {
            var outcome = Complete(state, tc, start, end, delta);
            var raw = buffer.Slice(0, (int)(end - start)).ToArray();
            var trimmed = buffer.Slice(0, outcome.ByteCount).ToArray();
            var bits = new Z0.CapturedCodeBlock(start, raw, trimmed);
            return new CapturedOperation(id, outcome, bits);
        }

        [Op]
        static ExtractTermCode CalcTerm(in Span<byte> buffer, int offset, int? ret_offset, out int delta)
        {
            delta = 0;

            if(offset >= 4)
            {
                var tc = Scan4(buffer, offset, out delta);
                if(tc != 0)
                    return tc;
            }

            if(offset >= 5)
            {
                var tc = Scan5(buffer, offset, out delta);
                if(tc != 0)
                    return tc;
            }

            if(offset >= 7 && Zx7(buffer, offset))
            {
                if(ret_offset == null)
                {
                    delta = -6;
                    return CTC_Zx7;
                }
                delta = -(offset - ret_offset.Value);
                return CTC_RET_Zx7;
            }

            return 0;
        }

        const byte ZED = 0;

        const byte RET = 0xc3;

        const byte INTR = 0xcc;

        const byte SBB = 0x19;

        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;

        [MethodImpl(Inline), Op]
        static ExtractTermCode Scan4(Span<byte> buffer, int offset, out int delta)
        {
            var result = true;
            delta = -2;

            ref readonly var x0 = ref skip(buffer, offset - 3);
            ref readonly var x1 = ref skip(buffer, offset - 2);
            ref readonly var x2 = ref skip(buffer, offset - 1);
            ref readonly var x3 = ref skip(buffer, offset - 0);

            if(x0 == RET && x1 == SBB)
                return CTC_RET_SBB;
            else if(x0 == RET && x1 == INTR)
                return CTC_RET_INTR;
            else if(x0 == RET && x1 == ZED && x2 == SBB)
                return CTC_RET_ZED_SBB;
            else if(x0 == RET && x1 == ZED && x2 == ZED)
                return CTC_RET_Zx3;
            else if(x0 == INTR && x1 == INTR)
                return CTC_INTRx2;
            else
                return 0;

        }

        [MethodImpl(Inline), Op]
        static ExtractTermCode Scan5(Span<byte> buffer, int offset, out int delta)
        {
            var result = true;
            delta = 0;

            result = result &= match(buffer, offset - 5, ZED);
            result = result &= match(buffer, offset - 4, ZED);
            result = result &= match(buffer, offset - 3, J48);
            result = result &= match(buffer, offset - 2, FF);
            result = result &= match(buffer, offset - 1, E0);

            return result ? CTC_JMP_RAX : default;
        }

        [MethodImpl(Inline), Op]
        static bool match(ReadOnlySpan<byte> src, int index, byte test)
            => skip(src,index) == test;

        [MethodImpl(Inline), Op]
        static bool Zx7(ReadOnlySpan<byte> buffer, int offset)
        {
            var result = true;
            ref readonly var x = ref first(buffer);
            result &= regress(x,0) == ZED;
            result &= regress(x,1) == ZED;
            result &= regress(x,2) == ZED;
            result &= regress(x,3) == ZED;
            result &= regress(x,4) == ZED;
            result &= regress(x,5) == ZED;
            result &= regress(x,6) == ZED;
            return result;
        }
    }
}