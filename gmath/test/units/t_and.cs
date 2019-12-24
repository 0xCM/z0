//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static zfunc;
    using D = GDel;

    public class t_and : t_gmath<t_and>
    {

        public void and_8i()
            => VerifyOp(OpKind.And, (x,y) => (sbyte)(x & y), D.and<sbyte>());

        public void and_8u()
            => VerifyOp(OpKind.And, (x,y) => (byte)(x & y), D.and<byte>());

        public void and_16i()
            => VerifyOp(OpKind.And, (x,y) => (short)(x & y), D.and<short>());            

        public void and_16u()
            => VerifyOp(OpKind.And, (x,y) => (ushort)(x & y), D.and<ushort>());

        public void and_32i()
            => VerifyOp(OpKind.And, (x,y) => (x & y), D.and<int>());

        public void and_32u()
            => VerifyOp(OpKind.And, (x,y) => (x & y), D.and<uint>());

        public void and_64i()
            => VerifyOp(OpKind.And, (x,y) => (x & y), D.and<long>());

        public void scalar_and_64u()
            => VerifyOp(OpKind.And, (x,y) => (x & y), D.and<ulong>());
 
 
        void VerifyOp<K>(OpKind opKind, BinaryOp<K> baseline, BinaryOp<K> op, bool nonzero = false, 
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                where K : unmanaged
        {
            var lhs = RandArray<K>();
            var rhs = RandArray<K>(nonzero);
            var len = length(lhs,rhs);
            var timing = stopwatch();
            
            for(var i = 0; i<len; i++)
                Claim.numeq(baseline(lhs[i],rhs[i]), op(lhs[i],rhs[i]), caller, file, line);            
        }

    }
}