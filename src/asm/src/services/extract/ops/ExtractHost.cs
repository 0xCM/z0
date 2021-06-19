//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial class ApiExtractor
    {
        unsafe ApiExtractBlock Extract(in ResolvedMethod src, Span<byte> buffer)
        {
            var result = extract(src.EntryPoint, buffer);
            if(result > 0)
            {
                return new ApiExtractBlock(src.EntryPoint, src.Uri.Format(), slice(buffer, 0, result));
            }
            else
            {
                Wf.Warn(Msg.TerminalNotFound.Format(src.Uri));
                return new ApiExtractBlock(src.EntryPoint, src.Uri.Format(), buffer.ToArray());
            }
        }

        [Op]
        unsafe int extract(MemoryAddress src, Span<byte> dst)
        {
            var reader = MemoryReader.create(src.Pointer<byte>(), dst.Length);
            var counter = 0;
            while(reader.Read(ref seek(dst, counter++)))
            {
                var term = terminal(slice(dst,0,counter));
                if(term.TerminalFound)
                    return counter + term.Modifier;
            }
            return NotFound;
        }

        public ApiHostExtracts ExtractHost(in ResolvedHost src)
        {
            var dst = root.list<ApiMemberExtract>();
            var flow = Wf.Running(Msg.ExtractingHost.Format(src.Host));
            var methods = src.Methods.View;
            var count = methods.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                Buffer.Clear();
                ref readonly var method = ref skip(methods,i);
                var extract = ApiExtracts.extract(method, Buffer);
                dst.Add(extract);
                counter++;
            }

            Wf.Ran(flow, Msg.ExtractedHost.Format(counter, src.Host));

            return new ApiHostExtracts(src.Host, dst.ToArray());
        }

        public uint ExtractHost(ResolvedHost src, List<ApiMemberExtract> dst)
        {
            var flow = Wf.Running(Msg.ExtractingHost.Format(src.Host));
            var methods = src.Methods.View;
            var count = methods.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                dst.Add(ApiExtracts.extract(skip(methods,i), Buffer));
                counter++;
            }
            Wf.Ran(flow, Msg.ExtractedHost.Format(counter, src.Host));
            return counter;
        }
    }
}