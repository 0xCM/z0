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

    using K = OperatorClasses;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        public t_asm_pipe()
        {
        }

        public void check_math()
        {
            var dSrc = ApiQuery.uri(typeof(math));
            var gSrc = ApiQuery.uri(typeof(gmath));
            var id = PartId.GMath;
            var dir = Wf.Db().CaptureRoot();
            var paths = ApiArchives.paths(Wf);
            var parsed = paths.ParsedExtractFiles();
            Claim.nonzero(parsed.Count);

            using var writer = CaseWriter(FS.ext("csv"));
            writer.WriteLine(root.timestamp().Format());
            root.iter(parsed, f => writer.WriteLine(f));

            var mHex = Db.ApiHexFile(ApiQuery.uri(typeof(math)));
            var mHexRows = ApiCode.hexrows(mHex);
            writer.WriteLine(RP.PageBreak120);
            root.iter(mHexRows, r => writer.WriteLine(r.Uri));

            var gHex = Db.ApiHexFile(ApiQuery.uri(typeof(gmath)));
            var gHexRows = ApiCode.hexrows(gHex);
            writer.WriteLine(RP.PageBreak120);
            root.iter(gHexRows, r => writer.WriteLine(r.Uri));

            var mblocks = root.map(mHexRows.View, ApiCode.block);
            check_unary_ops(mblocks);
        }

        void check_unary_ops(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                if(ApiCode.arity(code) == 1)
                {
                    if(ApiCode.accepts(code, NumericKind.U8))
                        AsmCheck.CheckFixedMatch<Cell8>(K.unary(), code, code);
                    else if(ApiCode.accepts(code, NumericKind.U16))
                        AsmCheck.CheckFixedMatch<Cell16>(K.unary(), code, code);
                    else if(ApiCode.accepts(code, NumericKind.U32))
                        AsmCheck.CheckFixedMatch<Cell32>(K.unary(), code, code);
                    else if(ApiCode.accepts(code, NumericKind.U64))
                        AsmCheck.CheckFixedMatch<Cell64>(K.unary(), code, code);
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