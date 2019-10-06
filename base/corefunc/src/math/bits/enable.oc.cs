//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class zfoc
    {

        public static ref sbyte enable_d8i(ref sbyte src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref sbyte enable_g8i(ref sbyte src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref byte enable_d8u(ref byte src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref byte enable_g8u(ref byte src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref short enable_d16i(ref short src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref short enable_g16i(ref short src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref ushort enable_d16u(ref ushort src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref ushort enable_g16u(ref ushort src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref int enable_d32i(ref int src,int pos)
            => ref BitMask.enable(ref src, pos);

        public static ref int enable_g32i(ref int src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref uint enable_d32u(ref uint src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref uint enable_g32u(ref uint src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref long enable_d64i(ref long src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref long enable_g64i(ref long src,int pos)
            => ref BitMaskG.enable(ref src,pos);
    
        public static ref ulong enable_d64u(ref ulong src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref ulong enable_g64u(ref ulong src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref float enable_d32f(ref float src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref float enable_g32f(ref float src,int pos)
            => ref BitMaskG.enable(ref src,pos);

        public static ref double enable_d64f(ref double src,int pos)
            => ref BitMask.enable(ref src,pos);

        public static ref double enable_g64f(ref double src,int pos)
            => ref BitMaskG.enable(ref src,pos);
    }
}