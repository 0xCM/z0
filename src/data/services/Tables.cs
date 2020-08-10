//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using Z0.Data;

    using F = FarCallCountsField;

    using Asm;
    
    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Tables
    {

        [MethodImpl(Inline), Op]
        public static void render(in FarCallCounts src, StringBuilder dst)
        {            
            var formatter = Table.formatter<F>(dst);
            formatter.Delimit(F.TargetsFar, src.TargetsFar);
            formatter.Delimit(F.HostedReceivers, src.HostedReceivers);
            formatter.Delimit(F.UnhostedReceivers, src.UnhostedReceivers);        
        }                
        
        public static EnumNames<Mnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<Mnemonic>();
        }
    }
}