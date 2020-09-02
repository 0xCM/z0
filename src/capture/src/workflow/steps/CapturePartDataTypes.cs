//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;
    using static CaptureHostMembersStep;

    public readonly ref struct CapturePartDataTypes
    {
        public WfCaptureState State {get;}

        readonly IWfShell Wf;

        readonly PartId Part;

        readonly ApiDataType[] DataTypes;

        readonly IPartCapturePaths Target;

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public CapturePartDataTypes(WfCaptureState state, PartId part, ApiDataType[] types, IPartCapturePaths dst, CorrelationToken ct)
        {
            Wf = state.Wf;
            State = state;
            DataTypes = types;
            Part = part;
            Target = dst;
            Ct = ct;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        public void Execute()
        {
            Wf.Running(StepId);

            try
            {
                using var extract = new ExtractMembers(State, Ct);
                var extracted = z.@readonly(extract.Extract(DataTypes).GroupBy(x => x.Host).Select(x => kvp(x.Key, x.Array())).Array());
                var count = extracted.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var x = ref skip(extracted,i);
                    using var emit = new EmitHostArtifacts(State, x.Key, x.Value, Target, Ct);
                    emit.Run();
                }

            }
            catch(Exception e)
            {
                State.Error(StepName,e, Ct);
            }

            Wf.Ran(StepId);
        }
    }
}