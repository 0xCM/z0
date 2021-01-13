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

    public interface IApiAsmProcessor : IWfDataProcessor<IceMnemonic,ApiInstruction>
    {
        void OnAnd(ApiInstruction located)
        {

        }

        void OnOr(ApiInstruction located)
        {

        }

        void IWfDataProcessor.Connect()
        {
            Broker[IceMnemonic.And] = WfBrokers.handler<ApiInstruction>(OnAnd);
            Broker[IceMnemonic.Or] = WfBrokers.handler<ApiInstruction>(OnOr);
        }
    }
}