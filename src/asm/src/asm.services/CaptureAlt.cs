//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static memory;
    using static ExtractTermCode;

    [ApiHost]
    unsafe readonly struct CaptureAlt : ICaptureAlt
    {
        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        [MethodImpl(Inline)]
        public CaptureAlt(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        public ApiCaptureBlocks Capture(Type src)
            => Capture(src.DeclaredMethods());

        public ApiCaptureBlocks Capture(ReadOnlySpan<MethodInfo> src)
            => capture(src.Map(m =>  new IdentifiedMethod(m.Identify(),m)));

        public ApiCaptureBlocks CaptureHost(in ApiHostCatalog src)
            => capture(src);

        public ApiCaptureBlocks CaptureMethods(ReadOnlySpan<IdentifiedMethod> src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        public ApiCaptureBlock Capture(MethodInfo src, OpIdentity id, Span<byte> buffer)
            => capture(src,id,buffer);

        public ApiCaptureBlock Capture(MethodInfo src, Span<byte> dst)
            => capture(src, dst);

        public ApiCaptureBlock Capture(IdentifiedMethod src)
            => capture(src);

        public ApiCaptureBlocks Capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
            => capture(src, buffer);

        public ApiMemberCapture Capture(in ApiMember src, Span<byte> dst)
            => capture(src, dst);

        public ApiCaptureBlock Capture(LocatedMethod src, Span<byte> dst)
            => capture(src, dst);

        public ApiCaptureBlock Capture(IdentifiedMethod src, Span<byte> dst)
            => capture(src, dst);

        ApiCaptureBlocks capture(ReadOnlySpan<IdentifiedMethod> src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        [Op]
        ApiCaptureBlocks capture(in ApiHostCatalog src)
        {
            var members = src.Members.View;
            var count = members.Length;
            var blocks = sys.alloc<ApiCaptureBlock>(count);
            ref var b = ref first(blocks);
            var buffer = sys.alloc<byte>(Pow2.T14);
            for(var i=0; i<count; i++)
            {
                ref readonly var member = ref skip(members, i);
                var address = member.BaseAddress;
                var id = member.Id;
                var summary = capture(buffer, id, address);
                var outcome = summary.Outcome;
                seek(b,i) = block(id, member.Method, summary.Encoded, outcome.TermCode);
            }
            return blocks;
        }

        /// <summary>
        /// Captures a concrete method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="id">The identity to confer to the captured result</param>
        /// <param name="dst">The target buffer</param>
        [Op]
        ApiCaptureBlock capture(MethodInfo src, OpIdentity id, Span<byte> dst)
        {
            var summary = capture(dst, id, ApiJit.jit(src));
            var outcome = summary.Outcome;
            return block(id, src, summary.Encoded, outcome.TermCode);
        }

        [Op]
        ApiCaptureBlock capture(MethodInfo src, Span<byte> dst)
        {
            var id = src.Identify();
            var summary = capture(dst, id, ApiJit.jit(src));
            var outcome = summary.Outcome;
            return block(id, src, summary.Encoded, outcome.TermCode);
        }

        [Op]
        ApiCaptureBlocks capture(ReadOnlySpan<IdentifiedMethod> src, Span<byte> buffer)
        {
            var located = locate(src);
            var count = located.Length;
            var captured = alloc<ApiCaptureBlock>(count);
            ref var dst = ref first(captured);
            for(var i=0u; i<count; i++)
            {
                ref readonly var method = ref skip(located, i);
                try
                {
                    var summary = capture(buffer, method.Id, method.Address);
                    var outcome = summary.Outcome;
                    seek(dst, i) = block(method.Id, method.Method, summary.Encoded, outcome.TermCode);
                }
                catch(Exception e)
                {
                    term.errlabel(e, method.Method.Name);
                }
            }
            return captured;
        }

        [Op]
        ApiMemberCapture capture(in ApiMember src, Span<byte> buffer)
        {
            var summary = capture(buffer, src.Id, ApiJit.jit(src));
            var size = summary.Data.Length;
            var code = new ApiCaptureBlock(src.Id, src.Method, summary.Encoded.Input, summary.Encoded.Output, summary.Outcome.TermCode);
            return new ApiMemberCapture(src, code);
        }

        [Op]
        ApiCaptureBlock capture(LocatedMethod located, Span<byte> buffer)
        {
            var summary = capture(buffer, located.Id, located.Address);
            return block(located.Id, located.Method, summary.Encoded, summary.Outcome.TermCode);
        }

        [Op]
        ApiCaptureBlock capture(IdentifiedMethod src, Span<byte> buffer)
        {
            var located = ApiJit.jit(src);
            var summary = capture(buffer, src.Id, located.Address);
            return block(located.Id, located.Method, summary.Encoded, summary.Outcome.TermCode);
        }

        [Op]
        ApiCaptureBlock capture(IdentifiedMethod src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        [MethodImpl(Inline), Op]
        ApiCaptureBlock block(OpIdentity id, MethodInfo src, CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src, bits.Input, bits.Output, term);

        [MethodImpl(Inline), Op]
        CapturedOperation capture(Span<byte> dst, OpIdentity id, MemoryAddress src)
            => capture(src.Pointer<byte>(), id, dst);

        [MethodImpl(Inline), Op]
        CapturedOperation capture(byte* pSrc, OpIdentity id, Span<byte> dst)
        {
            var limit = dst.Length - 1;
            var start = (MemoryAddress)pSrc;
            var offset = 0;
            int? ret_offset = null;
            var end = (MemoryAddress)pSrc;
            var state = ExtractState.Empty;

            while(offset < limit)
            {
                var code = *pSrc++;
                seek(dst, offset++) = code;
                end = pSrc;
                state = new ExtractState(code);

                if(ret_offset == null && state.Captured == RET)
                    ret_offset = offset;

                var tc = CalcTerm(dst, offset, ret_offset, out var delta);
                if(tc != 0)
                    return complete(dst, id, tc, start, end, delta);
            }
            return complete(dst, id, CTC_BUFFER_OUT, start, end, 0);
        }

        CapturedOperation complete(Span<byte> buffer, OpIdentity id, ExtractTermCode tc, MemoryAddress start, MemoryAddress end, int delta)
        {
            var outcome = new CaptureOutcome((start, (ulong)(end + delta)), tc);
            var raw = buffer.Slice(0, (int)(end - start)).ToArray();
            var trimmed = buffer.Slice(0, outcome.ByteCount).ToArray();
            var bits = new CapturedCodeBlock(start, raw, trimmed);
            return new CapturedOperation(id, outcome, bits);
        }


        [Op]
        ExtractTermCode CalcTerm(Span<byte> buffer, int offset, int? ret_offset, out int delta)
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
        ExtractTermCode Scan4(Span<byte> buffer, int offset, out int delta)
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
        ExtractTermCode Scan5(Span<byte> buffer, int offset, out int delta)
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
        bool match(ReadOnlySpan<byte> src, int index, byte test)
            => skip(src,index) == test;

        [MethodImpl(Inline), Op]
        bool Zx7(ReadOnlySpan<byte> buffer, int offset)
        {
            var result = true;
            ref readonly var x = ref first(buffer);
            result &= sub(x,0) == ZED;
            result &= sub(x,1) == ZED;
            result &= sub(x,2) == ZED;
            result &= sub(x,3) == ZED;
            result &= sub(x,4) == ZED;
            result &= sub(x,5) == ZED;
            result &= sub(x,6) == ZED;
            return result;
        }

        Span<LocatedMethod> locate(ReadOnlySpan<IdentifiedMethod> src)
        {
            var count = src.Length;
            var buffer = alloc<LocatedMethod>(count);
            ref var located = ref first(span(buffer));
            for(var i=0u; i<count; i++)
                seek(located, i) = ApiJit.jit(skip(src, i));
            Array.Sort(buffer);
            return buffer;
        }
    }
}