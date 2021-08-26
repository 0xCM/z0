//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    public class AsmShellState : ShellState
    {
        Index<SdmOpCodeDetail> _SdmOpCodes;

        Index<ProcessAsmRecord> _ProcessAsm;

        Index<ProcessAsmRecord> _ProcessAsmSelection;

        Index<Assembly> _ApiComponents;

        public AsmShellState()
        {
            _SdmOpCodes = array<SdmOpCodeDetail>();
            _ProcessAsm = array<ProcessAsmRecord>();
            _ProcessAsmSelection = array<ProcessAsmRecord>();
            _ApiComponents = array<Assembly>();
        }

        public ReadOnlySpan<Assembly> ApiComponents()
        {
            if(_ApiComponents.IsEmpty)
                _ApiComponents = ApiRuntimeLoader.assemblies();
            return _ApiComponents;
        }

        [MethodImpl(Inline)]
        public void SdmOpCodeDetail(SdmOpCodeDetail[] src)
        {
            _SdmOpCodes = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<SdmOpCodeDetail> SdmOpCodeDetail()
            => _SdmOpCodes.View;

        [MethodImpl(Inline)]
        public Span<ProcessAsmRecord> ProcessAsmSelection()
            => _ProcessAsmSelection.Edit;

        public uint ProcessAsmCount
        {
            [MethodImpl(Inline)]
            get => _ProcessAsm.Count;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<ProcessAsmRecord> ProcessAsm()
        {
            if(_ProcessAsm.IsEmpty)
            {
                var result = LoadProcessAsm();
                if(result.Fail)
                    Wf.Error(result.Message);
            }
            return _ProcessAsm;
        }


        // [MethodImpl(Inline)]
        // public ReadOnlySpan<ProcessAsmRecord> ProcessAsm(Index<ProcessAsmRecord> src)
        // {
        //     _ProcessAsm = src;
        //     _ProcessAsmSelection = alloc<ProcessAsmRecord>(_ProcessAsm.Count);
        //     return ProcessAsm();
        // }

        Outcome LoadProcessAsm()
        {
            var archive = Wf.ApiPacks().Current().Archive();
            var path = archive.ProcessAsmPath();
            var buffer = alloc<ProcessAsmRecord>(AsmEtl.ProcessAsmCount(path));
            var flow = Wf.Running(string.Format("Loading process asm from {0}", path.ToUri()));
            var result = AsmEtl.LoadProcessAsm(path, buffer);
            if(result.Fail)
                return (false, result.Message);

            _ProcessAsm = buffer;
            _ProcessAsmSelection = alloc<ProcessAsmRecord>(_ProcessAsm.Count);

            Wf.Ran(flow, string.Format("Loaded {0} process asm records from {1}", _ProcessAsm.Length, path.ToUri()));
            return true;
        }
    }
}