//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct WfStepActivation
    {
        public string Host;

        public bool Activate;

        public WfStepActivation(string host, bool run)
        {
            Host = host;
            Activate = run;
        }
    }

    public struct WfStepActivations : ITableSpan<WfStepActivation>
    {
        readonly TableSpan<WfStepActivation> Data;

        public static implicit operator WfStepActivations(WfStepActivation[] src)
            => new WfStepActivations(src);

        public WfStepActivations(WfStepActivation[] src)
        {
            Data = src;
        }

        public Span<WfStepActivation> Edit
        {
            get => Data.Edit;
        }

        public ReadOnlySpan<WfStepActivation> View
        {
            get => Data.Edit;
        }

        public WfStepActivation[] Storage
            => Data;
    }
}