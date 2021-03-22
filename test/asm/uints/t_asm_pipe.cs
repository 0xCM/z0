//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    using K = OperatorClasses;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        const string LinePattern ="{0,-36} | {1,-16} | {2}";
        const string NamePattern = "{0}/{1}";

        public void t_check_hex_blocks()
        {

            var archive = Wf.ApiHexArchive();
            using var writer = CaseWriter(FS.Extensions.Csv);
            writer.WriteLine(string.Format(LinePattern, "Operation", "BaseAddress", "Hex"));

            var direct = ApiIndex.create(archive.HostBlocks<math>().Array());
            var generic = ApiIndex.create(archive.HostBlocks<gmath>().Array());

            write(direct.Values, writer);
            write(generic.Values, writer);

        }


        void write(IEnumerable<ApiCodeBlock> src, StreamWriter dst)
        {
            root.iter(src, block => dst.WriteLine(string.Format(LinePattern,  string.Format(NamePattern, block.Uri.Host, block.OpId), block.BaseAddress, block.Code)));

        }

        public void check_math()
        {
            var dSrc = typeof(math).HostUri();
            var gSrc = typeof(gmath).HostUri();
            var id = PartId.GMath;
            var parsed = Wf.Db().ParsedExtractFiles();
            Claim.nonzero(parsed.Count);

            using var writer = CaseWriter(FS.ext("csv"));
            writer.WriteLine(root.timestamp().Format());
            root.iter(parsed, f => writer.WriteLine(f));

            var mHex = Db.ApiHexFile(typeof(math).HostUri());
            var mHexRows = ApiHex.rows(mHex);
            writer.WriteLine(RP.PageBreak120);
            root.iter(mHexRows, r => writer.WriteLine(r.Uri));

            var gHex = Db.ApiHexFile(typeof(gmath).HostUri());
            var gHexRows = ApiHex.rows(gHex);
            writer.WriteLine(RP.PageBreak120);
            root.iter(gHexRows, r => writer.WriteLine(r.Uri));

            var mblocks = root.map(mHexRows.View, ApiHex.block);
            check_unary_ops(mblocks);
        }

        void log<F>(UnaryEval<UnaryOperatorClass,F> a, UnaryEval<UnaryOperatorClass,F> b, bit matched, StreamWriter dst)
        {
            dst.WriteLine($"f({a.A}) = {a.Result} | g({b.A}) = {b.Result} | {matched}");
        }

        void check_unary_ops(ReadOnlySpan<ApiCodeBlock> src)
        {
            using var writer = CaseWriter(FS.Extensions.Log);
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                var uri = code.OpUri;
                if(ApiCode.arity(code) == 1)
                {
                    writer.WriteLine($"Validating {uri}");
                    if(ApiCode.accepts(code, NumericKind.U8))
                    {
                        writer.WriteLine($"{uri} is an 8-bit unary operator");
                        var results = AsmCheck.EvalEquality<Cell8>(K.unary(), code, code);
                        root.iter(results,result => log(result.A, result.B, result.Result, writer));
                    }
                    else if(ApiCode.accepts(code, NumericKind.U16))
                    {
                        writer.WriteLine($"{uri} is a 16-bit unary operator");
                        var results = AsmCheck.EvalEquality<Cell16>(K.unary(), code, code);
                        root.iter(results,result => log(result.A, result.B, result.Result, writer));
                    }
                    else if(ApiCode.accepts(code, NumericKind.U32))
                    {
                        writer.WriteLine($"{uri} is a 32-bit unary operator");
                        var results = AsmCheck.EvalEquality<Cell32>(K.unary(), code, code);
                        root.iter(results,result => log(result.A, result.B, result.Result, writer));
                    }
                    else if(ApiCode.accepts(code, NumericKind.U64))
                    {
                        writer.WriteLine($"{uri} is a 64-bit unary operator");
                        var results = AsmCheck.EvalEquality<Cell64>(K.unary(), code, code);
                        root.iter(results,result => log(result.A, result.B, result.Result, writer));
                    }
                    else
                    {
                        writer.WriteLine($"{uri} form unrecognized");
                    }
                }
            }
        }
    }

    unsafe struct FixedTest
    {
        fixed ulong Data[10];

        TxN<sbyte,byte,short,ushort,int,uint> T;

        [MethodImpl(Inline), Op]
        public static FixedTest init(ref ulong src)
        {
            var lu = new FixedTest();
            var pData = lu.Data;
            *pData++ = skip(src,0);
            *pData++ = skip(src,1);
            *pData++ = skip(src,2);
            *pData++ = skip(src,3);
            *pData++ = skip(src,4);
            *pData++ = skip(src,5);
            *pData++ = skip(src,6);
            *pData++ = skip(src,7);
            *pData++ = skip(src,8);
            *pData++ = skip(src,9);
            return lu;
        }

        [MethodImpl(Inline), Op]
        public static ref ulong Lookup(in FixedTest src, byte index)
        {
            fixed(ulong* pData = src.Data)
            {
                ref var rData = ref Unsafe.AsRef<ulong>(pData);
                return ref Unsafe.Add(ref rData, index);
            }
        }
    }
}