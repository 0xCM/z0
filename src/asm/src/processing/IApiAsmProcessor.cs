//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public enum AsmHandlerKind : ushort
    {
    }

    public interface IApiAsmProcessor : IAsmDataProcessor<Mnemonic,ApiInstruction>
    {
        void OnAnd(ApiInstruction located)
        {

        }

        void OnOr(ApiInstruction located)
        {

        }

        void IWfDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = WfCore.handler<ApiInstruction>(OnAnd);
            Broker[Mnemonic.Or] = WfCore.handler<ApiInstruction>(OnOr);
        }
    }
}