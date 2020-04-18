//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Z0.Seed;
    using static Memories;


    public readonly struct ActionValidator : ICheckAction
    {
        public void CheckAction(Action f, OpIdentity id)
        {
            throw new NotImplementedException();
        }

        public void CheckAction(Action f, string name)
        {
            throw new NotImplementedException();
        }
    }
}