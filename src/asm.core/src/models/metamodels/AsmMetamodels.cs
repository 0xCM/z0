//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public partial class AsmMetamodels : Service<AsmMetamodels>
    {
        ushort Capacity = Pow2.T14;

        Index<AsmInfo> Collections;

        Index<AsmInfoRecord> Records;

        AsmInstructions I;

        uint CIx;

        uint RIx;

        public AsmMetamodels()
        {
            Collections = alloc<AsmInfo>(Capacity);
            Records = alloc<AsmInfoRecord>(Capacity);
            I = default;
            CIx = 0;
            RIx = 0;
        }

        [Op]
        public void Collect()
        {
            var dst = Collections.Edit;
            collect(I.movzx(), ref CIx, dst);
        }

        [Op]
        public void CreateRecords()
        {
            if(CIx != 0)
            {
                RIx = 0;
                AsmRecords.fill(slice(Collections.View, 0, CIx), ref RIx, Records.Edit);
            }
        }
    }
}