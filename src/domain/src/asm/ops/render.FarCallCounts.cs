//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Konst;
    
    using F = FarCallCountsField;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public void render(in FarCallCounts src, StringBuilder dst)
        {            
            var formatter = Tables.formatter<F>();
            formatter.Append(F.TargetsFar, src.TargetsFar);
            formatter.Delimit(F.HostedReceivers, src.HostedReceivers);
            formatter.Delimit(F.UnhostedReceivers, src.UnhostedReceivers);
        }        
    }
}