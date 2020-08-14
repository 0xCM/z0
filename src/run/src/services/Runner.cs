//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Linq;
    using System.Text;

    using Z0.Asm;

    using static Konst;
    using static z;

    ref struct Runner 
    {
        readonly WfState State;   

        readonly Span<string> Buffer;     

        IWfContext Wf => State.Wf;
        
        CorrelationToken Ct;

        WfActor Actor;

        byte offset;

        [MethodImpl(Inline)]
        public Runner(WfState wf)
        {
            Ct = wf.Ct;
            Actor = Flow.actor(nameof(Runner));
            State = wf;
            Buffer = z.span<string>(256);
            offset = 0;
        }

        void RunCalc()
        {
            CalcDemo.compute();
         
            var pos = offset;
            CalcDemo.run(Buffer, ref offset);
            for(var i=pos; i<offset; i++)
                term.print(Buffer[i]);
           
        }
        

        public void Dispose()
        {

        }


        void Status<T>(T message)
        {
            Wf.Status(Actor, message, Ct);

        }
        
        static void format(ValueType src, StringBuilder dst)
        {
            var type = src.GetType();
            var fields = Table.fields(src.GetType()).View;
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                var v = skip(fields,i).Definition.Value(src).ValueOrDefault();
                dst.Append("| ");

                if(type.IsPrimitive)
                    dst.Append(src.ToString());
                else if(v is ITextual t)
                    dst.Append(t.Format());
                else if(v is ValueType x)
                    format(x, dst);                
                else if(v != null)
                    dst.Append(v.ToString());                
            }           
        }

        static void format(object src, StringBuilder dst)
        {
            if(src == null)
                return;

            var type = src.GetType();
            var fields = Table.fields(type).View;
            var count = fields.Length;
            for(var i=0; i<count; i++)
            {
                var v = skip(fields,i).Definition.Value(src).ValueOrDefault();
                dst.Append("| ");
             
                if(type.IsPrimitive)
                    dst.Append(src.ToString());
                else if(v is ITextual t)
                    dst.Append(t.Format());
                else if(v is ValueType x)
                    format(x, dst);                
                else if(v != null)
                    dst.Append(v.ToString());                
            }

        }

        static string format<T>(in T src)
            where T : struct
        {
            var dst = text.build();
            format(src, dst);
            return dst.ToString();
        }
        
        void ReadRes()
        {
            using var map = MemoryFile.open(Wf.ResPack.Name);
            var @base = map.BaseAddress;
            var sig = map.Read(@base, 2).AsUInt16();
            var magic = Z0.Image.PeLiterals.Magical;
            var info = map.Description;
            Status(format(info));
        }


        void ListCaptureFiles()
        {
            var paths = AppBase.paths();
            var files = AppFilePaths.create(paths, PartId.Control);

            Status(paths.Logs);
            Status(paths.Archives);
            Status(paths.BuildPub);
            Status(paths.BuildStage);

            Status(files.CaptureRoot);

            foreach(var file in FS.dir((FS.FolderPath)files.AsmDir))
            {
                Status(file);
            }

        }
        public void Run()
        {
            using var s0 = new ListFormatPatterns(State.Wf, typeof(FormatLiterals));
            s0.Run();

            ReadRes();
    
            Status(TableIndex.AsmTAddressingModRm32);            
        }

    }
}