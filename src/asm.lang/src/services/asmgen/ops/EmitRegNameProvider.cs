//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static CsPatterns;

    partial class AsmModelGen
    {
        public void EmitRegNameProvider()
            => EmitRegNameProvider(GetTargetPath(AsmGenTarget.RegNameFactories));

        public void EmitRegNameProvider(FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var buffer = TextTools.buffer();
            var margin = 0u;
            buffer.IndentLine(margin, AsmNamespaceDecl());
            buffer.IndentLine(margin, Open());
            var count = EmitRegNameProvider(margin + 4, buffer);
            buffer.IndentLine(margin, Close());
            using var writer = dst.Writer();
            writer.WriteLine(buffer.Emit());
            Wf.EmittedFile(flow,count);
        }

        public uint EmitRegNameProvider(uint margin, ITextBuffer dst)
        {
            var name = TargetIdentifier(AsmGenTarget.RegNameFactories);
            dst.IndentLine(margin, PublicReadonlyStruct(name));
            dst.IndentLine(margin, Open());
            margin +=4;
            var counter = 0u;
            var types = AsmCodes.RegCodeTypes().ToReadOnlySpan();
            for(var i=0; i<types.Length; i++)
            {
                ref readonly var type = ref skip(types,i);
                var adapted = ClrEnumAdapter.adapt(type);
                counter += EmitSymFactories(margin, adapted,dst);

            }
            margin -=4;
            dst.IndentLine(margin, Close());
            return counter;
        }
    }
}