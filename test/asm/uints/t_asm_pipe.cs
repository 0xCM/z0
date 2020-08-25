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


        void check_unary_ops(IdentifiedCode[] src)
        {
            var query = AsmCheck.UriBitQuery;
            foreach(var code in query.WithParameterCount(src, 1))
            {
                if(query.AcceptsParameter(code, NumericKind.U8))
                    AsmCheck.CheckFixedMatch<Fixed8>(K.UnaryOp, code, code);
                else if(query.AcceptsParameter(code, NumericKind.U16))
                    AsmCheck.CheckFixedMatch<Fixed16>(K.UnaryOp, code, code);
                else if(query.AcceptsParameter(code, NumericKind.U32))
                    AsmCheck.CheckFixedMatch<Fixed32>(K.UnaryOp, code, code);
                else if(query.AcceptsParameter(code, NumericKind.U64))
                    AsmCheck.CheckFixedMatch<Fixed64>(K.UnaryOp, code, code);
            }
        }

        public void check_math()
        {
            var dSrc = ApiHostUri.FromHost(typeof(math));
            var gSrc = ApiHostUri.FromHost(typeof(gmath));
            var id = PartId.GMath;
            var paths = AppPaths.ForApp(PartId.Control);
            var capture = AsmCheck.CaptureArchive(paths.AppCaptureRoot);
            var archive = Archives.hex(capture.CodeDir);
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