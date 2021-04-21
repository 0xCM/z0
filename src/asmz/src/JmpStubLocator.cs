//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using Z0.Tooling;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;
    using static Toolsets;

    [Record(TableId)]
    public struct JmpStub : IRecord<JmpStub>
    {
        public const string TableId = "jmp.stub";

        public OpIdentity Method;

        public MemoryAddress StubAddress;

        public MemoryAddress TargetAddress;

        public AsmHexCode StubCode;

        public Address32 Displacement;

        public Address32 Offset;
    }

    public class JmpStubLocator : WfService<JmpStubLocator>
    {

        unsafe ReadOnlySpan<JmpStub> JmpStubs()
        {
            var source = typeof(Prototypes.Calc64);
            var host = source.HostUri();
            var methods = source.DeclaredMethods();
            var count = methods.Length;
            var entries = alloc<MemoryAddress>(count);
            var located = span<JmpStub>(count);
            ApiJit.jit(methods, entries);
            var j=0;
            for(var i=0; i< count; i++)
            {
                var encoded = Cells.alloc(w64).Bytes;
                ref readonly var method = ref skip(methods,i);
                ref readonly var entry = ref skip(entries,i);

                ref var data = ref entry.Ref<byte>();
                ByteReader.read5(data, encoded);
                if(JmpRel32.test(encoded))
                {
                    var target = JmpRel32.target(entry, encoded);
                    ref var info = ref seek(located,j++);
                    info.Method = method.Identify();
                    info.StubAddress = entry;
                    info.TargetAddress = target;
                    info.StubCode =  AsmBytes.hexcode(slice(encoded,0,5));
                    info.Displacement = JmpRel32.dx(encoded);
                    info.Offset = JmpRel32.offset(entry,entry,encoded);
                }
            }

            return slice(located,0,j);
        }

        void ShowInterfaceMaps()
        {
            var calc8 = Clr.imap(typeof(Prototypes.Calc8), typeof(Prototypes.ICalc8));
            var calc64 = Clr.imap(typeof(Prototypes.Calc64), typeof(Prototypes.ICalc64));
            using var log = ShowLog("imap",FS.Log);
            log.Show(calc8.Format());
            log.Show(calc64.Format());
        }

        void CaptureParts(params PartId[] parts)
        {
            var dst = Db.AppLogDir() + FS.folder("capture");
            dst.Clear();
            Wf.CaptureRunner().Capture(parts, dst);
        }

        public ReadOnlySpan<JmpStub> FindJmpStubs()
        {
            CaptureParts(PartId.AsmCases);
            ShowInterfaceMaps();
            var stubs = JmpStubs();
            using var log = ShowLog("jumptargets",FS.Csv);
            Tables.emit(stubs,log.Buffer);
            log.ShowBuffer();
            return stubs;

        }

    }
}