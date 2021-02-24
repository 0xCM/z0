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

    [ApiHost]
    public unsafe sealed class CaptureAlt : WfService<CaptureAlt>
    {
        IAsmContext Asm;

        protected override void OnInit()
        {
            base.OnInit();
            Asm = AsmServices.context(Wf);
        }
        public CaptureAlt()
        {

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

        [Op]
        CapturedOperation capture(Span<byte> dst, OpIdentity id, MemoryAddress src)
        {
            var result = CaptureDiviner.divine(dst, id, src.Pointer<byte>());
            return new CapturedOperation(id, result.Outcome, result.Code);
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

        [MethodImpl(Inline), Op]
        ApiCaptureBlock block(OpIdentity id, MethodInfo src, CapturedCodeBlock bits, ExtractTermCode term)
            => new ApiCaptureBlock(id, src, bits.Input, bits.Output, term);
    }
}