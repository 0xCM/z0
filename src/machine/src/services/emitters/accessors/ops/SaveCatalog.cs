//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static AddressRecord;
    using static z;

    public struct AddressRecord
    {
        public const string Col0 = "Addresses";
        
        public const string Col1 = "Accessor";                
    
        public const ushort Col0Width = 16;
        
        public const ushort Col1Width = 180;    
    }
    
    partial struct AccessorCapture
    {
        public void SaveCatalog(ReadOnlySpan<CapturedAccessor> src, FilePath csvdst)
        {
            const ulong Cut = 0x55005500550;            
            const string Sep = SpacePipe;
            const string StartMsgTemplate = "Emitting resbytes disassembly catalog to:";

            var startMsg = text.format(StartMsgTemplate, csvdst.Name);
            term.magenta(startMsg);

            var capcount = src.Length;
            using var writer = csvdst.Writer();
            writer.WriteLine(text.concat(Col0.PadRight(Col0Width), Sep, Col1));
            
            for(var i=0u; i<capcount; i++)
            {
                ref readonly var captured = ref skip(src, i);                

                var code = captured.Code;
                var host = captured.Host;
                var accessor = captured.Accessor;
                var uri = OpUri.hex(host, accessor.Member.Name, captured.Code.Code.Id);
                
                var moves = AsmAnalyzer.moves(code.Function);                
                var movecount = moves.Length;                
                for(var j=0u; j<movecount; j++)
                {
                    ref readonly var move = ref skip(moves,j);

                    if(move.Src < Cut)
                        writer.WriteLine(text.concat(move.Src.ToAddress().Format().PadRight(Col0Width), Sep, uri));
                }
            } 

            term.magenta($"Emitted resbytes disassembly catalog");
        }
    }
}