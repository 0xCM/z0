//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Root;

    using K = Kinds;

    public class t_asm_pipe : t_asm<t_asm_pipe>
    {
        public t_asm_pipe()
        {
            OnDispose += HandleDispose;
        }

        void HandleDispose()
        {

        }

        void check_unary_ops(ApiCodeBlock[] src)
        {
            foreach(var code in ApiCode.withArity(src, 1))
            {
                if(ApiCode.accepts(code, NumericKind.U8))
                    AsmCheck.CheckFixedMatch<Cell8>(K.UnaryOp, code, code);
                else if(ApiCode.accepts(code, NumericKind.U16))
                    AsmCheck.CheckFixedMatch<Cell16>(K.UnaryOp, code, code);
                else if(ApiCode.accepts(code, NumericKind.U32))
                    AsmCheck.CheckFixedMatch<Cell32>(K.UnaryOp, code, code);
                else if(ApiCode.accepts(code, NumericKind.U64))
                    AsmCheck.CheckFixedMatch<Cell64>(K.UnaryOp, code, code);
            }
        }

        public void check_math()
        {
            var dSrc = ApiQuery.uri(typeof(math));
            var gSrc = ApiQuery.uri(typeof(gmath));
            var id = PartId.GMath;
            var paths = AppPaths.ForApp();
            var capture = ApiArchives.capture(paths.AppCaptureRoot);
            var archive = ApiArchives.hex(FS.dir(capture.X86Dir.Name));
            var direct = archive.Read(dSrc).ToArray();
            var generic = archive.Read(gSrc).ToArray();
            check_unary_ops(direct);
            check_unary_ops(generic);
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