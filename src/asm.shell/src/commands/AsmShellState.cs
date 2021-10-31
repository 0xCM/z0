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

    public class AsmShellState : CmdShellState
    {
        Index<SdmOpCodeDetail> _SdmOpCodeDetails;

        Index<ProcessAsmRecord> _ProcessAsm;

        Index<ProcessAsmRecord> _ProcessAsmSelection;

        Index<Assembly> _ApiComponents;

        Index<CompilationLiteral> _ApiLiterals;

        Index<HostAsmRecord> _HostAsm;

        Index<AsmDataBlock> _AsmBlocks;

        IApiCatalog _ApiCatalog;

        public AsmShellState()
        {
            _SdmOpCodeDetails = array<SdmOpCodeDetail>();
            _ProcessAsm = array<ProcessAsmRecord>();
            _ProcessAsmSelection = array<ProcessAsmRecord>();
            _ApiComponents = array<Assembly>();
            _ApiLiterals = array<CompilationLiteral>();
            _HostAsm = array<HostAsmRecord>();
            _AsmBlocks = array<AsmDataBlock>();
        }

        public ReadOnlySpan<Assembly> ApiComponents()
        {
            if(_ApiComponents.IsEmpty)
                _ApiComponents = ApiRuntimeLoader.assemblies();
            return _ApiComponents;
        }

        public ReadOnlySpan<AsmDataBlock> Records(Func<Index<AsmDataBlock>> loader)
        {
            if(_AsmBlocks.IsEmpty)
                _AsmBlocks = loader();
            return _AsmBlocks;
        }

        public ReadOnlySpan<SdmOpCodeDetail> Records(Func<Index<SdmOpCodeDetail>> loader)
        {
            if(_SdmOpCodeDetails.IsEmpty)
                _SdmOpCodeDetails = loader();
            return _SdmOpCodeDetails;
        }

        public IApiCatalog ApiCatalog(Func<IApiCatalog> loader)
        {
            if(_ApiCatalog == null)
                _ApiCatalog = loader();
            return _ApiCatalog;
        }

        public ReadOnlySpan<HostAsmRecord> HostAsm(Func<Index<HostAsmRecord>> loader)
        {
            if(_HostAsm.IsEmpty)
                _HostAsm = loader();
            return _HostAsm;
        }

        public ReadOnlySpan<CompilationLiteral> ApiLiterals(Func<Index<CompilationLiteral>> loader)
        {
            if(_ApiLiterals.IsEmpty)
                _ApiLiterals = loader();
            return _ApiLiterals;
        }

        [MethodImpl(Inline)]
        public void SdmOpCodes(SdmOpCodeDetail[] src)
        {
            _SdmOpCodeDetails = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<SdmOpCodeDetail> SdmOpCodeDetail()
            => _SdmOpCodeDetails.View;

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

        Outcome LoadProcessAsm()
        {
            var archive = Wf.ApiPacks().Current().Archive();
            var path = archive.ProcessAsmPath();
            var count = FS.linecount(path,TextEncodingKind.Asci) - 1;
            var buffer = alloc<ProcessAsmRecord>(count);
            var flow = Wf.Running(string.Format("Loading process asm from {0}", path.ToUri()));
            var result = asm.load(path, buffer);
            if(result.Fail)
                return (false, result.Message);

            _ProcessAsm = buffer;
            _ProcessAsmSelection = alloc<ProcessAsmRecord>(_ProcessAsm.Count);

            Wf.Ran(flow, string.Format("Loaded {0} process asm records from {1}", _ProcessAsm.Length, path.ToUri()));
            return true;
        }
    }
}