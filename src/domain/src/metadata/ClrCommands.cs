//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;
    using static ClrCommands;

    public readonly partial struct ClrCommands
    {
        public static ref ClrCmdSpec encode(in EmitAssemblyReferences src, out ClrCmdSpec dst)
        {
            const byte count = 3;
            Span<uint> sizes = stackalloc uint[count];
            seek(sizes,0) = z.size<ClrCmdKey>();
            seek(sizes,1) = text.size(Utf8Encoding, src.Source.PathData);
            seek(sizes,2) = text.size(Utf8Encoding, src.Target.PathData);
            var k = skip(sizes,0) + skip(sizes,1) + skip(sizes,2);
            var buffer = alloc<byte>(k);
            var _buffer = span(buffer);
            seek(_buffer,0) = (byte)src.CmdId;
            TextEncoders.encode(Utf8Encoding, src.Source.PathData, slice(_buffer, skip(sizes,1)));
            TextEncoders.encode(Utf8Encoding, src.Target.PathData, slice(_buffer, skip(sizes,2)));
            dst = new ClrCmdSpec(src.CmdId, buffer);
            return ref dst;
        }


        public static void decode(in ClrCmdSpec src, ref EmitAssemblyReferences dst)
        {
            dst = default;
        }
    }


    public sealed class ClrCmdExec : CmdExec<ClrCmdExec, ClrCmdSpec, ClrCmdResult>
    {

        void Execute(in EmitAssemblyReferences cmd)
        {

        }

        protected override ClrCmdResult Execute(IWfShell wf, ClrCmdSpec spec)
        {
            switch(spec.CmdId)
            {
                case ClrCmdKey.EmitAssemblyReferences:
                break;
            }
            return ClrCmdResult.Empty;
        }
    }
}
