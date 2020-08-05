//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    
    class FsmContext : IFsmContext
    {
        public IPolyrand Random {get;}  

        public FsmContext(IPolyrand random, ulong? receiptLimit = null)
        {
            this.Random = random;
            this.ReceiptLimit = receiptLimit ?? (ulong)Pow2.T14;
        }

        /// <summary>
        /// If specified, the maximum number of event submissions the machine
        /// will accept prior to forced termination
        /// </summary>
        public ulong? ReceiptLimit {get;}
    }
}