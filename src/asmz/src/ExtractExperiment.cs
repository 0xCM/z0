//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    class ExtractExperiment : AppService<ExtractExperiment>
    {
        ApiExtractPipe ExtractPipe;

        protected override void OnInit()
        {
            ExtractPipe = Wf.ApiExtractPipe();
        }

        [Op]
        public static Index<ApiCodeBlock> parse(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiCodeBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = parse(skip(src,i));
            return buffer;
        }

        [Op]
        public static ApiCodeBlock parse(in ApiExtractBlock src)
        {
            var j = terminal(src);
            var code = slice(src.View, 0, j);
            return new ApiCodeBlock(src.BaseAddress, src.Uri, code.ToArray());
        }

        [MethodImpl(Inline), Op]
        static uint terminal(ReadOnlySpan<byte> src)
        {
            var count = (uint)src.Length;
            var j = count;
            var test = 0u;
            for(var i=0u; i<count - 1; i++)
            {
                test = terminal(skip(src,i),skip(src, i+1));
                if(test !=0)
                {
                    j = i + test;
                    break;
                }
            }

            return j;
        }

        /// <summary>
        /// Attempts to find the logical end of the block
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        static uint terminal(in ApiExtractBlock src)
            => terminal(src.Encoded.View);

        /// <summary>
        /// Tests for a terminal opcode sequence
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <returns>
        /// This follows https://github.com/microsoft/Detours/samples/disas/disas.cpp, but seems to miss a lot
        /// </returns>
        [MethodImpl(Inline), Op]
        static byte terminal(byte a0, byte a1)
        {
            if(0xC3 == a0 && 0x00 == a1)
                return 2;

            if (0xCB == a0 || 0xC2 == a0 || 0xCA == a0 || 0xEB == a0 || 0xE9 == a0 || 0xEA == a0)
                return 1;

            if(0xff == a0 && 0x25 == a1)
                return 2;

            return 0;
        }


        /// c3 19 01 01
        static ReadOnlySpan<byte> Term4B => new byte[4]{0xc3, 0x19, 0x01, 01};

        //c3 00 00 19
        static ReadOnlySpan<byte> Term4A => new byte[4]{0xc3, 0, 0, 0x19};

        // cc cc cc
        static ReadOnlySpan<byte> Term3A => new byte[3]{0xcc, 0xcc, 0xcc};

        // cc 00 19
        static ReadOnlySpan<byte> Term3B => new byte[3]{0xcc, 0, 0x19};

        //19 00 00 00 40 00
        static ReadOnlySpan<byte> Term6A => new byte[6]{0x19, 0, 0, 0, 0x40, 0};

        //19 04 01 00 04 42
        static ReadOnlySpan<byte> Term6B => new byte[6]{0x19, 0x4, 0x1, 0, 0x4, 0x42};

        //c3 00 00 00 19 01
        static ReadOnlySpan<byte> Term6C => new byte[6]{0xc3, 0, 0, 0, 0x19, 0x01};

        static ReadOnlySpan<byte> Term3C => new byte[3]{0x48, 0xFF, 0};

        // 00 00 00 00 00
        static ReadOnlySpan<byte> Term5 => new byte[5]{0, 0, 0, 0, 0};

        int Terminal(in ApiExtractBlock src)
        {
            const byte MaxSeg = 6;
            var data = src.View;
            var size = data.Length;
            var found = NotFound;
            var max = size + MaxSeg - 1;
            var segsize = z8;
            for(var offset=0; offset<max; offset++)
            {
                if(slice(data, offset, 3).SequenceEqual(Term3A))
                {
                    found = offset;
                    segsize = 3;
                    break;
                }
                else if(slice(data, offset, 6).SequenceEqual(Term6A))
                {
                    found = offset;
                    segsize = 6;
                    break;
                }
                // else if(slice(data, offset, 6).SequenceEqual(Term6B))
                // {
                //     found = offset;
                //     segsize = 6;
                //     break;
                // }
                // else if(slice(data, offset, 6).SequenceEqual(Term6C))
                // {
                //     found = offset;
                //     segsize = 6;
                //     break;
                // }
                else if(slice(data, offset, 5).SequenceEqual(Term5))
                {
                    found = offset;
                    segsize = 5;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4A))
                {
                    found = offset;
                    segsize = 4;
                    break;
                }
                else if(slice(data, offset, 3).SequenceEqual(Term3B))
                {
                    found = offset;
                    segsize = 3;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4B))
                {
                    found = offset;
                    segsize = 4;
                    break;
                }
                // else if(slice(data, offset, 3).SequenceEqual(Term3C))
                // {
                //     found = offset;
                //     segsize = 3;
                //     break;
                // }
            }

            return found;
        }

        uint Run(FS.FilePath src, StepLog success, StepLog fail)
        {
            var counter = 0u;
            var running= Wf.Running(string.Format("Processed extract blocks from {0}", src.ToUri()));
            var dst = root.datalist<ApiExtractBlock>();
            var count = ExtractPipe.Load(src, dst);
            var extracts = dst.View();
            var found = 0u;

            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(extracts,i);
                var offset = Terminal(extract);
                if(offset == NotFound)
                {
                    fail.WriteLine(extract.Data.FormatHex());
                }
                else
                {
                    found++;
                    success.WriteLine(string.Format("{0,-8} | {1}", offset, extract.Data.FormatHex()));

                }
                counter++;
            }

            Wf.Ran(running, string.Format("Processed {0} extract blocks from {1} from which {2} terminals were identified", counter, src.ToUri(), found));

            return counter;
        }
        public void Run()
        {
            var paths = ExtractPipe.Paths().View;
            var count = paths.Length;
            using var success = Db.StepLog(GetType(), "terminals-found", FS.Csv);
            using var fail = Db.StepLog(GetType(), "terminals-not-found", FS.Csv);

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                Run(path, success,fail);
            }

            // var parsed = parse(extracts);
            // var hex = Wf.ApiHex();
            // var packed = hex.BuildHexPack(parsed);
            // var outfile = Db.AppLog("apihex", FS.ext("xpack"));
            // hex.EmitHexPack(parsed.ToArray(), outfile);
        }
    }
}